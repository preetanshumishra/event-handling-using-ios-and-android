﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace listviewevents.Droid
{
    [Activity(Label = "listviewevents", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
}