namespace Embedding.Plugin.ViewModels
{
    public class CommandBindingViewModel : BaseViewModel<NetworkRequestPage>
    {
        private const string _title = "View Model Page";
        private const string _subHeader = "A simple page to demonstrate the power of Model-View-ViewModel (MVVM) Architecture utilizing XAML Binding Syntax. Yes this is still Xamarin.Forms";
        private const string _description = "This page was written in XAML using Xamarin.Forms it utilizes the MVVM Architecture by creating a ViewModel. In the XAML we are using the Binding markup extensions to bind properties from our ViewModel into the view. This is how we decouple the 2 components from each other which include strings for the data you see on the screen and ICommand to handle touch events.";
        public CommandBindingViewModel() :
            base(_title, _subHeader, _description)
        { }
    }
}
