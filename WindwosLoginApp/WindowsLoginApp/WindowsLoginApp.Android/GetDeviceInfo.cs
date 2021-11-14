using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WindwosLoginApp;
using static Android.Provider.Settings;

[assembly: Xamarin.Forms.Dependency(typeof(WinowsLoginApp.Droid.GetDeviceInfo))]
namespace WinowsLoginApp.Droid
{
    class GetDeviceInfo :IGetDeviceInfo
    {
        public  string GetDeviceID()
        {
            var context = Android.App.Application.Context;
            string id = Android.Provider.Settings.Secure.GetString(context.ContentResolver, Secure.AndroidId);
            return id;
        }
    }
}