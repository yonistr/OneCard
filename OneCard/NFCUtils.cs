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
    public class NfcUtils
    {
        private ProximityDevice _device;
        private long _subscriptionIdNdef;
        private long _publishingMessageId;
        private Byte[] _DeviceId;
        private Byte[] _SelfID;
        private String _Content;

        public NfcUtils()
        {
            this._device = ProximityDevice.GetDefault();
            this._subscriptionIdNdef = 0;
            this._publishingMessageId = 0;
            this._DeviceId = new Byte[7];
            this._SelfID = new Byte[7]; //check how to get it 
            this._Content = "";
            Array.Clear(_DeviceId, 0, 7);
        }

        private void _ActivateNfc() //should it be public?
        {
            if (_device != null)
            {
                _device.DeviceArrived += _NfcDeviceArrived;
                _device.DeviceDeparted += _NfcDeviceDeparted;
            }
        }

        private void _NfcDeviceArrived(ProximityDevice sender)
        {
            //device arrived handler
        }

        private void _NfcDeviceDeparted(ProximityDevice sender)
        {
            //device departed handler
            Array.Clear(_DeviceId, 0, 7);
        }

        private void _ReadTagContent()
        {
            if (_subscriptionIdNdef != 0) return;
            _subscriptionIdNdef = _device.SubscribeForMessage("NDEF", MessageReceivedHandler);

        }

        private async void MessageReceivedHandler(ProximityDevice sender, ProximityMessage message)
        {
            _Content = message.Data.ToString();
        }

        public String GetDeviceId()
        {
            return _DeviceId.ToString();
        }

        public String GetSelfID()
        {
            return _SelfID.ToString();
        }

        public String ReadNfcData()
        {
            return _Content;
        }

        public void WriteToTag(String message)
        {
            PublishRecord(message, true);
        }

        public void WriteToDevice(String message)
        {
            PublishRecord(message, false);
        }

        private void PublishRecord(String message, bool writeToTag)
        {
            if (_device == null) return;
            var record = new NdefTextRecord { Text = message };
            // Make sure we're not already publishing another message
            StopPublishingMessage(false);
            // Wrap the NDEF record into an NDEF message
            var NdefMessage = new NdefMessage { record };
            // Convert the NDEF message to a byte array
            var msgArray = NdefMessage.ToByteArray();
            try
            {
                // Publish the NDEF message to a tag or to another device, depending on the writeToTag parameter
                // Save the publication ID so that we can cancel publication later
                _publishingMessageId = _device.PublishBinaryMessage((writeToTag ? "NDEF:WriteTag" : "NDEF"), msgArray.AsBuffer(), MessageWrittenHandler);

            }
            catch (Exception e)
            {

            }
        }
        private void StopPublishingMessage(bool writeToStatusOutput)
        {
            if (_publishingMessageId != 0 && _device != null)
            {
                // Stop publishing the message
                _device.StopPublishingMessage(_publishingMessageId);
                _publishingMessageId = 0;
            }
        }
    }
}
