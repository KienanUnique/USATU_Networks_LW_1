﻿using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace USATU_Networks_LW_1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetNetworkInformationToTextBoxes();
        }

        private void SetNetworkInformationToTextBoxes()
        {
            var networkStatus = NetworkTools.GetFirstActiveInterfaceStatus();
            textBoxBroadcastAddress.Text = networkStatus.BroadcastAddress;
            textBoxNetworkAddress.Text = networkStatus.NetworkAddress;
            textBoxAddressMAC.Text = networkStatus.MAC;
            textBoxSubnetMask.Text = networkStatus.NetworkMask;
        }

        private void buttonClearPingRequests_MouseClick(object sender, MouseEventArgs e)
        {
            if (!buttonClearPingRequests.Enabled) return;
            dataGridPingRequests.DataSource = null;
        }

        private void buttonScanRangeIP_MouseClick(object sender, MouseEventArgs e)
        {
            if (!buttonScanRangeIP.Enabled || !NetworkTools.IsCorrectIP(textBoxFromAddress.Text) ||
                !NetworkTools.IsCorrectIP(textBoxToAddress.Text)) return;

            buttonScanRangeIP.MouseClick -= buttonScanRangeIP_MouseClick;
            buttonClearPingRequests.MouseClick -= buttonClearPingRequests_MouseClick;
            panelAddressUserActions.Enabled = false;

            dataGridPingRequests.DataSource =
                NetworkTools.GetScannedRangeOfIP(textBoxFromAddress.Text, textBoxToAddress.Text).ToArray();

            Application.DoEvents();
            buttonScanRangeIP.MouseClick += buttonScanRangeIP_MouseClick;
            buttonClearPingRequests.MouseClick += buttonClearPingRequests_MouseClick;
            panelAddressUserActions.Enabled = true;
        }
    }
}