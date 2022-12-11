using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace KIP_ASE
{
    public partial class Form : System.Windows.Forms.Form
    {
        #region Initialization

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
        #endregion

        #region MovingForm
        private void topBar_MouseMove(object sender, MouseEventArgs e)
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

        private void lbAuthor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void botomBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region CheckBox
        private void rbIP_Click(object sender, EventArgs e)
        {
            if(rbIP.Checked && rbIP.LastChecked)
            {
                rbIP.Checked = false;
                rbIP.LastChecked = false;
                if(!rbDHCP.Checked)
                {
                    tbIP.Enabled = true;
                    tbMask.Enabled = true;
                }
                
            }
            else if (rbIP.Checked)
            {
                rbIP.LastChecked = true;
                tbIP.Enabled = false;
                tbIP.Text = "192.168.0.20";
                tbMask.Enabled = false;
                tbMask.Text = "255.255.255.0";
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
                if (!rbIP.Checked)
                {
                    tbIP.Enabled = true;
                    tbMask.Enabled = true;
                }
                tbGate.Enabled = true;
                tbDNS1.Enabled = true;
                tbDNS2.Enabled = true;
            }
            else if (rbDHCP.Checked)
            {
                rbDHCP.LastChecked = true;
                tbIP.Enabled = false;
                tbMask.Enabled = false;
                tbGate.Enabled = false;
                tbDNS1.Enabled = false;
                tbDNS2.Enabled = false;
            }
        }
        #endregion

        #region Buttons

        private void btExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

        private void btSave_Click(object sender, EventArgs e)
        {
            string NIC = cbNetworkInterfaceBox.SelectedItem.ToString();
            if (NIC == "Wybierz kartę sieci")
            {
                MessageBox.Show("Wybierz poprawną kartę sieci", "Błąd Karty");
            }
            else if(rbDHCP.Checked)
            {
                NetworkManagement.enableDHCP("");
            }
            else
            {
                NetworkManagement.setIP(NIC, tbIP.Text, tbMask.Text);
                NetworkManagement.setGateway(NIC, tbGate.Text);
                NetworkManagement.setDNS(NIC, $"{tbDNS1.Text},{tbDNS2.Text}");
            }
        }
        #endregion

    }
}
