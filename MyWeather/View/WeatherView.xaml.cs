using System;
using UnderTheWeather.StyleKits;
using Xamarin.Forms;

namespace UnderTheWeather.View
{
    public partial class WeatherView : ContentPage
    {
        public WeatherView()
        {
            InitializeComponent();

            SetupEvents();

            if (Device.OS == TargetPlatform.iOS)
                Icon = new FileImageSource { File = "tab1.png" };
        }

        private void SetupEvents()
        {
            lblCondition.PropertyChanged += LblCondition_PropertyChanged;
            btnGetWeather.Clicked += BtnGetWeather_Clicked;
        }
        
        private void BtnGetWeather_Clicked(object sender, EventArgs e)
        {
            lblCondition.PropertyChanged += LblCondition_PropertyChanged;
            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy HH: mm:ss");
        }

        private void LblCondition_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            SetupBackgroundImage();
        }

        private void SetupBackgroundImage()
        {
            string con = lblCondition.Text;
            if (con != "")
            {
                int startPos = con.LastIndexOf(": ") + 2;
                string condition = con.Substring(startPos);


                switch (condition)
                {
                    case "broken clouds":
                        imgBackground.Source = ImageStyleKit.imgBrokenClouds;
                        break;
                    case "clear sky":
                        imgBackground.Source = ImageStyleKit.imgClearSky;
                        break;
                    case "clear skies":
                        imgBackground.Source = ImageStyleKit.imgClearSky;
                        break;
                    case "few clouds":
                        imgBackground.Source = ImageStyleKit.imgFewClouds;
                        break;
                    case "haze":
                        imgBackground.Source = ImageStyleKit.imgHaze;
                        break;
                    case "light rain":
                        imgBackground.Source = ImageStyleKit.imgLightRain;
                        break;
                    case "overcast clouds":
                        imgBackground.Source = ImageStyleKit.imgOvercastClouds;
                        break;
                    case "scattered clouds":
                        imgBackground.Source = ImageStyleKit.imgScatteredclouds;
                        break;
                    default:
                        imgBackground.Source = "";
                        break;
                }
            }
        }
    }
}
