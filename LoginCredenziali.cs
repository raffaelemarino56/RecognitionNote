﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FaceUnlockVocalNode
{
    [Activity(Label = "Activity1")]
    public class LoginCredenziali : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
           
            SetContentView(Resource.Layout.loginLayout);
            // Create your application here
        }
    }
}