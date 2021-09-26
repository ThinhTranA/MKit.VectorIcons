using Maui.VectorIconsSample.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maui.VectorIconsSample.Fonts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleLineIconsPage : ContentPage
    {
        public SimpleLineIconsPage(IconSet iconSet)
        {
            InitializeComponent();
            BindingContext = new SimpleLineIconsViewModel(iconSet);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchTerm = e.NewTextValue;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = string.Empty;
            }

            var vm = (SimpleLineIconsViewModel)BindingContext;
            vm.FilterIconList(searchTerm);
        }
    }
}