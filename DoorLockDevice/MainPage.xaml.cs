using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Gpio;

using DoorLock_Library.APIConnection;
using DoorLock_Library.Data.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DoorLockDevice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private PublicApiConnectionHelper APIConnection;
        private const int DoorPin = 16;
        private const int AlteraPin = 18;
        private GpioPin pinDoor;
        private GpioPin pinAltera;
        private GpioPinValue pinDoorValue;
        private GpioPinValue pinAlteraValue;

        public MainPage()
        {
            this.InitializeComponent();

            SMSApiHelper.InitializeClient("https://tadhackapi.azurewebsites.net/api/");
            ApiHelper.InitializeClient("https://lod.azurewebsites.net/api/");

            this.APIConnection = new PublicApiConnectionHelper();

            DispatcherTimer dt = new DispatcherTimer();

            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += DT_Tick;

            this.InitGPIO();
        }

        private async void DT_Tick(object sender, object e)
        {

            DoorLock_Model DoorData = await this.APIConnection.GetDoorState();

            if (DoorData != null)
            {
                if (DoorData._DoorState == true)
                {
                    this.StateDisplay_TextBlock.Text = "Door Opened";
                    pinAlteraValue = GpioPinValue.Low;
                    pinDoorValue = GpioPinValue.Low;

                    pinAltera.Write(pinAlteraValue);
                    pinDoor.Write(pinDoorValue);
                }
                else
                {
                    this.StateDisplay_TextBlock.Text = "Door Closed";
                    pinAlteraValue = GpioPinValue.High;
                    pinDoorValue = GpioPinValue.High;

                    pinAltera.Write(pinAlteraValue);
                    pinDoor.Write(pinDoorValue);
                }
            }


        }

        private void InitGPIO()
        {
            var gpio = GpioController.GetDefault();

            // Show an error if there is no GPIO controller
            if (gpio == null)
            {
                pinDoor = null;
                pinAltera = null;
                this.StateDisplay_TextBlock.Text = "There is no GPIO controller on this device.";
                return;
            }

            this.pinDoor = gpio.OpenPin(DoorPin);
            this.pinAltera = gpio.OpenPin(AlteraPin);
            this.pinAlteraValue = GpioPinValue.High;
            this.pinDoorValue = GpioPinValue.High;

            this.pinDoor.Write(pinDoorValue);
            this.pinDoor.SetDriveMode(GpioPinDriveMode.Output);

            this.pinAltera.Write(pinAlteraValue);
            this.pinAltera.SetDriveMode(GpioPinDriveMode.Output);

            this.StateDisplay_TextBlock.Text = "GPIO pin initialized correctly.";

        }

        private async void Request_Button_Click(object sender, RoutedEventArgs e)
        {

            string name = this.RequestName_TextBox.Text.Trim();

            List<SMS_Model> smses = new List<SMS_Model>();
            List<SmsResulats_Model> resualts = new List<SmsResulats_Model>();

            smses.Add(new SMS_Model { _SMS_Messages = $"HI Chiloane SP , {name} has Requested to open the door", _CellPhoneNumbers = "+27791906420" });
            smses.Add(new SMS_Model { _SMS_Messages = $"HI simelane ml , {name} has Requested to open the door", _CellPhoneNumbers = "+27710257988" });
            smses.Add(new SMS_Model { _SMS_Messages = $"HI Mazibuko SG , {name} has Requested to open the door", _CellPhoneNumbers = "+27658771238" });
            smses.Add(new SMS_Model { _SMS_Messages = $"HI rampyapedi jt , {name} has Requested to open the door", _CellPhoneNumbers = "+27722397690" });
            smses.Add(new SMS_Model { _SMS_Messages = $"HI tshehla lg , {name} has Requested to open the door", _CellPhoneNumbers = "+27728414348" });
            smses.Add(new SMS_Model { _SMS_Messages = $"HI mafabatho hm , {name} has Requested to open the door", _CellPhoneNumbers = "+27763812698" });

            foreach (SMS_Model x in smses)
            {


                SmsResulats_Model temp = await this.APIConnection.SendSMSes(x, "lod", "lod", "eb4df9b6c0242437cdec02d5133d7509");

                resualts.Add(temp);
            }

            foreach (var x in resualts)
            {
                if (x._Status == false)
                {
                    Console.WriteLine("Message did not go" + x._MessageID);
                }
            }
        }
    }
}
