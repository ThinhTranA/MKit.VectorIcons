using MKit.VectorIconsSample.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MKit.VectorIconsSample.Fonts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FontAwesomePage : ContentPage
    {
        public FontAwesomePage(IconSet iconSet)
        {
            InitializeComponent();
            BindingContext = new FontAwesomeViewModel(iconSet);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchTerm = e.NewTextValue;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = string.Empty;
            }

            var vm = (FontAwesomeViewModel)BindingContext;
            vm.FilterIconList(searchTerm);
        }
    }
}