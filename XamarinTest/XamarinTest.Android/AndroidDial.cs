using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Android;
using Android.Content;
using Android.Net;
using Android.Support.V4.App;
using Android.Telephony;
using XamarinTest.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidDial))]
namespace XamarinTest.Droid
{
    public class AndroidDial : IDial
    {
        public async Task<bool> DialAsync(string number)
        {
            var context = Android.App.Application.Context;

            if (context != null)
            {
                var intent = new Intent(Intent.ActionCall);
                intent.AddFlags(ActivityFlags.NewTask);

                ActivityCompat.RequestPermissions(MainActivity.Instatnce, new string[]
                    { Manifest.Permission.CallPhone, Manifest.Permission.CallPrivileged}, 1);

                intent.SetData(Uri.Parse("tel:" + number));
                if (IsIntentAvailable(context, intent))
                {
                    context.StartActivity(intent);
                    return await Task.FromResult(true);
                }
            }

            return await Task.FromResult(false);
        }

        private bool IsIntentAvailable(Context context, Intent intent)
        {
            var pacageManage = context.PackageManager;

            var list = pacageManage.QueryIntentServices(intent, 0).Union(pacageManage.QueryIntentActivities(intent, 0));

            if (list.Any())
                return true;

            var mgr = TelephonyManager.FromContext(context);
            return mgr.PhoneType != PhoneType.None;
        }
    }
}