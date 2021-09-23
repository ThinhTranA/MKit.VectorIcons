using System;

namespace Maui.VectorIcons
{
    public static class Extensions
    {
        public static string ConvertToString(this Enum enumIcon) => Convert.ToChar(enumIcon).ToString();
    }
}