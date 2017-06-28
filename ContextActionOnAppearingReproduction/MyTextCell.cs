using Xamarin.Forms;

namespace ContextActionOnAppearingReproduction
{
    public class MyTextCell : TextCell
    {
        readonly MenuItem _menuItem = new MenuItem { Text = "Do Nothing" };

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ContextActions.Add(_menuItem);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            ContextActions.Remove(_menuItem);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            Text = string.Empty;
            Detail = string.Empty;

            var model = (int)BindingContext;

            Text = "Number";
            Detail = model.ToString();
        }
    }
}
