using UnderTheWeather.StyleKits;
using UnderTheWeather.View;
using UnderTheWeather.ViewModels;
using Xamarin.Forms;
using static System.Diagnostics.Debug;

namespace UnderTheWeather
{
    public class App : Application
    {
        /// <summary>
        /// 
        /// Justin Moolman
        /// 
        /// I focussed on the Android project as I do not have a Mac to test on at home.
        /// The iOS project should still build, but it won't have all the features.
        /// 
        /// References:
        /// http://www.color-hex.com
        /// https://github.com
        /// http://stackoverflow.com
        /// http://csharp.net-informations.com
        /// https://www.materialpalette.com/blue/light-blue
        /// http://www.goxuni.com/672160-how-to-create-a-simple-xamarin-forms-weather-application-using-xuni
        /// https://github.com/jamesmontemagno
        /// Previous projects at VisionThing
        /// 
        /// </summary>
        public App()
        {
            NavigationPage wv = new NavigationPage
            {
                BarBackgroundColor = ColorStyleKit.DarkPrimaryColor,
                BarTextColor = Color.White
            };
            var tabs = new TabbedPage
            {
                Title ="Under The Weather",
                BindingContext = new WeatherViewModel(),
                Children =
                {
                    new WeatherView(),
                    new ForecastView()
                }
            };
            
            MainPage = new NavigationPage(tabs)
            {
                BarBackgroundColor = ColorStyleKit.PrimaryColor,
                BarTextColor = Color.White
            };
        }

        protected override void OnStart()
        {
            base.OnStart();
            WriteLine("Application OnStart");
        }

        protected override void OnSleep()
        {
            base.OnSleep();
            WriteLine("Application OnSleep");
        }

        protected override void OnResume()
        {
            base.OnResume();
            WriteLine("Application OnResume");
        }
    }
}

