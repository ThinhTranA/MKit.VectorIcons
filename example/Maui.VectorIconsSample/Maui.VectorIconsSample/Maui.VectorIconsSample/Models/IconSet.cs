using System;

namespace Maui.VectorIconsSample.Models
{
    public class IconSet
    {
        public IconSet(Type font)
        {
            Name = font.ToString().Split('.')[1];
            Count = Enum.GetNames(font).Length;
            Type = font;
        }
        public string Name { get; set; }
        public int Count { get; set; }
        public Type Type { get; set; }
    }
}