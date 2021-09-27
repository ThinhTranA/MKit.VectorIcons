using MKit.VectorIconsSample.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MKit.VectorIconsSample.Fonts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZocialPage : ContentPage
    {
        public ZocialPage(IconSet iconSet)
        {
            InitializeComponent();
            BindingContext = new ZocialViewModel(iconSet);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchTerm = e.NewTextValue;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = string.Empty;
            }

            var vm = (ZocialViewModel)BindingContext;
            vm.FilterIconList(searchTerm);
        }
    }
}