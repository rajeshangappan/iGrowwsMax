using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TabbedPageNavigation1
{
	public class SettingsPageCS : ContentPage
	{
		public SettingsPageCS()
		{
			IconImageSource = "settings.png";
			Title = "Settings";
			Content = new StackLayout
			{
				Children = {
					new Label {
						Text = "Settings go here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}

