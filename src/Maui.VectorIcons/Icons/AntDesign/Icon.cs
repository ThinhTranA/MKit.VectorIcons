using VectorIcons;
using Xamarin.Forms;

namespace Maui.VectorIcons.AntDesign
{
    public class Icon : Label
    {
        public Icon()
        {
            FontFamily = global::VectorIcons.FontFamily.AntDesign;
        }
        
        public static readonly BindableProperty NameProperty = 
            BindableProperty.Create(nameof(Name), typeof(AntDesignFont), typeof(AntDesignFont), default(AntDesignFont), BindingMode.TwoWay, propertyChanged: OnNamePropertyChanged);
        public AntDesignFont Name
        {
            get => (AntDesignFont)GetValue(NameProperty);

            set => SetValue(NameProperty, value);
        }

        private static void OnNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (Icon)bindable;
            var antDesignFont = (AntDesignFont)newValue;
            control.Text = antDesignFont.ConvertToString();
        }
    }
}