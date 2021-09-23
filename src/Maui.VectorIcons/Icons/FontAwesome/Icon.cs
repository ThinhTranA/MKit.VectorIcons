using VectorIcons;
using Xamarin.Forms;

namespace Maui.VectorIcons.FontAwesome
{
    public class Icon : Label
    {
        public Icon()
        {
            FontFamily = global::VectorIcons.FontFamily.FontAwesome;
        }
        
        public static readonly BindableProperty NameProperty = 
            BindableProperty.Create(nameof(Name), typeof(FontAwesomeFont), typeof(FontAwesomeFont), default(FontAwesomeFont), BindingMode.TwoWay, propertyChanged: OnNamePropertyChanged);
        public FontAwesomeFont Name
        {
            get => (FontAwesomeFont)GetValue(NameProperty);

            set => SetValue(NameProperty, value);
        }

        private static void OnNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (Icon)bindable;
            var fontAwesomeFont = (FontAwesomeFont)newValue;
            control.Text = fontAwesomeFont.ConvertToString();
        }
    }
}