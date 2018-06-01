
using Embedding.Plugin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Embedding.Plugin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CommandBindingPage : ContentPage
	{
		public CommandBindingPage ()
		{
			InitializeComponent ();
            BindingContext = new CommandBindingViewModel();
		}
	}
}