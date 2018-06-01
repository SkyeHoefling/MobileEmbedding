using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Embedding.Plugin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var naviationService = DependencyService.Get<INavigationService>();
            naviationService.NavigateAsync(new CodePage());
        }
    }
}