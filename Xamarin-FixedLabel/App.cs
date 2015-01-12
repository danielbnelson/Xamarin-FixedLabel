using System;
using Xamarin.Forms;

namespace XamarinFixedLabel
{
	public class App
	{
		public static Page GetMainPage ()
		{	
	

			return new ContentPage { 
			
				Content = new FixedLabel("Hello, Forms!",100,100) {
					Text = "Hello, Forms!",
					TextColor = Color.Blue,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},


			};
		}
	}
}

