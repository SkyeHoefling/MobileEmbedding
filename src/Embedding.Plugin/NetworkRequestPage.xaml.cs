using Embedding.Plugin.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Embedding.Plugin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NetworkRequestPage : ContentPage
	{
		public NetworkRequestPage ()
		{
			InitializeComponent ();
            BindingContext = new NetworkRequestViewModel();

        }
	}
}