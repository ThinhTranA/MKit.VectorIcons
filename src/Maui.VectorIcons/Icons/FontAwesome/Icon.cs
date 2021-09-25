using VectorIcons;
using Xamarin.Forms;

namespace Maui.VectorIcons.FontAwesome
{
    public class Icon : BaseIcon<FontAwesomeFont>
    {
        public Icon()
        {
            FontFamily = global::VectorIcons.FontFamily.FontAwesome;
        }
    }
}