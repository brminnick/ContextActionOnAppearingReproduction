using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ContextActionOnAppearingReproduction
{
    public class MyListPage : ContentPage
    {
        public MyListPage()
        {
            switch(Device.RuntimePlatform)
            {
				case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
            }

			Content = new ListView(ListViewCachingStrategy.RecycleElement)
			{
                ItemTemplate = new DataTemplate(typeof(MyTextCell)),
				ItemsSource = GenerateListViewItemSource()
			};
        }

        List<int> GenerateListViewItemSource()
        {
            var random = new Random((int)DateTime.Now.Ticks);

            var list = new List<int>();
            for (int i = 0; i < 10; i++)
                list.Add(random.Next(100, 1000000));

            return list;
        }
    }
}
