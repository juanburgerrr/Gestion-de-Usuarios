using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public static class ThemeColor
    {
        public static List<string> ColorList = new List<string>() {"#FF0000",
"#FF7F00",
"#FFFF00",
"#00FF00",
"#00FFFF",
"#0000FF",
"#8B00FF",
"#FF1493",
"#FF69B4",
"#FFA500",
"#FFD700",
"#ADFF2F",
"#40E0D0",
"#1E90FF",
"#9370DB",
"#DC143C",
"#00FA9A",
"#7FFF00",
"#FF4500",
"#BA55D3",
"#20B2AA",
"#FF6347",
"#4682B4",
"#EE82EE"};


        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }



    }
}