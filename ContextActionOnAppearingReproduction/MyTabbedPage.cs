using Xamarin.Forms;

namespace ContextActionOnAppearingReproduction
{
    public class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            Children.Add(new MyListPage { Title = "List 1" });
            Children.Add(new MyListPage { Title = "List 2" });
        }
    }
}
