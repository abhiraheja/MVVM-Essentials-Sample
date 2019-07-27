using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace MVVM_Essentials_Lib
{
    public class ConvertColor
    {
        public static Color ConvertStringToColor(string hexColor)
        {
            if (hexColor.IndexOf('#') != -1)
            {
                hexColor = hexColor.Replace("#", "");
            }

            if (hexColor.Length == 6)
            {
                hexColor = "FF" + hexColor;
            }
            byte alpha = 0;
            byte red = 0;
            byte green = 0;
            byte blue = 0;
            if (hexColor.Length == 8)
            {
                alpha = byte.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                red = byte.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                green = byte.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);
                blue = byte.Parse(hexColor.Substring(6, 2), NumberStyles.AllowHexSpecifier);
            }
            return Color.FromArgb(alpha, red, green, blue);
        }
    }
}
