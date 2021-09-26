
using System.Collections.Generic;
using Maui.VectorIconsSample.Fonts;
using Maui.VectorIconsSample.Models;
using MvvmHelpers;
using VectorIcons;
using Xamarin.Forms;

namespace Maui.VectorIconsSample
{
    public class MainPageViewModel : BaseViewModel
    {
        public List<IconSet> IconSets { get; set; }
        public Command<IconSet> ViewFontIconsCommand { get; set; }
        public INavigation Navigation => Application.Current.MainPage.Navigation;
        public MainPageViewModel()
        {
            IconSets = new List<IconSet>
            {
                new IconSet(typeof(AntDesignFont)),
                new IconSet(typeof(EntypoFont)),
                new IconSet(typeof(EvilIconsFont)),
                new IconSet(typeof(FeatherFont)),
                new IconSet(typeof(FontAwesomeFont)),
                new IconSet(typeof(FontAwesome5FreeFont)),
                new IconSet(typeof(FontistoFont)),
                new IconSet(typeof(FoundationFont)),
                new IconSet(typeof(IoniconsFont)),
                new IconSet(typeof(MaterialIconsFont)),
                new IconSet(typeof(OcticonsFont)),
                new IconSet(typeof(SimpleLineIconsFont)),
                new IconSet(typeof(ZocialFont)),
            };

            ViewFontIconsCommand = new Command<IconSet>(execute: (iconSet) =>
            {
                switch (iconSet.Name)
                {
                    case nameof(AntDesignFont):
                        Navigation.PushAsync(new AntDesignPage(iconSet));
                        break;
                    case nameof(EntypoFont):
                        Navigation.PushAsync(new EntypoPage(iconSet));
                        break;
                    case nameof(EvilIconsFont):
                        Navigation.PushAsync(new EvilIconsPage(iconSet));
                        break;
                    case nameof(FeatherFont):
                        Navigation.PushAsync(new FeatherPage(iconSet));
                        break;
                    case nameof(FontAwesomeFont):
                        Navigation.PushAsync(new Fonts.FontAwesomePage(iconSet));
                        break;
                    case nameof(FontAwesome5FreeFont):
                        Navigation.PushAsync(new FontAwesome5Page(iconSet));
                        break;
                    case nameof(FontistoFont):
                        Navigation.PushAsync(new FontistoPage(iconSet));
                        break;
                    case nameof(FoundationFont):
                        Navigation.PushAsync(new FoundationPage(iconSet));
                        break;
                    case nameof(IoniconsFont):
                        Navigation.PushAsync(new IoniconsPage(iconSet));
                        break;
                    case nameof(MaterialIconsFont):
                        Navigation.PushAsync(new MaterialIconsPage(iconSet));
                        break;
                    case nameof(OcticonsFont):
                        Navigation.PushAsync(new OcticonsPage(iconSet));
                        break;
                    case nameof(SimpleLineIconsFont):
                        Navigation.PushAsync(new SimpleLineIconsPage(iconSet));
                        break;
                    case nameof(ZocialFont):
                        Navigation.PushAsync(new ZocialPage(iconSet));
                        break;
                    
                    default:
                        Navigation.PushAsync(new AntDesignPage(iconSet));
                        break;
                }
            });
        }

    }
}