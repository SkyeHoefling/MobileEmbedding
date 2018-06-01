namespace Embedding.Plugin.ViewModels
{
    public class NetworkRequestViewModel : BaseViewModel<NetworkResponsePage>
    {
        private const string _title = "Network Request Page";
        private const string _subHeader = "Tests a network request to google";
        private const string _description = "By clicking the \"Send\" button the page will make a network request to google.com and return the html on the next screen";

        public NetworkRequestViewModel() :
            base(_title, _subHeader, _description)
        { }
    }
}
