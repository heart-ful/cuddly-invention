using System;
using System.Linq;
using Android.App;
using Android.Bluetooth;
using Android.Bluetooth.LE;
using Android.OS;
using Android.Widget;
using Robotics.Mobile.Core.Bluetooth.LE;
using Adapter = Robotics.Mobile.Core.Bluetooth.LE.Adapter;

using Android.Content;

namespace AndroidApp4
{
    [Activity(Label = "Search BLE devices", MainLauncher = false, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button _buttonScanBle;
        private BluetoothManager _manager;
        private BluetoothAdapter _adapter;
        private BluetoothLeScanner _bleScanner;
        private Adapter _bleAdapter;
        private EditText _textboxResults;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Button Home = FindViewById<Button>(Resource.Id.button1);
            Button Goals = FindViewById<Button>(Resource.Id.button2);
            Button History = FindViewById<Button>(Resource.Id.button3);

            SetContentView(Resource.Layout.Main);
            _buttonScanBle = FindViewById<Button>(Resource.Id.ButtonSearchBle);
            _textboxResults = FindViewById<EditText>(Resource.Id.TextBoxResults);
            _buttonScanBle.Click += ButtonScanBleClick;

            var appContext = Application.Context;
            _manager = (BluetoothManager)appContext.GetSystemService(BluetoothService); // ("bluetooth");
            _adapter = _manager.Adapter;

            _bleAdapter = new Adapter();
            _bleAdapter.DeviceDiscovered += _bleAdapter_DeviceDiscovered;
            _bleAdapter.ScanTimeoutElapsed += _bleAdapter_ScanTimeoutElapsed;

            Home.Click += delegate
            {
                var intent = new Intent(this, typeof(LandingActivity));
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

        }

        private void _bleAdapter_ScanTimeoutElapsed(object sender, EventArgs e)
        {
            _bleAdapter.StopScanningForDevices();
            DisplayInformation("Bluetooth scan timeout elapsed, no ble devices were found");
        }

        private void _bleAdapter_DeviceDiscovered(object sender, DeviceDiscoveredEventArgs e)
        {
            var msg = string.Format(@"Device found: {0} and
    {1}", e.Device.Name, e.Device.ID);
            DisplayInformation(msg);
        }

        private void ButtonScanBleClick(object sender, EventArgs e)
        {
            if (!_bleAdapter.IsScanning)
                _bleAdapter.StartScanningForDevices();
        }

        private void DisplayInformation(string line)
        {
            _textboxResults.Text = $"{line}\r\n{_textboxResults.Text}";
            Console.WriteLine(line);
        }
    }
}