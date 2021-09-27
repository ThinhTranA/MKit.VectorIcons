using MKit.VectorIconsSample.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MKit.VectorIconsSample.Fonts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FeatherPage : ContentPage
    {
        public FeatherPage(IconSet iconSet)
        {
            InitializeComponent();
            BindingContext = new FeatherViewModel(iconSet);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchTerm = e.NewTextValue;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = string.Empty;
            }

            var vm = (FeatherViewModel)BindingContext;
            vm.FilterIconList(searchTerm);
        }
    }
}