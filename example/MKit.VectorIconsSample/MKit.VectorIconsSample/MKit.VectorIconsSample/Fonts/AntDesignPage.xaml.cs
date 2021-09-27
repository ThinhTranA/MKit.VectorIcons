using MKit.VectorIconsSample.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MKit.VectorIconsSample.Fonts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AntDesignPage : ContentPage
    {
        public AntDesignPage(IconSet iconSet)
        {
            InitializeComponent();
            BindingContext = new AntDesignViewModel(iconSet);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchTerm = e.NewTextValue;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = string.Empty;
            }

            var vm = (AntDesignViewModel)BindingContext;
            vm.FilterIconList(searchTerm);
        }
    }
}