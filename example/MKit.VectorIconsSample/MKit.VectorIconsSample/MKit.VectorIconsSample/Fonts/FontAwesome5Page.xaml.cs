using MKit.VectorIconsSample.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MKit.VectorIconsSample.Fonts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FontAwesome5Page : ContentPage
    {
        public FontAwesome5Page(IconSet iconSet)
        {
            InitializeComponent();
            BindingContext = new FontAwesome5ViewModel(iconSet);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchTerm = e.NewTextValue;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = string.Empty;
            }

            var vm = (FontAwesome5ViewModel)BindingContext;
            vm.FilterIconList(searchTerm);
        }
    }
}