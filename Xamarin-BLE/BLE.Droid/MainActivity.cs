using System;
using System.Collections.Generic;
using Android;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AndroidX.Core.App;
using Ho.BLE;
using Ho.Droid;
using Ho.Interfaces;

namespace BLE.Droid
{
    [Activity(Label = "BLE", Theme = "@style/MainTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private const int REQUEST_PERMISSION_CODE = 1001;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            initPermission();
        }
        private void initPermission()
        {
            List<String> mPermissionList = new List<string>();
            if (Build.VERSION.SdkInt >= BuildVersionCodes.S)
            {
                mPermissionList.Add(Manifest.Permission.BluetoothScan);
                mPermissionList.Add(Manifest.Permission.BluetoothAdvertise);
                mPermissionList.Add(Manifest.Permission.BluetoothConnect);
            }
            else
            {
                mPermissionList.Add(Manifest.Permission.AccessCoarseLocation);
                mPermissionList.Add(Manifest.Permission.AccessFineLocation);
            }

            ActivityCompat.RequestPermissions(this, mPermissionList.ToArray(), REQUEST_PERMISSION_CODE);
        }
    }

    public class Droid_BLEServer:IBLEServer
    {
        private BleServer _bleServer;

        public BLEClient.ConnectionStates ConnectionState => _bleServer.ConnectionState;

        public void StartAdvert(string cData)
        {
            _bleServer = new BleServer(Application.Context, cData);
        }
    }
}