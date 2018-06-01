
using System;
using Android.App;
using Android.OS;
using Android.Runtime;

namespace Embedding.Plugin.Droid
{
    [Activity(Label = "GenericActivity")]
#if NATIVE
    [Register("embedding.plugin.droid.GenericActivity")]
#endif
    class GenericActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.plugin_layout);
            var page = this.Intent.GetStringExtra("page");
            var assembly = this.Intent.GetStringExtra("assembly");

            if (string.IsNullOrWhiteSpace(page) || string.IsNullOrWhiteSpace(assembly))
            {
                throw new Exception("GenericActivity requires both a page and assembly to load the correct ContentPage");
            }

            Draw((Type: page, Assembly: assembly));
        }

        public void Draw((string Type, string Assembly) classname)
        {
            PluginHelper.CurrentActivity = this;
            var helper = new PluginHelper();
            var frag = helper.Create(this, classname);
            if (frag == null) return;

            var ft = FragmentManager.BeginTransaction();
            ft.Replace(Resource.Id.my_plugin_control, frag, "main");
            ft.Commit();
        }
    }
}