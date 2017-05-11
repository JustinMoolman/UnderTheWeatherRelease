using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UnderTheWeather.Controls
{
    //xmlns:controls="clr-namespace:UnderTheWeather.Controls;assembly=UnderTheWeather"
    public class GradientButton : Button
    {
        public GradientButton()
        {
            BorderColor = Color.Black;
            BorderWidth = 1;
        }

        #region Bindings
        public Color StartColor
        {
            get { return (Color)GetValue(StartColorProperty); }
            set { SetValue(StartColorProperty, value); }
        }

        public static readonly BindableProperty StartColorProperty =
            BindableProperty.Create(
                "StartColor"
                , typeof(Color)
                , typeof(Color)
                , Color.Black
                , BindingMode.OneWay);

        public Color EndColor
        {
            get { return (Color)GetValue(EndColorProperty); }
            set { SetValue(EndColorProperty, value); }
        }

        public static readonly BindableProperty EndColorProperty =
            BindableProperty.Create(
                "EndColor"
                , typeof(Color)
                , typeof(Color)
                , Color.Black
                , BindingMode.OneWay);
        //, null
        //, (b, o, n) => ItemsChanged(b, (IEnumerable<T>)o, (IEnumerable<T>)n));
        #endregion

        public int CornerRadius { get; set; } = 10;
        public bool EnableGradients { get; set; } = true;

        public event EventHandler OnTouchDown;
        public event EventHandler OnTouchUp;
        public event EventHandler OnTouchCancel;

        public async void FireOnTouchUp()
        {
            if (OnTouchUp != null)
            {
                //OnTouchUp.Invoke("TouchUp", new System.EventArgs());
                OnTouchUp.Invoke(this, new System.EventArgs());
            }
            await this.ScaleTo(1, 50);
        }

        public async void FireOnTouchCancel()
        {
            if (OnTouchCancel != null)
            {
                OnTouchCancel.Invoke("OnTouchCancel", new System.EventArgs());
            }
            await this.ScaleTo(1, 50);
        }

        public async void FireOnTouchDown()
        {
            if (OnTouchDown != null)
            {
                OnTouchDown.Invoke("TouchDown", new System.EventArgs());
            }
            await this.ScaleTo(0.95, 50);
        }

    }
}