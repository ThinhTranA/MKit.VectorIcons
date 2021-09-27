using System;
using PropertyChanged;

namespace MKit.VectorIconsSample.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Icon
    {
        public Enum Name { get; set; }
        public string IconName { get; set; }
    }
}