using System.Windows.Input;
using Xamarin.Forms;

namespace Embedding.Plugin.ViewModels
{
    public abstract class BaseViewModel
    {
        public BaseViewModel(string title, string subheader, string description)
        {
            Title = title;
            SubHeader = subheader;
            Description = description;
        }
        public string Title { get; }
        public string SubHeader { get; }
        public string Description { get; }

        public ICommand Back => new Command(() =>
        {
            var navigationService = DependencyService.Get<INavigationService>();
            navigationService.NavigateBackAsync();
        });
    }

    public abstract class BaseViewModel<TNextPage> : BaseViewModel
        where TNextPage : ContentPage
    {
        public BaseViewModel(string title, string subheader, string description)
            : base(title, subheader, description) { }

        public ICommand NextPage => new Command(() =>
        {
            var navigationService = DependencyService.Get<INavigationService>();
            navigationService.NavigateAsync<TNextPage>();
        });        
    }
}
