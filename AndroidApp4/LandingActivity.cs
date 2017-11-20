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

namespace AndroidApp4
{
    [Activity(Label = "LandingActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class LandingActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Landing);
            Button Scan = FindViewById<Button>(Resource.Id.button1);
            Button Workout = FindViewById<Button>(Resource.Id.button2);
            Button Goals = FindViewById<Button>(Resource.Id.button3);
            Button History = FindViewById<Button>(Resource.Id.button4);

            Scan.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
            Workout.Click += delegate
            {
                var intent = new Intent(this, typeof(WorkoutActivity));
                StartActivity(intent);
            };
            Goals.Click += delegate
            {
                var intent = new Intent(this, typeof(GoalsActivity));
                StartActivity(intent);
            };
            History.Click += delegate
            {
                var intent = new Intent(this, typeof(HistoryActivity));
                StartActivity(intent);
            };


            // Create your application here
        }
    }
}