using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Networking.Proximity;
using NdefLibrary.Ndef;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
using Windows.System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OneCard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IdentifierPage : Page
    {
        public static ProximityDevice _device;
        public static long _subscribedMessageId;
        public IdentifierPage()
        {
            this.InitializeComponent();
            //NFCUtils.NfcNdefRead();

        }

        private async void showMessageDialog()
        {
            if (App.NfcRecivedMaessage == null)
            {
                MessageDialog dialog = new MessageDialog("Customer identification failed!!!");

                await dialog.ShowAsync();
                return;
            }
            else
            {
                MessageDialog dialog = new MessageDialog(String.Format("Customer Identified Succefuly:\r\n Customer username - {0}",App.NfcRecivedMaessage));

                await dialog.ShowAsync();
                App.NfcRecivedMaessage = null;
                return;
            }
            
        }

        private void ShowSplitSettings(object sender, RoutedEventArgs e)
        {
            MySettings.BusinessSettingsSplitView.IsPaneOpen = !MySettings.BusinessSettingsSplitView.IsPaneOpen;
        }

        private async void StartNfcRead_clicked(object sender, RoutedEventArgs e)
        {
            identifyText.Text = "Waiting for a customer...";
            identifyText.UpdateLayout();
            await Task.Delay(TimeSpan.FromSeconds(3));
            if (_device != null) return;
            // Start NDEF subscription
            _device = ProximityDevice.GetDefault();
            _subscribedMessageId = _device.SubscribeForMessage("NDEF", MessageReceivedHandler);
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
                }
            }
        }
    }
}
