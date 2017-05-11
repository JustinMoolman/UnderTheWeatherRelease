using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UnderTheWeather.StyleKits
{
    //https://www.materialpalette.com/blue/light-blue

    public static class ColorStyleKit
    {
        //8 Material Palette Colors
        public static readonly Color PrimaryColor = Color.FromHex("#2196F3");
        public static readonly Color DarkPrimaryColor = Color.FromHex("#1976D2");
        public static readonly Color LightPrimaryColor = Color.FromHex("#BBDEFB");
        public static readonly Color AccentColor = Color.FromHex("#03A9F4");
        public static readonly Color PrimaryTextColor = Color.FromHex("#212121");
        public static readonly Color SecondaryTextColor = Color.FromHex("#757575");
        public static readonly Color IconsColor = Color.FromHex("#FFFFFF");
        public static readonly Color DividerColor = Color.FromHex("#BDBDBD");

        //Gradient Button Colors
        public static Color ProceedButtonStartColor = Color.FromHex("#30db35");//CustomLightGreen
        public static Color ProceedButtonEndColor = Color.FromHex("#007F00");//CustomDarkGreen
        public static Color DefaultButtonStartColor = Color.FromRgb(230, 230, 230);
        public static Color DefaultButtonEndColor = Color.FromRgb(201, 201, 201);

        //Background with alpha
        public static readonly Color BackgroundAlpha = Color.FromHex("#33212121");//1A//BF
    }
}
