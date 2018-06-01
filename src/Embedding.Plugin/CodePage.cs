
using Xamarin.Forms;

namespace Embedding.Plugin
{
    public class CodePage : ContentPage
	{
		public CodePage ()
		{
            var backButton = new Button { Text = "Back" };
            backButton.Clicked += (s, e) =>
            {
                var navigationService = DependencyService.Get<INavigationService>();
                navigationService.NavigateBackAsync();
            };

            var nextButton = new Button
            {
                Text = "Next Page",
                HorizontalOptions = LayoutOptions.EndAndExpand
            };
            nextButton.Clicked += (s, e) =>
            {
                var navigationService = DependencyService.Get<INavigationService>();
                navigationService.NavigateAsync(new CommandBindingPage());
            };

			Content = new StackLayout {
				Children = {
                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Children = {
                            new Label
                            {
                                Text = "Xamarin.Forms Supports UI by C#!",
                                FontSize = 25,
                                VerticalOptions = LayoutOptions.CenterAndExpand,
                                HorizontalOptions = LayoutOptions.CenterAndExpand
                            },
                            new Label
                            {
                                Text = "This page was built entirely from C#",
                                VerticalOptions = LayoutOptions.CenterAndExpand,
                                HorizontalOptions = LayoutOptions.CenterAndExpand
                            }
                        }
                    },
					new Label
                    {
                        Text = "This style of page is very powerful if you need to build a dynamic page but it is considered bbest practice to use XAML which allows you to easily decouple your UI code from your business rules. Seperation of concerns is very important in Xamarin",
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Margin = 20
                    },
                    new StackLayout
                    {
                        Margin = 20,
                        VerticalOptions = LayoutOptions.EndAndExpand,
                        Orientation = StackOrientation.Horizontal,
                        Children = {
                            backButton,
                            nextButton
                        }
                    }
				}
			};
		}
	}
}