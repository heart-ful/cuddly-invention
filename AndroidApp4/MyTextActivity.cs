using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.Res;


namespace AndroidApp4
{
    [Activity(Label = "Mytext")]
    public class MyTextActivity : Activity
    {
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create a new TextView and set it as our view
            TextView tv = new TextView(this);

            // Read the contents of our asset
            string content;
            AssetManager assets = this.Assets;
            using (StreamReader sr = new StreamReader(assets.Open("test.txt")))
            {
                content = sr.ReadToEnd();
            }

            // Set TextView.Text to our asset content
            tv.Text = content;
            SetContentView(tv);
        }
    }
}