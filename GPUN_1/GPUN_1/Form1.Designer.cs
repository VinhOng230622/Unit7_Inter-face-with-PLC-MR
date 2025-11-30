namespace GPUN_1
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCONTROL = new System.Windows.Forms.Button();
            this.btnUSER = new System.Windows.Forms.Button();
            this.btnCONNECT2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MainForm = new System.Windows.Forms.Panel();
            this.panelCONNECT = new System.Windows.Forms.Panel();
            this.cb_Pick_DataBits = new System.Windows.Forms.ComboBox();
            this.lbl_DataBits = new System.Windows.Forms.Label();
            this.cb_Pick_Slave = new System.Windows.Forms.ComboBox();
            this.lbl_Device = new System.Windows.Forms.Label();
            this.cb_Pick_StopBits = new System.Windows.Forms.ComboBox();
            this.lbl_Stopbits = new System.Windows.Forms.Label();
            this.cb_Pick_Parity = new System.Windows.Forms.ComboBox();
            this.lbl_Parrity = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCONTROL = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.BUT_3 = new System.Windows.Forms.Button();
            this.BUT_2 = new System.Windows.Forms.Button();
            this.BUT_1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.panelCONNECT.SuspendLayout();
            this.panelCONTROL.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Controls.Add(this.btnCONTROL);
            this.panelMenu.Controls.Add(this.btnUSER);
            this.panelMenu.Controls.Add(this.btnCONNECT2);
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMenu.Location = new System.Drawing.Point(2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 604);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnCONTROL
            // 
            this.btnCONTROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONTROL.Location = new System.Drawing.Point(3, 229);
            this.btnCONTROL.Name = "btnCONTROL";
            this.btnCONTROL.Size = new System.Drawing.Size(194, 47);
            this.btnCONTROL.TabIndex = 3;
            this.btnCONTROL.Text = "CONTROL";
            this.btnCONTROL.UseVisualStyleBackColor = true;
            this.btnCONTROL.Click += new System.EventHandler(this.btnCONTROL_Click);
            // 
            // btnUSER
            // 
            this.btnUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSER.Location = new System.Drawing.Point(3, 123);
            this.btnUSER.Name = "btnUSER";
            this.btnUSER.Size = new System.Drawing.Size(194, 47);
            this.btnUSER.TabIndex = 0;
            this.btnUSER.Text = "USER";
            this.btnUSER.UseVisualStyleBackColor = true;
            this.btnUSER.Click += new System.EventHandler(this.btnUSER_Click);
            // 
            // btnCONNECT2
            // 
            this.btnCONNECT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONNECT2.Location = new System.Drawing.Point(3, 176);
            this.btnCONNECT2.Name = "btnCONNECT2";
            this.btnCONNECT2.Size = new System.Drawing.Size(194, 47);
            this.btnCONNECT2.TabIndex = 2;
            this.btnCONNECT2.Text = "CONNECT";
            this.btnCONNECT2.UseVisualStyleBackColor = true;
            this.btnCONNECT2.Click += new System.EventHandler(this.btnCONNECT2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(208, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 70);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "SECOND PROGAM RS-485";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 47);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(388, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "ĐĂNG NHẬP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.MainForm.Controls.Add(this.button1);
            this.MainForm.Controls.Add(this.textBox2);
            this.MainForm.Controls.Add(this.textBox1);
            this.MainForm.Controls.Add(this.label3);
            this.MainForm.Controls.Add(this.label2);
            this.MainForm.Location = new System.Drawing.Point(205, 78);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(880, 527);
            this.MainForm.TabIndex = 7;
            this.MainForm.Visible = false;
            // 
            // panelCONNECT
            // 
            this.panelCONNECT.BackColor = System.Drawing.Color.Yellow;
            this.panelCONNECT.Controls.Add(this.cb_Pick_DataBits);
            this.panelCONNECT.Controls.Add(this.lbl_DataBits);
            this.panelCONNECT.Controls.Add(this.cb_Pick_Slave);
            this.panelCONNECT.Controls.Add(this.lbl_Device);
            this.panelCONNECT.Controls.Add(this.cb_Pick_StopBits);
            this.panelCONNECT.Controls.Add(this.lbl_Stopbits);
            this.panelCONNECT.Controls.Add(this.cb_Pick_Parity);
            this.panelCONNECT.Controls.Add(this.lbl_Parrity);
            this.panelCONNECT.Controls.Add(this.btnDisconnect);
            this.panelCONNECT.Controls.Add(this.lblStatus);
            this.panelCONNECT.Controls.Add(this.cbBaudrate);
            this.panelCONNECT.Controls.Add(this.cbPort);
            this.panelCONNECT.Controls.Add(this.label6);
            this.panelCONNECT.Controls.Add(this.btnConnect);
            this.panelCONNECT.Controls.Add(this.label4);
            this.panelCONNECT.Controls.Add(this.label5);
            this.panelCONNECT.Location = new System.Drawing.Point(211, 75);
            this.panelCONNECT.Name = "panelCONNECT";
            this.panelCONNECT.Size = new System.Drawing.Size(871, 524);
            this.panelCONNECT.TabIndex = 14;
            this.panelCONNECT.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCONNECT_Paint);
            // 
            // cb_Pick_DataBits
            // 
            this.cb_Pick_DataBits.FormattingEnabled = true;
            this.cb_Pick_DataBits.Location = new System.Drawing.Point(686, 183);
            this.cb_Pick_DataBits.Name = "cb_Pick_DataBits";
            this.cb_Pick_DataBits.Size = new System.Drawing.Size(121, 21);
            this.cb_Pick_DataBits.TabIndex = 21;
            this.cb_Pick_DataBits.Text = " Chọn Data Bits";
            // 
            // lbl_DataBits
            // 
            this.lbl_DataBits.BackColor = System.Drawing.Color.White;
            this.lbl_DataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataBits.Location = new System.Drawing.Point(451, 165);
            this.lbl_DataBits.Name = "lbl_DataBits";
            this.lbl_DataBits.Size = new System.Drawing.Size(220, 47);
            this.lbl_DataBits.TabIndex = 20;
            this.lbl_DataBits.Text = "DATA BITS";
            this.lbl_DataBits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_DataBits.UseMnemonic = false;
            // 
            // cb_Pick_Slave
            // 
            this.cb_Pick_Slave.FormattingEnabled = true;
            this.cb_Pick_Slave.Location = new System.Drawing.Point(686, 245);
            this.cb_Pick_Slave.Name = "cb_Pick_Slave";
            this.cb_Pick_Slave.Size = new System.Drawing.Size(121, 21);
            this.cb_Pick_Slave.TabIndex = 19;
            this.cb_Pick_Slave.Text = " Chọn thiết bị Slave";
            // 
            // lbl_Device
            // 
            this.lbl_Device.BackColor = System.Drawing.Color.White;
            this.lbl_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Device.Location = new System.Drawing.Point(451, 227);
            this.lbl_Device.Name = "lbl_Device";
            this.lbl_Device.Size = new System.Drawing.Size(220, 47);
            this.lbl_Device.TabIndex = 18;
            this.lbl_Device.Text = "CHỌN THIẾT BỊ";
            this.lbl_Device.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Device.UseMnemonic = false;
            // 
            // cb_Pick_StopBits
            // 
            this.cb_Pick_StopBits.FormattingEnabled = true;
            this.cb_Pick_StopBits.Location = new System.Drawing.Point(686, 114);
            this.cb_Pick_StopBits.Name = "cb_Pick_StopBits";
            this.cb_Pick_StopBits.Size = new System.Drawing.Size(121, 21);
            this.cb_Pick_StopBits.TabIndex = 16;
            this.cb_Pick_StopBits.Text = "Chọn Stop Bits";
            // 
            // lbl_Stopbits
            // 
            this.lbl_Stopbits.BackColor = System.Drawing.Color.White;
            this.lbl_Stopbits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stopbits.Location = new System.Drawing.Point(451, 96);
            this.lbl_Stopbits.Name = "lbl_Stopbits";
            this.lbl_Stopbits.Size = new System.Drawing.Size(220, 47);
            this.lbl_Stopbits.TabIndex = 14;
            this.lbl_Stopbits.Text = "STOP BITS";
            this.lbl_Stopbits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Stopbits.UseMnemonic = false;
            this.lbl_Stopbits.Click += new System.EventHandler(this.label9_Click);
            // 
            // cb_Pick_Parity
            // 
            this.cb_Pick_Parity.FormattingEnabled = true;
            this.cb_Pick_Parity.Location = new System.Drawing.Point(272, 244);
            this.cb_Pick_Parity.Name = "cb_Pick_Parity";
            this.cb_Pick_Parity.Size = new System.Drawing.Size(116, 21);
            this.cb_Pick_Parity.TabIndex = 13;
            this.cb_Pick_Parity.Text = " Chọn Parity";
            this.cb_Pick_Parity.SelectedIndexChanged += new System.EventHandler(this.cbPickSlave_SelectedIndexChanged);
            // 
            // lbl_Parrity
            // 
            this.lbl_Parrity.BackColor = System.Drawing.Color.White;
            this.lbl_Parrity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Parrity.Location = new System.Drawing.Point(27, 228);
            this.lbl_Parrity.Name = "lbl_Parrity";
            this.lbl_Parrity.Size = new System.Drawing.Size(220, 47);
            this.lbl_Parrity.TabIndex = 12;
            this.lbl_Parrity.Text = "PARITY";
            this.lbl_Parrity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Parrity.UseMnemonic = false;
            this.lbl_Parrity.Click += new System.EventHandler(this.lbl_Chose_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(347, 401);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(194, 47);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "NGẮT KẾT NỐI";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Red;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(169, 470);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(540, 47);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "TRẠNG THÁI : CHƯA KẾT NỐI";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.UseMnemonic = false;
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Location = new System.Drawing.Point(272, 180);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(116, 21);
            this.cbBaudrate.TabIndex = 9;
            this.cbBaudrate.Text = " Chọn Baudrate";
            this.cbBaudrate.SelectedIndexChanged += new System.EventHandler(this.cbBaudrate_SelectedIndexChanged_1);
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(272, 113);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(116, 21);
            this.cbPort.TabIndex = 8;
            this.cbPort.Text = " Chọn Cổng COM";
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 47);
            this.label6.TabIndex = 7;
            this.label6.Text = "BAUDRATE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseMnemonic = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(347, 328);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(194, 47);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "KẾT NỐI";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 47);
            this.label4.TabIndex = 3;
            this.label4.Text = "CHỌN CỔNG COM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(251, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(423, 47);
            this.label5.TabIndex = 2;
            this.label5.Text = "KÉT NỐI RS485";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseMnemonic = false;
            // 
            // panelCONTROL
            // 
            this.panelCONTROL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelCONTROL.Controls.Add(this.textBox6);
            this.panelCONTROL.Controls.Add(this.lblState);
            this.panelCONTROL.Controls.Add(this.BUT_3);
            this.panelCONTROL.Controls.Add(this.BUT_2);
            this.panelCONTROL.Controls.Add(this.BUT_1);
            this.panelCONTROL.Controls.Add(this.label10);
            this.panelCONTROL.Location = new System.Drawing.Point(208, 78);
            this.panelCONTROL.Name = "panelCONTROL";
            this.panelCONTROL.Size = new System.Drawing.Size(883, 524);
            this.panelCONTROL.TabIndex = 19;
            this.panelCONTROL.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCONTROL_Paint_1);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(61, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 16;
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.Purple;
            this.lblState.CausesValidation = false;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblState.Location = new System.Drawing.Point(344, 304);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(224, 76);
            this.lblState.TabIndex = 15;
            this.lblState.Text = "STATE_No";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BUT_3
            // 
            this.BUT_3.Location = new System.Drawing.Point(616, 113);
            this.BUT_3.Name = "BUT_3";
            this.BUT_3.Size = new System.Drawing.Size(75, 73);
            this.BUT_3.TabIndex = 14;
            this.BUT_3.Text = "BUT_3";
            this.BUT_3.UseVisualStyleBackColor = true;
            this.BUT_3.Click += new System.EventHandler(this.BUT_3_Click);
            // 
            // BUT_2
            // 
            this.BUT_2.Location = new System.Drawing.Point(428, 113);
            this.BUT_2.Name = "BUT_2";
            this.BUT_2.Size = new System.Drawing.Size(75, 73);
            this.BUT_2.TabIndex = 13;
            this.BUT_2.Text = "BUT_2";
            this.BUT_2.UseVisualStyleBackColor = true;
            this.BUT_2.Click += new System.EventHandler(this.BUT_2_Click);
            // 
            // BUT_1
            // 
            this.BUT_1.Location = new System.Drawing.Point(241, 113);
            this.BUT_1.Name = "BUT_1";
            this.BUT_1.Size = new System.Drawing.Size(75, 73);
            this.BUT_1.TabIndex = 12;
            this.BUT_1.Text = "BUT_1";
            this.BUT_1.UseVisualStyleBackColor = true;
            this.BUT_1.Click += new System.EventHandler(this.BUT_1_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(251, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(423, 47);
            this.label10.TabIndex = 2;
            this.label10.Text = "CONTROL INTERFACE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCONTROL);
            this.Controls.Add(this.panelCONNECT);
            this.Controls.Add(this.MainForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.MainForm.PerformLayout();
            this.panelCONNECT.ResumeLayout(false);
            this.panelCONTROL.ResumeLayout(false);
            this.panelCONTROL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUSER;
        private System.Windows.Forms.Button btnCONTROL;
        private System.Windows.Forms.Button btnCONNECT2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel panelCONNECT;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelCONTROL;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button BUT_3;
        private System.Windows.Forms.Button BUT_2;
        private System.Windows.Forms.Button BUT_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_Pick_Parity;
        private System.Windows.Forms.Label lbl_Parrity;
        private System.Windows.Forms.ComboBox cb_Pick_Slave;
        private System.Windows.Forms.Label lbl_Device;
        private System.Windows.Forms.ComboBox cb_Pick_StopBits;
        private System.Windows.Forms.Label lbl_Stopbits;
        private System.Windows.Forms.ComboBox cb_Pick_DataBits;
        private System.Windows.Forms.Label lbl_DataBits;
        private System.Windows.Forms.TextBox textBox6;
    }
}

