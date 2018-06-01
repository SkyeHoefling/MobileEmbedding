using Xamarin.Forms;

namespace Embedding.Plugin
{
    public interface INavigationService
    {
        void NavigateAsync<TPage>() where TPage : ContentPage;
        void NavigateBackAsync();
    }
}
