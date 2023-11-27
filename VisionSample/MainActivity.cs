using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android;
using AndroidX.Core.App;

namespace VisionSample
{
    [Activity (Label = "VisionSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        static string[] PERMISSIONS = {
            Manifest.Permission.Camera
        };

        Button buttonFaceTracker;
        Button buttonPhotoFace;
        Button buttonBarcode;

        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            SetContentView (Resource.Layout.Main);

            //buttonFaceTracker = FindViewById<Button> (Resource.Id.buttonFaceTracker);
            //buttonPhotoFace = FindViewById<Button> (Resource.Id.buttonPhotoFace);
            buttonBarcode = FindViewById<Button> (Resource.Id.buttonBarcode);

            //buttonFaceTracker.Click += delegate {
            //    StartActivity (typeof(FaceTrackerActivity));    
            //};

            //buttonPhotoFace.Click += delegate {
                
            //};

            buttonBarcode.Click += delegate {
                StartActivity (typeof(BarcodeScannerActivity));
            };

            if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            {
                ActivityCompat.RequestPermissions(this, PERMISSIONS, 0);
            }
        }
    }
}


