using System;
using Xamarin.Forms;

namespace MKit.VectorIcons
{
    public class BaseIconFontImageSource<T> : FontImageSource where T : Enum
    {
        public static readonly BindableProperty NameProperty =
            BindableProperty.Create(nameof(Name), typeof(T), typeof(T), default(T), BindingMode.TwoWay, propertyChanged: OnNamePropertyChanged);

        public T Name
        {
            get => (T)GetValue(NameProperty);

            set => SetValue(NameProperty, value);
        }
        private static void OnNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (BaseIconFontImageSource<T>)bindable;
            control.Glyph = ((T)newValue).ConvertToString();
        }
    }
}