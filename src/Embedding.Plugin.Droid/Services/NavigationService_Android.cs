using Android.Content;
using Embedding.Plugin.Droid.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationService_Android))]
namespace Embedding.Plugin.Droid.Services
{
    public class NavigationService_Android : INavigationService
    {
        public void NavigateAsync(ContentPage page)
        {
            var intent = new Intent(PluginHelper.CurrentActivity, typeof(GenericActivity));
            var type = page.GetType();
            intent.PutExtra("page", type.FullName);
            intent.PutExtra("assembly", type.Assembly.GetName().Name);
            PluginHelper.CurrentActivity.StartActivity(intent);
        }
    }
}