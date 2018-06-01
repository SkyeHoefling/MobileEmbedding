using Embedding.Plugin.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Embedding.Plugin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NetworkResponsePage : ContentPage
	{
		public NetworkResponsePage ()
		{
			InitializeComponent ();
            BindingContext = new NetworkResponseViewModel();
		}
	}
}