using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Xamarin.Forms;
using XamarinEmbedding.Plugin.Shared;
using Xamarin.Forms.Platform.Android;

namespace XamarinEmbedding.Sample.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Forms.Init(this, null);
            var frag = new HelloWorldPage().CreateFragment(this);
            var ft = FragmentManager.BeginTransaction();
            ft.Replace(Resource.Id.fragment_frame_layout, frag, "main");
            ft.Commit();
        }
    }
}

