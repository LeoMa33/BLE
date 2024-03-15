using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ho.BLE;
using Ho.Interfaces;
using Xamarin.Forms;

namespace BLE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            /* --- Use to start BLE Server and get ready to send data <dataToSend>
            IBLEServer bleServer = DependencyService.Get<IBLEServer>();
            string dataToSend = "I'm a data";
            bleServer.StartAdvert(dataToSend);
            
            --- Use to start BLE Client and receive data of the first BLE Server found (print receive data)
            BLEClient.BLEConnection();*/
        }
        
    }
}