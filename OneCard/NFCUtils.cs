using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Devices.Enumeration;
using Windows.Devices.SmartCards;
using Windows.Foundation.Metadata;
using Windows.Networking.Proximity;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using NdefLibrary.Ndef;

namespace OneCard
{
    class NFCUtils
    {
        // NFC
        public static ProximityDevice _device;
        public static long _subscribedMessageId;
        //private static long _publishedMessageId = -1;

        /*// Smart Card
        private SmartCardReader _smartCardReader;*/

        /*// UI
        private readonly CoreDispatcher _dispatcher;
        */

        /*public MainPage()
        {
            this.InitializeComponent();
            _dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;
        }*/

        #region NDEF
        public static void NfcNdefRead()
        {
            if (_device != null) return;
            // Start NDEF subscription
            _device = ProximityDevice.GetDefault();
            _subscribedMessageId = _device.SubscribeForMessage("NDEF", MessageReceivedHandler);
            //SetStatusOutput("Subscribed for NDEF / NFC");
        }

        public static void MessageReceivedHandler(ProximityDevice sender, ProximityMessage message)
        {
            //SetStatusOutput("Found proximity card");
            // Convert to NdefMessage from NDEF / NFC Library
            var msgArray = message.Data.ToArray();
            NdefMessage ndefMessage = NdefMessage.FromByteArray(msgArray);
            // Loop over all records contained in the message
            foreach (NdefRecord record in ndefMessage)
            {

                // Check the type of each record 
                if (record.CheckSpecializedType(false) == typeof(NdefTextRecord))
                {
                    // Convert and extract Text info
                    var textRecord = new NdefTextRecord(record);
                    App.NfcRecivedMaessage = textRecord.ToString();
                    //SetStatusOutput("NDEF Text: " + textRecord.Text);
                }
            }
        }
        #endregion

        /*#region Smart Card
        private void SmartCardButton_Click(object sender, RoutedEventArgs e)
        {
            _dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () => await InitSmartCardAsync());
        }

        private async Task InitSmartCardAsync()
        {
            // Check if the SmartCardConnection API exists on this currently running SKU of Windows
            if (!ApiInformation.IsTypePresent("Windows.Devices.SmartCards.SmartCardConnection"))
            {
                // This SKU of Windows does not support Smart Card Connections
                SetStatusOutput("This SKU of Windows does not support Smart Card connections");
                return;
            }

            // Initialize smart card reader
            var devSelector = SmartCardReader.GetDeviceSelector(SmartCardReaderKind.Nfc);
            var devices = await DeviceInformation.FindAllAsync(devSelector);

            if (devices != null && devices.Count == 0)
            {
                SetStatusOutput("No NFC Smart Card Reader found in this device.");
                return;
            }

            // Subscribe to Smart Cards
            _smartCardReader = await SmartCardReader.FromIdAsync(devices.FirstOrDefault().Id);
            _smartCardReader.CardAdded += SmartCardReaderOnCardAdded;
            SetStatusOutput("Subscribed for NFC Smart Cards");
        }

        private async void SmartCardReaderOnCardAdded(SmartCardReader sender, CardAddedEventArgs args)
        {
            SetStatusOutput("Found smart card");

            // Get Answer to Reset (ATR) according to ISO 7816
            // ATR = info about smart card's characteristics, behaviors, and state
            // https://en.wikipedia.org/wiki/Answer_to_reset
            var info = await args.SmartCard.GetAnswerToResetAsync();
            var infoArray = info.ToArray();
            SetStatusOutput("Answer to Reset: " + BitConverter.ToString(infoArray));

            // Connect to the card
            // var connection = await args.SmartCard.ConnectAsync();
            // ...
        }

        #endregion*/

        /*#region NDEF_WRITE

        private void NdefWriteButton_click(object sender, RoutedEventArgs e)
        {
            if (_device != null) return;
            //get the String message and set it to correct format
            string str = "Some String"; //to be replaced
            // Start NDEF subscription
            _device = ProximityDevice.GetDefault();
            if (_publishedMessageId != -1) return;
            _publishedMessageId = _device.PublishMessage("NDEF", str);
            SetStatusOutput("Published NDEF / NFC");
        }

        #endregion*/

        /*#region UI

        private void SetStatusOutput(string newStatus)
        {
            // Update the status output UI element in the UI thread
            // (some of the callbacks are in a different thread that wouldn't be allowed
            // to modify the UI thread)
            _dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => { if (StatusOutput != null) StatusOutput.Text += "\n" + newStatus; });
        }

        #endregion*/
    }
}
