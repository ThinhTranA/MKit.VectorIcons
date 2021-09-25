using VectorIcons;
using Xamarin.Forms;

namespace Maui.VectorIcons.FontAwesome
{
    public class IconButton : BaseIconButton<FontAwesomeFont>
    {
        public IconButton()
        {
            IconFontFamily = global::VectorIcons.FontFamily.FontAwesome;
        }
    }
}