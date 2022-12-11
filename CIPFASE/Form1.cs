using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

//TODO Dodać customowe popupy

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
            FileMenager fl = new FileMenager();
            Data data = fl.readData();
            //bool a = fl.checkFolder();
            InitializeComponent();
            cbNetworkInterfaceBox.Items.Add("Wybierz kartę sieci");
            cbNetworkInterfaceBox.SelectedItem = cbNetworkInterfaceBox.Items[0];

            List<string> cards = NetworkManagement.getCards();
            foreach(string card in cards)
            {
                cbNetworkInterfaceBox.Items.Add(card);
            }

            tbIP.Text = data.IP;
            tbMask.Text = data.Mask;
            tbGate.Text = data.Gateway;
            tbDNS1.Text = data.DNS1;
            tbDNS2.Text = data.DNS2;

            rbDHCP.Checked = data.btDHCP;
            rbIP.Checked = data.btIP;
            rbAuto.Checked = data.btAuto;
            rbSave.Checked = data.btSave;

            rbDHCP.LastChecked = data.btDHCP;
            rbIP.LastChecked = data.btIP;
            rbAuto.LastChecked = data.btAuto;
            rbSave.LastChecked = data.btSave;

            if (rbIP.Checked)
            {
                tbIP.Enabled = false;
                tbMask.Enabled = false;
            }

            if(rbDHCP.Checked)
            {
                rbDHCP.LastChecked = true;
                tbIP.Enabled = false;
                tbMask.Enabled = false;
                tbGate.Enabled = false;
                tbDNS1.Enabled = false;
                tbDNS2.Enabled = false;
            }    

            bool check = true;
            if (data.Cards.Count == cards.Count)
            {
                
                for (int i = 0; i < cards.Count; i++)
                {
                    if (data.Cards[i] != cards[i])
                    {
                        check = false; break;
                    }
                }
            }
            if (check)
            {
                cbNetworkInterfaceBox.SelectedItem = cbNetworkInterfaceBox.Items[data.CardID];
                if(rbSave.Checked)
                    save();
            }
            else
            {
                MessageBox.Show("Wybierz kartę ręcznie", "Nazwy kart nie zgadzają się z plikiem konfiguracyjnym");
                rbSave.Enabled = false;
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

        //TODO dodać walidację danych
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
            save();
        }

        private void btSaveConf_Click(object sender, EventArgs e)
        {
            saveData(true,0);
        }

        private void btResetConf_Click(object sender, EventArgs e)
        {
            FileMenager fl = new FileMenager();
            List<string> cards = new List<string>();

            foreach (var card in cbNetworkInterfaceBox.Items)
            {
                if (card.ToString() != "Wybierz kartę sieci")
                    cards.Add(card.ToString());
            }
            Data data = new Data()
            {
                IP = tbIP.Text = "192.168.0.20",
                Mask = tbMask.Text = "255.255.255.0",
                Gateway = tbGate.Text = "192.168.0.1",
                DNS1 = tbDNS1.Text = "8.8.8.8",
                DNS2 = tbDNS2.Text = "1.1.1.1",
                btDHCP = rbDHCP.LastChecked = rbDHCP.Checked = false,
                btIP = rbIP.LastChecked = rbIP.Checked = false,
                btAuto = rbAuto.LastChecked = rbAuto.Checked = false,
                btSave = rbSave.LastChecked = rbSave.Checked = false,
                Cards = cards,
                CardID = 0
            };

            cbNetworkInterfaceBox.SelectedItem = cbNetworkInterfaceBox.Items[0];
            tbIP.Enabled = true;
            tbMask.Enabled = true;
            tbGate.Enabled = true;
            tbDNS1.Enabled = true;
            tbDNS2.Enabled = true;

            if (!fl.saveData(data))
                MessageBox.Show("Błąd przy resetowaniu danych");
            else
                MessageBox.Show("Dane poprawnie zapisane");


        }
        #endregion

        #region AuxiliaryFunctions
        private void saveData(bool b, int i)
        {
            List<string> cards = new List<string>();
            foreach (var card in cbNetworkInterfaceBox.Items)
            {
                if (card.ToString() != "Wybierz kartę sieci")
                    cards.Add(card.ToString());
            }
            string cut = tbIP.Text.Substring(tbIP.Text.LastIndexOf(".") + 1);
            string edited = tbIP.Text.Substring(0, tbIP.Text.Length-cut.Length) + (int.Parse(cut) + i).ToString();
            Data data = new Data()
            {
                IP = edited,
                Mask = tbMask.Text,
                Gateway = tbGate.Text,
                DNS1 = tbDNS1.Text,
                DNS2 = tbDNS2.Text,
                btDHCP = rbDHCP.Checked,
                btIP = rbIP.Checked,
                btAuto = rbAuto.Checked,
                btSave = rbSave.Checked,
                Cards = cards,
                CardID = cbNetworkInterfaceBox.Items.IndexOf(cbNetworkInterfaceBox.SelectedItem)
            };
            FileMenager fl = new FileMenager();
            if (fl.saveData(data))
                if (b)
                    MessageBox.Show("Dane poprawnie zapisane");
            else
                if (b)
                    MessageBox.Show("Błąd przy zapisie danych");
        }

        private void save()
        {
            string NIC = cbNetworkInterfaceBox.SelectedItem.ToString();
            if (NIC == "Wybierz kartę sieci")
            {
                MessageBox.Show("Wybierz poprawną kartę sieci", "Błąd Karty");
            }
            else if (rbDHCP.Checked)
            {
                NetworkManagement.enableDHCP("");
            }
            else
            {
                int i = (rbAuto.Checked && !rbIP.Checked) ? 1 : 0;
                NetworkManagement.setIP(NIC, tbIP.Text, tbMask.Text);
                NetworkManagement.setGateway(NIC, tbGate.Text);
                NetworkManagement.setDNS(NIC, $"{tbDNS1.Text},{tbDNS2.Text}");
                saveData(true, i);
            }
        }
        #endregion
    }
}
