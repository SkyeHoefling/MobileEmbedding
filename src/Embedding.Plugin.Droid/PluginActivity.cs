
using System;
using Android.App;
using Android.OS;
using Android.Runtime;

namespace Embedding.Plugin.Droid
{
    [Activity(Label = "PluginActivity")]
#if NATIVE
    [Register("embedding.plugin.droid.PluginActivity")]
#endif
    public class PluginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.plugin_layout);

            PluginHelper.CurrentActivity = this;
            var helper = new PluginHelper();
            var frag = helper.Create(this);

            var ft = FragmentManager.BeginTransaction();
            ft.Replace(Resource.Id.my_plugin_control, frag, "main");
            ft.Commit();
        }
    }
}