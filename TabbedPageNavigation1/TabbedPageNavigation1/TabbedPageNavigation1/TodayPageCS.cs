using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TabbedPageNavigation1
{
	public class TodayPageCS : ContentPage
	{
		public TodayPageCS()
		{
			IconImageSource = "Day.png";
			Title = "Today";
			Content = new StackLayout
			{
				Children = {
					new Label {
						Text = "Today's appointments go here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}