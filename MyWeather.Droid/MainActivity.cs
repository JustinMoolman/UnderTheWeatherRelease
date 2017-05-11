using Android.App;
using Android.OS;
using Xamarin.Forms;
using Plugin.Permissions;
using Android.Content.PM;
using Android;
using Xamarin.Forms.Platform.Android;

namespace UnderTheWeather.Droid
{
    [Activity(Label = "@string/app_name",
    Icon = "@mipmap/ic_launcher",
    LaunchMode = LaunchMode.SingleTask,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {

		protected override void OnCreate (Bundle bundle)
		{

            ToolbarResource = UnderTheWeather.Droid.Resource.Layout.toolbar;
            TabLayoutResource = UnderTheWeather.Droid.Resource.Layout.tabs;

            base.OnCreate (bundle);

		    Forms.Init(this, bundle);
		
		    LoadApplication(new UnderTheWeather.App());
		}

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}


