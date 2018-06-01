
using Xamarin.Forms;

namespace Embedding.Plugin
{
    public class CodePage : ContentPage
	{
		public CodePage ()
		{
			Content = new StackLayout {
				Children = {
					new Label
                    {
                        Text = "Welcome to a page build by code instead of C#!",
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    }
				}
			};
		}
	}
}