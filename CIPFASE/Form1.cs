using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace KIP_ASE
{
    public partial class Form : System.Windows.Forms.Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form()
        {
            InitializeComponent();
            cbNetworkInterfaceBox.Items.Add("Wybierz kartę sieci");
            cbNetworkInterfaceBox.SelectedItem = cbNetworkInterfaceBox.Items[0];
            List<string> cards = NetworkManagement.getCards();
            foreach(string card in cards)
            {
                cbNetworkInterfaceBox.Items.Add(card);
            }
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txAppName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void rbIP_Click(object sender, EventArgs e)
        {
            if(rbIP.Checked && rbIP.LastChecked)
            {
                rbIP.Checked = false;
                rbIP.LastChecked = false;
            }
            else if (rbIP.Checked)
            {
                rbIP.LastChecked = true;
            }
        }

        private void rbAuto_Click(object sender, EventArgs e)
        {
            if (rbAuto.Checked && rbAuto.LastChecked)
            {
                rbAuto.Checked = false;
                rbAuto.LastChecked = false;
            }
            else if (rbAuto.Checked)
            {
                rbAuto.LastChecked = true;
            }
        }

        private void rbSave_Click(object sender, EventArgs e)
        {
            if (rbSave.Checked && rbSave.LastChecked)
            {
                rbSave.Checked = false;
                rbSave.LastChecked = false;
            }
            else if (rbSave.Checked)
            {
                rbSave.LastChecked = true;
            }
        }

        private void rbDHCP_Click(object sender, EventArgs e)
        {
            if (rbDHCP.Checked && rbDHCP.LastChecked)
            {
                rbDHCP.Checked = false;
                rbDHCP.LastChecked = false;
            }
            else if (rbDHCP.Checked)
            {
                rbDHCP.LastChecked = true;
            }
        }

        private void btScan_Click(object sender, EventArgs e)
        {
            cbNetworkInterfaceBox.Items.Clear();
            cbNetworkInterfaceBox.Items.Add("Wybierz kartę sieci");
            List<string> cards = NetworkManagement.getCards();
            foreach (string card in cards)
            {
                cbNetworkInterfaceBox.Items.Add(card);
            }
        }
    }
}
