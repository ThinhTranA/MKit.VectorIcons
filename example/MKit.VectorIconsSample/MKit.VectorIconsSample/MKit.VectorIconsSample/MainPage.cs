using MKit.VectorIcons;
using VectorIcons;
using Xamarin.Forms;

namespace MKit.VectorIconsSample
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            var iconExplorerPage = new NavigationPage(new IconExplorerPage());
             iconExplorerPage.Title = "Icon Explorer";
             iconExplorerPage.IconImageSource = new FontImageSource
             {
                 Glyph = FontAwesomeFont.Search.ConvertToString(),
                 FontFamily = FontFamily.FontAwesome,
             };
             
             var iconButtonPage = new NavigationPage(new IconButtonPage());
             iconButtonPage.Title = "Icon Button";
             iconButtonPage.IconImageSource = new FontImageSource
             {
                 Glyph = FontAwesomeFont.Bold.ConvertToString(),
                 FontFamily = FontFamily.FontAwesome,
             };
             
             Children.Add(iconExplorerPage);
             Children.Add(iconButtonPage);
        }
    }
}