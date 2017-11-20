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
    [Activity(Label = "GoalsActivity")]
    public class GoalsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Goals);

            Button myhistory = FindViewById<Button>(Resource.Id.historybutton);
            Button bluetooth = FindViewById<Button>(Resource.Id.blue);
            Button work = FindViewById<Button>(Resource.Id.wbutton);
            EditText mygoal = FindViewById<EditText>(Resource.Id.edit);
            Button submit = FindViewById<Button>(Resource.Id.submit);
            ProgressBar progress = FindViewById<ProgressBar>(Resource.Id.progressBar1);


            myhistory.Click += delegate
            {
                Intent intent = new Intent(this, typeof(HistoryActivity));
                StartActivity(intent);
            };
            bluetooth.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
            work.Click += delegate
            {
                var intent = new Intent(this, typeof(WorkoutActivity));
                StartActivity(intent);
            };



        }
    }
}