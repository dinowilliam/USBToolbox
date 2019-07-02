using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbToolbox.Domain
{
    public class USBDevice
    {
        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string InstanceID { get; private set; }
        public string DeviceName { get; private set; }
        public string Description { get; private set; }
        public string DeviceType { get; private set; }
        public bool IsConnected { get; private set; }
        public bool IsSafeToUnplug { get; private set; }
        public bool Enabled { get; private set; }
        public bool USBHub { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastActivityDate { get; private set; }
        public string SerialNumber { get; private set; }
        public string VendorID { get; private set; }
        public string ProductID { get; private set; }
        public string FirmwareRevision { get; private set; }
        public string USBClass { get; private set; }
        public string USBProtocol { get; private set; }
        public string DriverProtocol { get; private set; }
        public string DriverInfSection { get; private set; }
        public string DriverInfPath { get; private set; }

        public USBDevice(string deviceID, string pnpDeviceID, string description)
        {
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
        }

        
    }

}
