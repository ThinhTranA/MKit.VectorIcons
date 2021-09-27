using System;
using Xamarin.Forms;

namespace MKit.VectorIcons
{
    public class BaseIcon<T> : Label where T : Enum
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
            var control = (BaseIcon<T>)bindable;
            control.Text = ((T)newValue).ConvertToString();
        }
    }
}