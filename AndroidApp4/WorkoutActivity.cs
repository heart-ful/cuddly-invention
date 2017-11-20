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
    [Activity(Label = "WorkoutActivity")]
    public class WorkoutActivity : Activity
    {
        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            string toast = string.Format("You chose: {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Workout);
            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinning);
            Button Scan = FindViewById<Button>(Resource.Id.button1);
            Button Goals = FindViewById<Button>(Resource.Id.button2);
            Button History = FindViewById<Button>(Resource.Id.button3);

            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                this, Resource.Array.planets_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;

            //private void spinner_ItemSelected (object sender, AdapterView.ItemSelectedEventArgs e)
            //{
              //  Spinner spinner = (Spinner)sender;
                //string toast = string.Format("The planet is {0}", spinner.GetItemAtPosition(e.Position));
                //Toast.MakeText(this, toast, ToastLength.Long).Show();
           // }


            Scan.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
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