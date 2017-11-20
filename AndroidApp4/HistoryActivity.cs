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
    [Activity(Label = "HistoryActivity")]
    public class HistoryActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.History);

            Button home = FindViewById<Button>(Resource.Id.homebutton);
            Button bluetooth = FindViewById<Button>(Resource.Id.wblue);
            Button workout = FindViewById<Button>(Resource.Id.wbutton);
            Button goal = FindViewById<Button>(Resource.Id.gbutton);

            home.Click += delegate
            {
                var intent = new Intent(this, typeof(LandingActivity));
                StartActivity(intent);
            };
            bluetooth.Click += delegate
            {
                var main = new Intent(this, typeof(MainActivity));
                StartActivity(main);
            };
            workout.Click += delegate
            {
                var work = new Intent(this, typeof(WorkoutActivity));
                StartActivity(work);
            };
            goal.Click += delegate
            {
                var goaly = new Intent(this, typeof(GoalsActivity));
                StartActivity(goaly);
            };
        }
    }
}