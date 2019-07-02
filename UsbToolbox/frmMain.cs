using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace UsbToolbox
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lvDevices.View = View.Details;
            lvDevices.GridLines = true;
            lvDevices.FullRowSelect = true;

            lvDevices.Columns.Add("Device", 300);
            lvDevices.Columns.Add("PNP Device ID", 300);
            lvDevices.Columns.Add("Description", 300);

            ManagementObjectSearcher deviceSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_USBHub");
            foreach (ManagementObject usbDevice in deviceSearcher.Get())
            {
                ListViewItem newItem = new ListViewItem(usbDevice.Properties["DeviceID"].Value.ToString());                
                newItem.SubItems.Add(usbDevice.Properties["PNPDeviceID"].Value.ToString());
                newItem.SubItems.Add(usbDevice.Properties["Description"].Value.ToString());

                lvDevices.Items.Add(newItem);
            }
        }
    }
}
