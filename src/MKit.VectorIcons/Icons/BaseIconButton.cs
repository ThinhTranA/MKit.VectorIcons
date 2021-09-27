using System;
using Xamarin.Forms;

namespace MKit.VectorIcons
{
    public abstract class BaseIconButton<T> : Button where T : Enum
    {
        public static string IconFontFamily { get; protected set; }
        public static readonly BindableProperty NameProperty =
            BindableProperty.Create(nameof(Name), typeof(T), typeof(T),
                default(T), BindingMode.TwoWay, propertyChanged: OnNamePropertyChanged);

        public T Name
        {
            get => (T)GetValue(NameProperty);

            set => SetValue(NameProperty, value);
        }

        private static void OnNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (BaseIconButton<T>)bindable;
            var fontAwesomeFont = (T)newValue;

            control.ImageSource = new FontImageSource
            {
                Glyph = fontAwesomeFont.ConvertToString(),
                FontFamily = IconFontFamily,
                Size = control.IconSize,
                Color = control.IconColor
            };
        }


        public static readonly BindableProperty IconSizeProperty =
            BindableProperty.Create(nameof(Name), typeof(double), typeof(double),
                16.0, BindingMode.TwoWay, propertyChanged: OnIconSizePropertyChanged);

        public double IconSize
        {
            get => (double)GetValue(IconSizeProperty);

            set => SetValue(IconSizeProperty, value);
        }

        private static void OnIconSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (BaseIconButton<T>)bindable;
            var size = (double)newValue;

            control.ImageSource = new FontImageSource
            {
                Glyph = control.Name.ConvertToString(),
                FontFamily = IconFontFamily,
                Size = size,
                Color = control.IconColor
            };
        }


        public static readonly BindableProperty IconColorProperty =
            BindableProperty.Create(nameof(Name), typeof(Color), typeof(Color),
                default, BindingMode.TwoWay, propertyChanged: OnIconColorPropertyChanged);

        public Color IconColor
        {
            get => (Color)GetValue(IconColorProperty);

            set => SetValue(IconColorProperty, value);
        }

        private static void OnIconColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (BaseIconButton<T>)bindable;
            var color = (Color)newValue;

            control.ImageSource = new FontImageSource
            {
                Glyph = control.Name.ConvertToString(),
                FontFamily = IconFontFamily,
                Size = control.IconSize,
                Color = color
            };
        }


        public static readonly BindableProperty IconPositionProperty =
            BindableProperty.Create(nameof(IconPosition), typeof(Button.ButtonContentLayout.ImagePosition),
                typeof(Button.ButtonContentLayout.ImagePosition),
                default, BindingMode.TwoWay, propertyChanged: OnIconPositionPropertyChanged);

        public ButtonContentLayout.ImagePosition IconPosition
        {
            get => (ButtonContentLayout.ImagePosition)GetValue(IconPositionProperty);

            set => SetValue(IconPositionProperty, value);
        }

        private static void OnIconPositionPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (BaseIconButton<T>)bindable;
            var position = (Button.ButtonContentLayout.ImagePosition)newValue;

            control.ContentLayout = new ButtonContentLayout(position, control.Spacing);
        }


        public static readonly BindableProperty SpacingProperty =
            BindableProperty.Create(nameof(Spacing), typeof(double), typeof(double),
                default, BindingMode.TwoWay, propertyChanged: OnSpacingPropertyChanged);

        public double Spacing
        {
            get => (double)GetValue(SpacingProperty);

            set => SetValue(SpacingProperty, value);
        }

        private static void OnSpacingPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (BaseIconButton<T>)bindable;
            var spacing = (double)newValue;

            control.ContentLayout = new ButtonContentLayout(control.IconPosition, spacing);
        }
    }
}