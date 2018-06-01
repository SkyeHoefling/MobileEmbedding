using Xamarin.Forms;

namespace Embedding.Plugin
{
    public interface INavigationService
    {
        void NavigateAsync(ContentPage page);
        void NavigateBackAsync();
    }
}
