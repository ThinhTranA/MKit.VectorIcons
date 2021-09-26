using Maui.VectorIconsSample.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maui.VectorIconsSample.Fonts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EvilIconsPage : ContentPage
    {
        public EvilIconsPage(IconSet iconSet)
        {
            InitializeComponent();
            BindingContext = new EvilIconsViewModel(iconSet);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchTerm = e.NewTextValue;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = string.Empty;
            }

            var vm = (EvilIconsViewModel)BindingContext;
            vm.FilterIconList(searchTerm);
        }
    }
}