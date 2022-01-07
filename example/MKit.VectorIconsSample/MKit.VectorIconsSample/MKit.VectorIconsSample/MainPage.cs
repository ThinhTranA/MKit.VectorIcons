using MKit.VectorIcons;
using MKit.VectorIcons.FontAwesome;
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
             iconExplorerPage.IconImageSource = new VectorIcons.FontAwesome.IconFontImageSource
             {
                 Name = FontAwesomeFont.Search
             };

             var iconButtonPage = new NavigationPage(new IconButtonPage());
             iconButtonPage.Title = "Icon Button";
             iconButtonPage.IconImageSource = new VectorIcons.FontAwesome.IconFontImageSource
             {
                 Name = FontAwesomeFont.Bold
             };

             var iconImageSourcePage = new NavigationPage(new IconFontImageSourcePage());
             iconImageSourcePage.Title = "Image Source";
             iconImageSourcePage.IconImageSource = new VectorIcons.FontAwesome.IconFontImageSource
             {
                 Name = FontAwesomeFont.Photo
             };

             Children.Add(iconExplorerPage);
             Children.Add(iconButtonPage);
             Children.Add(iconImageSourcePage);
        }
    }
}