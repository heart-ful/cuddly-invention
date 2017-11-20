using System;
using System.IO;
using Android.App;
using Android.Bluetooth;
using Android.Bluetooth.LE;
using Android.OS;
using Android.Widget;
using Robotics.Mobile.Core.Bluetooth.LE;
using Adapter = Robotics.Mobile.Core.Bluetooth.LE.Adapter;
using Java.Util;
using Android.Content;

namespace AndroidApp4
{
    [Activity(Label = "Search BLE devices", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button imagebutton = FindViewById<Button>(Resource.Id.ImageButton);
            ImageView imageView = FindViewById<ImageView>(Resource.Id.demoImageView);
            Button filebutton = FindViewById<Button>(Resource.Id.textbutton);

            imagebutton.Click += delegate
            {
                imageView.SetImageResource(Resource.Drawable.map);
            };

            filebutton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MyTextActivity));
                StartActivity(intent);
            };



        }
    }
}