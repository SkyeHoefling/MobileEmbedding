
using Android.App;
using Android.Content;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Embedding.Plugin.Droid
{
    public class PluginHelper
    {
        public static Activity CurrentActivity = null;

        public Fragment Create(Context context)
        {
            if (!Forms.IsInitialized)
            {
                InitializeForms(context);
            }

            return new MainPage().CreateFragment(context);
        }

        public Fragment Create<TPage>(Context context)
            where TPage : ContentPage
        {
            return Create(context, typeof(TPage));
        }

        public Fragment Create(Context context, (string Type, string Assembly) classname)
        {
            Console.WriteLine(classname);
            try
            {
                var contentPage = (ContentPage)Activator.CreateInstance(classname.Assembly, classname.Type)?.Unwrap();
                if (contentPage != null)
                {
                    return contentPage.CreateFragment(context);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to create an instance of type: {classname.Type} from assembly: {classname.Assembly}");
            }

            return null;
        }

        public Fragment Create(Context context, Type page)
        {
            if (!Forms.IsInitialized)
            {
                InitializeForms(context);
            }

            var contentPage = (ContentPage)Activator.CreateInstance(page);
            return contentPage.CreateFragment(context);
        }

        private void InitializeForms(Context context)
        {
            Forms.Init(context, null);
            DependencyService.Register<INavigationService>();
        }
    }
}