using System;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace Embedding.Plugin.ViewModels
{
    public class NetworkResponseViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private const string _title = "Network Response Page";
        private const string _subHeader = "The results of the request";

        public NetworkResponseViewModel() :
            base(_title, _subHeader, string.Empty)
        {
            ExecuteRequest();
            
        }

        private string _response;
        public string Response
        {
            get { return _response; }
            set
            {
                if (_response != value)
                {
                    _response = value;
                    RaisePropertyNotifyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyNotifyChanged([CallerMemberName]string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private async void ExecuteRequest()
        {
            string url = "http://google.com";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get
            };

            var response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                Response = "There was an error sending the request";
                return;
            }

            Response = await response.Content.ReadAsStringAsync();

        }
    }
}
