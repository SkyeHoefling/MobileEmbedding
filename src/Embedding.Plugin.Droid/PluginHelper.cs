
using Android.App;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Embedding.Plugin.Droid
{
    public class PluginHelper
    {
        public Fragment Create(Context context)
        {
            if (!Forms.IsInitialized)
            {
                Forms.Init(context, null);
            }

            return new MainPage().CreateFragment(context);
        }
    }
}