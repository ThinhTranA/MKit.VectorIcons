using VectorIcons;
using Xamarin.Forms;

namespace Maui.VectorIcons.MaterialIcons
{
    public class Icon : Label
    {
        public Icon()
        {
            FontFamily = global::VectorIcons.FontFamily.MaterialIcons;
        }
        
        public static readonly BindableProperty NameProperty = 
            BindableProperty.Create(nameof(Name), typeof(MaterialIconsFont), typeof(MaterialIconsFont), default(MaterialIconsFont), BindingMode.TwoWay, propertyChanged: OnNamePropertyChanged);
        public MaterialIconsFont Name
        {
            get => (MaterialIconsFont)GetValue(NameProperty);

            set => SetValue(NameProperty, value);
        }

        private static void OnNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (Icon)bindable;
            control.Text = ((MaterialIconsFont)newValue).ConvertToString();
        }
    }
}