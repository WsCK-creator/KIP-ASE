namespace KIP_ASE
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.topBar = new System.Windows.Forms.Panel();
            this.lbAppName = new System.Windows.Forms.Label();
            this.grNetworkAdapter = new System.Windows.Forms.GroupBox();
            this.btScan = new System.Windows.Forms.Button();
            this.picInternetCard = new System.Windows.Forms.PictureBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbMask = new System.Windows.Forms.Label();
            this.lbGate = new System.Windows.Forms.Label();
            this.lbDNS1 = new System.Windows.Forms.Label();
            this.lbDNS2 = new System.Windows.Forms.Label();
            this.grNetworkSetings = new System.Windows.Forms.GroupBox();
            this.grSetings = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grActions = new System.Windows.Forms.GroupBox();
            this.btResetConf = new System.Windows.Forms.Button();
            this.btSaveConf = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.botomBar = new System.Windows.Forms.Panel();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.rbSave = new CustomRadioButton();
            this.rbAuto = new CustomRadioButton();
            this.rbIP = new CustomRadioButton();
            this.rbDHCP = new CustomRadioButton();
            this.tbDNS1 = new CustomTextBox();
            this.tbDNS2 = new CustomTextBox();
            this.tbGate = new CustomTextBox();
            this.tbMask = new CustomTextBox();
            this.tbIP = new CustomTextBox();
            this.cbNetworkInterfaceBox = new CustomFlatComboBox();
            this.topBar.SuspendLayout();
            this.grNetworkAdapter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInternetCard)).BeginInit();
            this.grNetworkSetings.SuspendLayout();
            this.grSetings.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grActions.SuspendLayout();
            this.botomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.topBar.Controls.Add(this.lbAppName);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(630, 30);
            this.topBar.TabIndex = 0;
            this.topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseMove);
            // 
            // lbAppName
            // 
            this.lbAppName.AutoSize = true;
            this.lbAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.lbAppName.Location = new System.Drawing.Point(265, 4);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(89, 24);
            this.lbAppName.TabIndex = 0;
            this.lbAppName.Text = "KIP-ASE";
            this.lbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAppName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txAppName_MouseMove);
            // 
            // grNetworkAdapter
            // 
            this.grNetworkAdapter.Controls.Add(this.cbNetworkInterfaceBox);
            this.grNetworkAdapter.Controls.Add(this.btScan);
            this.grNetworkAdapter.Controls.Add(this.picInternetCard);
            this.grNetworkAdapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grNetworkAdapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.grNetworkAdapter.Location = new System.Drawing.Point(12, 36);
            this.grNetworkAdapter.Name = "grNetworkAdapter";
            this.grNetworkAdapter.Size = new System.Drawing.Size(606, 70);
            this.grNetworkAdapter.TabIndex = 1;
            this.grNetworkAdapter.TabStop = false;
            this.grNetworkAdapter.Text = "Karta Internetowa";
            // 
            // btScan
            // 
            this.btScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btScan.Location = new System.Drawing.Point(518, 28);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(76, 26);
            this.btScan.TabIndex = 2;
            this.btScan.Text = "Odśwież";
            this.btScan.UseVisualStyleBackColor = true;
            this.btScan.Click += new System.EventHandler(this.btScan_Click);
            // 
            // picInternetCard
            // 
            this.picInternetCard.Image = ((System.Drawing.Image)(resources.GetObject("picInternetCard.Image")));
            this.picInternetCard.Location = new System.Drawing.Point(12, 21);
            this.picInternetCard.Name = "picInternetCard";
            this.picInternetCard.Size = new System.Drawing.Size(36, 36);
            this.picInternetCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInternetCard.TabIndex = 0;
            this.picInternetCard.TabStop = false;
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(9, 24);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(74, 16);
            this.lbIP.TabIndex = 0;
            this.lbIP.Text = "Adres IP :";
            // 
            // lbMask
            // 
            this.lbMask.AutoSize = true;
            this.lbMask.Location = new System.Drawing.Point(9, 52);
            this.lbMask.Name = "lbMask";
            this.lbMask.Size = new System.Drawing.Size(126, 16);
            this.lbMask.TabIndex = 1;
            this.lbMask.Text = "Maska Podsieci :";
            // 
            // lbGate
            // 
            this.lbGate.AutoSize = true;
            this.lbGate.Location = new System.Drawing.Point(9, 80);
            this.lbGate.Name = "lbGate";
            this.lbGate.Size = new System.Drawing.Size(140, 16);
            this.lbGate.TabIndex = 2;
            this.lbGate.Text = "Domyślna bramka :";
            // 
            // lbDNS1
            // 
            this.lbDNS1.AutoSize = true;
            this.lbDNS1.Location = new System.Drawing.Point(9, 108);
            this.lbDNS1.Name = "lbDNS1";
            this.lbDNS1.Size = new System.Drawing.Size(137, 16);
            this.lbDNS1.TabIndex = 3;
            this.lbDNS1.Text = "Preferowany DNS :";
            // 
            // lbDNS2
            // 
            this.lbDNS2.AutoSize = true;
            this.lbDNS2.Location = new System.Drawing.Point(9, 136);
            this.lbDNS2.Name = "lbDNS2";
            this.lbDNS2.Size = new System.Drawing.Size(138, 16);
            this.lbDNS2.TabIndex = 4;
            this.lbDNS2.Text = "Alternatywny DNS :";
            // 
            // grNetworkSetings
            // 
            this.grNetworkSetings.Controls.Add(this.tbDNS1);
            this.grNetworkSetings.Controls.Add(this.tbDNS2);
            this.grNetworkSetings.Controls.Add(this.tbGate);
            this.grNetworkSetings.Controls.Add(this.tbMask);
            this.grNetworkSetings.Controls.Add(this.tbIP);
            this.grNetworkSetings.Controls.Add(this.lbDNS2);
            this.grNetworkSetings.Controls.Add(this.lbDNS1);
            this.grNetworkSetings.Controls.Add(this.lbGate);
            this.grNetworkSetings.Controls.Add(this.lbMask);
            this.grNetworkSetings.Controls.Add(this.lbIP);
            this.grNetworkSetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grNetworkSetings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.grNetworkSetings.Location = new System.Drawing.Point(12, 112);
            this.grNetworkSetings.Name = "grNetworkSetings";
            this.grNetworkSetings.Size = new System.Drawing.Size(274, 175);
            this.grNetworkSetings.TabIndex = 2;
            this.grNetworkSetings.TabStop = false;
            this.grNetworkSetings.Text = "Ustawienia Karty Sieci";
            // 
            // grSetings
            // 
            this.grSetings.Controls.Add(this.panel4);
            this.grSetings.Controls.Add(this.panel3);
            this.grSetings.Controls.Add(this.panel2);
            this.grSetings.Controls.Add(this.panel1);
            this.grSetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSetings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.grSetings.Location = new System.Drawing.Point(292, 112);
            this.grSetings.Name = "grSetings";
            this.grSetings.Size = new System.Drawing.Size(175, 175);
            this.grSetings.TabIndex = 10;
            this.grSetings.TabStop = false;
            this.grSetings.Text = "Ustawienia";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbSave);
            this.panel4.Location = new System.Drawing.Point(10, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 21);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbAuto);
            this.panel3.Location = new System.Drawing.Point(10, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 21);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbIP);
            this.panel2.Location = new System.Drawing.Point(10, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 21);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDHCP);
            this.panel1.Location = new System.Drawing.Point(11, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 21);
            this.panel1.TabIndex = 9;
            // 
            // grActions
            // 
            this.grActions.Controls.Add(this.btResetConf);
            this.grActions.Controls.Add(this.btSaveConf);
            this.grActions.Controls.Add(this.btExit);
            this.grActions.Controls.Add(this.btSave);
            this.grActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.grActions.Location = new System.Drawing.Point(473, 112);
            this.grActions.Name = "grActions";
            this.grActions.Size = new System.Drawing.Size(145, 175);
            this.grActions.TabIndex = 11;
            this.grActions.TabStop = false;
            this.grActions.Text = "Akcje";
            // 
            // btResetConf
            // 
            this.btResetConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResetConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(203)))), ((int)(((byte)(139)))));
            this.btResetConf.Location = new System.Drawing.Point(6, 98);
            this.btResetConf.Name = "btResetConf";
            this.btResetConf.Size = new System.Drawing.Size(132, 26);
            this.btResetConf.TabIndex = 6;
            this.btResetConf.Text = "Resetuj Konf.";
            this.btResetConf.UseVisualStyleBackColor = true;
            this.btResetConf.Click += new System.EventHandler(this.btResetConf_Click);
            // 
            // btSaveConf
            // 
            this.btSaveConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(142)))), ((int)(((byte)(173)))));
            this.btSaveConf.Location = new System.Drawing.Point(6, 59);
            this.btSaveConf.Name = "btSaveConf";
            this.btSaveConf.Size = new System.Drawing.Size(132, 26);
            this.btSaveConf.TabIndex = 5;
            this.btSaveConf.Text = "Zapisz Konf.";
            this.btSaveConf.UseVisualStyleBackColor = true;
            this.btSaveConf.Click += new System.EventHandler(this.btSaveConf_Click);
            // 
            // btExit
            // 
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(97)))), ((int)(((byte)(106)))));
            this.btExit.Location = new System.Drawing.Point(6, 136);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(132, 26);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Zamknij";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            this.btSave.Location = new System.Drawing.Point(6, 21);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(132, 26);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Zapisz";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // botomBar
            // 
            this.botomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.botomBar.Controls.Add(this.lbAuthor);
            this.botomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botomBar.Location = new System.Drawing.Point(0, 295);
            this.botomBar.Name = "botomBar";
            this.botomBar.Size = new System.Drawing.Size(630, 15);
            this.botomBar.TabIndex = 12;
            this.botomBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.botomBar_MouseMove);
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.lbAuthor.Location = new System.Drawing.Point(246, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(137, 13);
            this.lbAuthor.TabIndex = 0;
            this.lbAuthor.Text = "Wykonał Maurycy Frydecki";
            this.lbAuthor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbAuthor_MouseMove);
            // 
            // rbSave
            // 
            this.rbSave.AutoSize = true;
            this.rbSave.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            this.rbSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbSave.LastChecked = false;
            this.rbSave.Location = new System.Drawing.Point(0, 0);
            this.rbSave.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbSave.Name = "rbSave";
            this.rbSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbSave.Size = new System.Drawing.Size(158, 21);
            this.rbSave.TabIndex = 8;
            this.rbSave.TabStop = true;
            this.rbSave.Text = "Zapis przy starcie";
            this.rbSave.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(135)))), ((int)(((byte)(112)))));
            this.rbSave.UseVisualStyleBackColor = true;
            this.rbSave.Click += new System.EventHandler(this.rbSave_Click);
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            this.rbAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAuto.LastChecked = false;
            this.rbAuto.Location = new System.Drawing.Point(0, 0);
            this.rbAuto.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbAuto.Size = new System.Drawing.Size(84, 21);
            this.rbAuto.TabIndex = 6;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Auto IP";
            this.rbAuto.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(135)))), ((int)(((byte)(112)))));
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.Click += new System.EventHandler(this.rbAuto_Click);
            // 
            // rbIP
            // 
            this.rbIP.AutoSize = true;
            this.rbIP.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            this.rbIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbIP.LastChecked = false;
            this.rbIP.Location = new System.Drawing.Point(0, 0);
            this.rbIP.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbIP.Name = "rbIP";
            this.rbIP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbIP.Size = new System.Drawing.Size(148, 21);
            this.rbIP.TabIndex = 7;
            this.rbIP.TabStop = true;
            this.rbIP.Text = "IP Egzaminatora";
            this.rbIP.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(135)))), ((int)(((byte)(112)))));
            this.rbIP.UseVisualStyleBackColor = true;
            this.rbIP.Click += new System.EventHandler(this.rbIP_Click);
            // 
            // rbDHCP
            // 
            this.rbDHCP.AutoSize = true;
            this.rbDHCP.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            this.rbDHCP.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbDHCP.LastChecked = false;
            this.rbDHCP.Location = new System.Drawing.Point(0, 0);
            this.rbDHCP.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbDHCP.Name = "rbDHCP";
            this.rbDHCP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbDHCP.Size = new System.Drawing.Size(133, 21);
            this.rbDHCP.TabIndex = 5;
            this.rbDHCP.TabStop = true;
            this.rbDHCP.Tag = "";
            this.rbDHCP.Text = "Usługa DHCP";
            this.rbDHCP.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(135)))), ((int)(((byte)(112)))));
            this.rbDHCP.UseVisualStyleBackColor = true;
            this.rbDHCP.Click += new System.EventHandler(this.rbDHCP_Click);
            // 
            // tbDNS1
            // 
            this.tbDNS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.tbDNS1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.tbDNS1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.tbDNS1.Location = new System.Drawing.Point(164, 105);
            this.tbDNS1.Name = "tbDNS1";
            this.tbDNS1.Size = new System.Drawing.Size(100, 22);
            this.tbDNS1.TabIndex = 9;
            this.tbDNS1.Text = "8.8.8.8";
            this.tbDNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDNS2
            // 
            this.tbDNS2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.tbDNS2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.tbDNS2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.tbDNS2.Location = new System.Drawing.Point(164, 133);
            this.tbDNS2.Name = "tbDNS2";
            this.tbDNS2.Size = new System.Drawing.Size(100, 22);
            this.tbDNS2.TabIndex = 8;
            this.tbDNS2.Text = "1.1.1.1";
            this.tbDNS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGate
            // 
            this.tbGate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.tbGate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.tbGate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.tbGate.Location = new System.Drawing.Point(164, 77);
            this.tbGate.Name = "tbGate";
            this.tbGate.Size = new System.Drawing.Size(100, 22);
            this.tbGate.TabIndex = 7;
            this.tbGate.Text = "192.168.0.1";
            this.tbGate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMask
            // 
            this.tbMask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.tbMask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.tbMask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.tbMask.Location = new System.Drawing.Point(164, 49);
            this.tbMask.Name = "tbMask";
            this.tbMask.Size = new System.Drawing.Size(100, 22);
            this.tbMask.TabIndex = 6;
            this.tbMask.Text = "255.255.255.0";
            this.tbMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIP
            // 
            this.tbIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.tbIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.tbIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.tbIP.Location = new System.Drawing.Point(164, 21);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 22);
            this.tbIP.TabIndex = 5;
            this.tbIP.Text = "192.168.0.20";
            this.tbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbNetworkInterfaceBox
            // 
            this.cbNetworkInterfaceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.cbNetworkInterfaceBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.cbNetworkInterfaceBox.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.cbNetworkInterfaceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.cbNetworkInterfaceBox.Location = new System.Drawing.Point(54, 28);
            this.cbNetworkInterfaceBox.Name = "cbNetworkInterfaceBox";
            this.cbNetworkInterfaceBox.Size = new System.Drawing.Size(458, 24);
            this.cbNetworkInterfaceBox.TabIndex = 3;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(630, 310);
            this.Controls.Add(this.botomBar);
            this.Controls.Add(this.grActions);
            this.Controls.Add(this.grSetings);
            this.Controls.Add(this.grNetworkSetings);
            this.Controls.Add(this.grNetworkAdapter);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KIP-ASE";
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.grNetworkAdapter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInternetCard)).EndInit();
            this.grNetworkSetings.ResumeLayout(false);
            this.grNetworkSetings.PerformLayout();
            this.grSetings.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grActions.ResumeLayout(false);
            this.botomBar.ResumeLayout(false);
            this.botomBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbAppName;
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.GroupBox grNetworkAdapter;
        private System.Windows.Forms.PictureBox picInternetCard;
        private System.Windows.Forms.Button btScan;
        private CustomFlatComboBox cbNetworkInterfaceBox;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbMask;
        private System.Windows.Forms.Label lbGate;
        private System.Windows.Forms.Label lbDNS1;
        private System.Windows.Forms.Label lbDNS2;
        private CustomTextBox tbIP;
        private CustomTextBox tbMask;
        private CustomTextBox tbGate;
        private CustomTextBox tbDNS2;
        private CustomTextBox tbDNS1;
        private System.Windows.Forms.GroupBox grNetworkSetings;
        private System.Windows.Forms.GroupBox grSetings;
        private System.Windows.Forms.GroupBox grActions;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btResetConf;
        private System.Windows.Forms.Button btSaveConf;
        private CustomRadioButton rbSave;
        private CustomRadioButton rbIP;
        private CustomRadioButton rbAuto;
        private CustomRadioButton rbDHCP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel botomBar;
        private System.Windows.Forms.Label lbAuthor;
    }
}

