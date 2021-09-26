using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Maui.VectorIconsSample.Models;
using MvvmHelpers;
using PropertyChanged;

namespace Maui.VectorIconsSample
{
    [AddINotifyPropertyChangedInterface]
    public class BaseFontViewModel<T> : BaseViewModel where T : Enum
    {
        public ObservableCollection<Icon> Icons { get; set; }
        public IconSet IconSet { get; set; }
        public BaseFontViewModel(IconSet iconSet)
        {
            IconSet = iconSet;
            Title = iconSet.Name;

            Icons = LoadIconList<T>();
        }
        
        protected ObservableCollection<Icon> LoadIconList<T>()
        {
            var icons = new ObservableCollection<Icon>();
            var iconValues = Enum.GetValues(typeof(T));
            foreach (var iconValue in iconValues)
            {
                icons.Add(new Icon{Name =(Enum) iconValue, IconName = iconValue.ToString()});
            }

            return icons;
        }

        public void FilterIconList(string searchTerm)
        {
            searchTerm = searchTerm.ToLowerInvariant();

            var allValues = LoadIconList<T>();
            var filteredValues = allValues.Where(value => value.IconName.ToLowerInvariant().Contains(searchTerm)).ToList();

            Icons = new ObservableCollection<Icon>(filteredValues);
        }
    }
}