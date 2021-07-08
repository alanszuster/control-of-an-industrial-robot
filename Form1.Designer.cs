namespace Porty
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabControl tabControl1;
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chBoxDTR = new System.Windows.Forms.CheckBox();
            this.chBoxRTS = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.cBOXCOMPORT = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chBoxOldData = new System.Windows.Forms.CheckBox();
            this.chBoxUpdate = new System.Windows.Forms.CheckBox();
            this.btnClearDataIN = new System.Windows.Forms.Button();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWhere = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDRAW = new System.Windows.Forms.Button();
            this.tBoxX = new System.Windows.Forms.TextBox();
            this.btnStraight = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tBoxY = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tBoxZ = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Jogspeed = new System.Windows.Forms.TrackBar();
            this.tbjspeed = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLeftW = new System.Windows.Forms.Button();
            this.btnRightW = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRightR = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.btnOH = new System.Windows.Forms.Button();
            this.btnLeftR = new System.Windows.Forms.Button();
            this.btnLeftS = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRightS = new System.Windows.Forms.Button();
            this.btnRightP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLeftP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLeftE = new System.Windows.Forms.Button();
            this.btnRightE = new System.Windows.Forms.Button();
            this.btnRightT = new System.Windows.Forms.Button();
            this.btnLeftT = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Enter = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            tabControl1 = new System.Windows.Forms.TabControl();
            tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Jogspeed)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Controls.Add(this.tabPage3);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(902, 365);
            tabControl1.TabIndex = 14;
            tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(894, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Communication";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.chBoxDTR);
            this.panel4.Controls.Add(this.chBoxRTS);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Location = new System.Drawing.Point(8, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 120);
            this.panel4.TabIndex = 20;
            // 
            // chBoxDTR
            // 
            this.chBoxDTR.AutoSize = true;
            this.chBoxDTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxDTR.ForeColor = System.Drawing.Color.Aqua;
            this.chBoxDTR.Location = new System.Drawing.Point(185, 55);
            this.chBoxDTR.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxDTR.Name = "chBoxDTR";
            this.chBoxDTR.Size = new System.Drawing.Size(52, 17);
            this.chBoxDTR.TabIndex = 28;
            this.chBoxDTR.Text = "DTR";
            this.chBoxDTR.UseVisualStyleBackColor = true;
            this.chBoxDTR.CheckedChanged += new System.EventHandler(this.chBoxDTR_CheckedChanged);
            // 
            // chBoxRTS
            // 
            this.chBoxRTS.AutoSize = true;
            this.chBoxRTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxRTS.ForeColor = System.Drawing.Color.Aqua;
            this.chBoxRTS.Location = new System.Drawing.Point(28, 55);
            this.chBoxRTS.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxRTS.Name = "chBoxRTS";
            this.chBoxRTS.Size = new System.Drawing.Size(81, 17);
            this.chBoxRTS.TabIndex = 29;
            this.chBoxRTS.Text = "RTS/CTS";
            this.chBoxRTS.UseVisualStyleBackColor = true;
            this.chBoxRTS.CheckedChanged += new System.EventHandler(this.chBoxRTS_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.Location = new System.Drawing.Point(106, 18);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "Flow control:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tBoxDataOut);
            this.panel3.Controls.Add(this.btnSendData);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(8, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 205);
            this.panel3.TabIndex = 19;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(120, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "SEND";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(37, 49);
            this.tBoxDataOut.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(229, 76);
            this.tBoxDataOut.TabIndex = 6;
            // 
            // btnSendData
            // 
            this.btnSendData.BackColor = System.Drawing.Color.LightGray;
            this.btnSendData.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSendData.Location = new System.Drawing.Point(37, 136);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 28);
            this.btnSendData.TabIndex = 5;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = false;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(191, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cBoxStopBits);
            this.panel2.Controls.Add(this.cBoxParity);
            this.panel2.Controls.Add(this.cBOXCOMPORT);
            this.panel2.Controls.Add(this.cBoxDataBits);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cBoxBaudRate);
            this.panel2.Location = new System.Drawing.Point(320, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 329);
            this.panel2.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(128, 255);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "DISCONNECT";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Green;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Location = new System.Drawing.Point(29, 255);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(95, 28);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "CONNECT";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Baud Rate:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 290);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(194, 13);
            this.progressBar1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data Bits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(30, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Parity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(30, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Stop Bits:";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cBoxStopBits.Location = new System.Drawing.Point(128, 200);
            this.cBoxStopBits.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(82, 21);
            this.cBoxStopBits.TabIndex = 18;
            this.cBoxStopBits.Text = "1";
            // 
            // cBoxParity
            // 
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Items.AddRange(new object[] {
            "Mark",
            "Space",
            "None",
            "Odd",
            "Even"});
            this.cBoxParity.Location = new System.Drawing.Point(128, 150);
            this.cBoxParity.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(82, 21);
            this.cBoxParity.TabIndex = 27;
            this.cBoxParity.Text = "None";
            // 
            // cBOXCOMPORT
            // 
            this.cBOXCOMPORT.FormattingEnabled = true;
            this.cBOXCOMPORT.Location = new System.Drawing.Point(128, 12);
            this.cBOXCOMPORT.Margin = new System.Windows.Forms.Padding(2);
            this.cBOXCOMPORT.Name = "cBOXCOMPORT";
            this.cBOXCOMPORT.Size = new System.Drawing.Size(82, 21);
            this.cBOXCOMPORT.TabIndex = 25;
            this.cBOXCOMPORT.SelectedIndexChanged += new System.EventHandler(this.cBOXCOMPORT_SelectedIndexChanged);
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(128, 104);
            this.cBoxDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(82, 21);
            this.cBoxDataBits.TabIndex = 21;
            this.cBoxDataBits.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Port COM:";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(128, 57);
            this.cBoxBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(82, 21);
            this.cBoxBaudRate.TabIndex = 23;
            this.cBoxBaudRate.Text = "9600";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chBoxOldData);
            this.panel1.Controls.Add(this.chBoxUpdate);
            this.panel1.Controls.Add(this.btnClearDataIN);
            this.panel1.Controls.Add(this.tBoxDataIN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnWhere);
            this.panel1.Location = new System.Drawing.Point(567, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 329);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chBoxOldData
            // 
            this.chBoxOldData.AutoSize = true;
            this.chBoxOldData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxOldData.ForeColor = System.Drawing.Color.White;
            this.chBoxOldData.Location = new System.Drawing.Point(183, 237);
            this.chBoxOldData.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxOldData.Name = "chBoxOldData";
            this.chBoxOldData.Size = new System.Drawing.Size(82, 20);
            this.chBoxOldData.TabIndex = 16;
            this.chBoxOldData.Text = "Old Data";
            this.chBoxOldData.UseVisualStyleBackColor = true;
            this.chBoxOldData.CheckedChanged += new System.EventHandler(this.chBoxOldData_CheckedChanged);
            // 
            // chBoxUpdate
            // 
            this.chBoxUpdate.AutoSize = true;
            this.chBoxUpdate.BackColor = System.Drawing.Color.Black;
            this.chBoxUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxUpdate.ForeColor = System.Drawing.Color.White;
            this.chBoxUpdate.Location = new System.Drawing.Point(55, 237);
            this.chBoxUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxUpdate.Name = "chBoxUpdate";
            this.chBoxUpdate.Size = new System.Drawing.Size(72, 20);
            this.chBoxUpdate.TabIndex = 15;
            this.chBoxUpdate.Text = "Update";
            this.chBoxUpdate.UseVisualStyleBackColor = false;
            this.chBoxUpdate.CheckedChanged += new System.EventHandler(this.chBoxUpdate_CheckedChanged);
            // 
            // btnClearDataIN
            // 
            this.btnClearDataIN.BackColor = System.Drawing.Color.LightGray;
            this.btnClearDataIN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearDataIN.Location = new System.Drawing.Point(190, 168);
            this.btnClearDataIN.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearDataIN.Name = "btnClearDataIN";
            this.btnClearDataIN.Size = new System.Drawing.Size(75, 28);
            this.btnClearDataIN.TabIndex = 9;
            this.btnClearDataIN.Text = "Clear Data ";
            this.btnClearDataIN.UseVisualStyleBackColor = false;
            this.btnClearDataIN.Click += new System.EventHandler(this.btnClearDataIN_Click);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Location = new System.Drawing.Point(55, 49);
            this.tBoxDataIN.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(210, 101);
            this.tBoxDataIN.TabIndex = 10;
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataIN_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(125, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "RECEIVE";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.BackColor = System.Drawing.Color.LightGray;
            this.btnWhere.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnWhere.Location = new System.Drawing.Point(55, 168);
            this.btnWhere.Margin = new System.Windows.Forms.Padding(2);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(75, 28);
            this.btnWhere.TabIndex = 14;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = false;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(894, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jog and XYZ";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnDRAW);
            this.panel6.Controls.Add(this.tBoxX);
            this.panel6.Controls.Add(this.btnStraight);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.tBoxY);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.tBoxZ);
            this.panel6.Location = new System.Drawing.Point(515, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(371, 329);
            this.panel6.TabIndex = 25;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // btnDRAW
            // 
            this.btnDRAW.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDRAW.Location = new System.Drawing.Point(234, 167);
            this.btnDRAW.Margin = new System.Windows.Forms.Padding(2);
            this.btnDRAW.Name = "btnDRAW";
            this.btnDRAW.Size = new System.Drawing.Size(96, 35);
            this.btnDRAW.TabIndex = 27;
            this.btnDRAW.Text = "DRAW";
            this.btnDRAW.UseVisualStyleBackColor = true;
            this.btnDRAW.Click += new System.EventHandler(this.btnDRAW_Click);
            // 
            // tBoxX
            // 
            this.tBoxX.Location = new System.Drawing.Point(89, 64);
            this.tBoxX.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxX.Name = "tBoxX";
            this.tBoxX.Size = new System.Drawing.Size(71, 20);
            this.tBoxX.TabIndex = 1;
            // 
            // btnStraight
            // 
            this.btnStraight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnStraight.Location = new System.Drawing.Point(234, 104);
            this.btnStraight.Margin = new System.Windows.Forms.Padding(2);
            this.btnStraight.Name = "btnStraight";
            this.btnStraight.Size = new System.Drawing.Size(96, 35);
            this.btnStraight.TabIndex = 26;
            this.btnStraight.Text = "STRAIGHT";
            this.btnStraight.UseVisualStyleBackColor = true;
            this.btnStraight.Click += new System.EventHandler(this.btnStraight_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(40, 59);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 24);
            this.label13.TabIndex = 6;
            this.label13.Text = "X";
            // 
            // tBoxY
            // 
            this.tBoxY.Location = new System.Drawing.Point(89, 146);
            this.tBoxY.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxY.Name = "tBoxY";
            this.tBoxY.Size = new System.Drawing.Size(71, 20);
            this.tBoxY.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(38, 141);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 24);
            this.label14.TabIndex = 4;
            this.label14.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(40, 221);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 24);
            this.label15.TabIndex = 5;
            this.label15.Text = "Z";
            // 
            // tBoxZ
            // 
            this.tBoxZ.Location = new System.Drawing.Point(89, 226);
            this.tBoxZ.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxZ.Name = "tBoxZ";
            this.tBoxZ.Size = new System.Drawing.Size(71, 20);
            this.tBoxZ.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Jogspeed);
            this.panel5.Controls.Add(this.tbjspeed);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.btnLeftW);
            this.panel5.Controls.Add(this.btnRightW);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.btnRightR);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.ButtonClose);
            this.panel5.Controls.Add(this.btnOH);
            this.panel5.Controls.Add(this.btnLeftR);
            this.panel5.Controls.Add(this.btnLeftS);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.btnRightS);
            this.panel5.Controls.Add(this.btnRightP);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.btnLeftP);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.btnLeftE);
            this.panel5.Controls.Add(this.btnRightE);
            this.panel5.Controls.Add(this.btnRightT);
            this.panel5.Controls.Add(this.btnLeftT);
            this.panel5.Location = new System.Drawing.Point(8, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(501, 329);
            this.panel5.TabIndex = 23;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // Jogspeed
            // 
            this.Jogspeed.BackColor = System.Drawing.Color.Black;
            this.Jogspeed.Location = new System.Drawing.Point(262, 51);
            this.Jogspeed.Maximum = 20;
            this.Jogspeed.Name = "Jogspeed";
            this.Jogspeed.Size = new System.Drawing.Size(208, 45);
            this.Jogspeed.TabIndex = 33;
            this.Jogspeed.TickFrequency = 0;
            this.Jogspeed.Scroll += new System.EventHandler(this.Jogspeed_Scroll);
            // 
            // tbjspeed
            // 
            this.tbjspeed.BackColor = System.Drawing.Color.LightYellow;
            this.tbjspeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbjspeed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbjspeed.ForeColor = System.Drawing.Color.Red;
            this.tbjspeed.Location = new System.Drawing.Point(339, 101);
            this.tbjspeed.Margin = new System.Windows.Forms.Padding(2);
            this.tbjspeed.Name = "tbjspeed";
            this.tbjspeed.ReadOnly = true;
            this.tbjspeed.Size = new System.Drawing.Size(71, 29);
            this.tbjspeed.TabIndex = 34;
            this.tbjspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(336, 32);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "JOG speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(18, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Waist";
            // 
            // btnLeftW
            // 
            this.btnLeftW.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnLeftW.Location = new System.Drawing.Point(94, 32);
            this.btnLeftW.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftW.Name = "btnLeftW";
            this.btnLeftW.Size = new System.Drawing.Size(57, 30);
            this.btnLeftW.TabIndex = 20;
            this.btnLeftW.Text = "🡄";
            this.btnLeftW.UseVisualStyleBackColor = true;
            this.btnLeftW.Click += new System.EventHandler(this.btnLeftW_Click);
            // 
            // btnRightW
            // 
            this.btnRightW.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnRightW.Location = new System.Drawing.Point(164, 32);
            this.btnRightW.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightW.Name = "btnRightW";
            this.btnRightW.Size = new System.Drawing.Size(57, 30);
            this.btnRightW.TabIndex = 19;
            this.btnRightW.Text = "🡆";
            this.btnRightW.UseVisualStyleBackColor = true;
            this.btnRightW.Click += new System.EventHandler(this.btnRightW_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(18, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Shoulder";
            // 
            // btnRightR
            // 
            this.btnRightR.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnRightR.Location = new System.Drawing.Point(164, 237);
            this.btnRightR.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightR.Name = "btnRightR";
            this.btnRightR.Size = new System.Drawing.Size(57, 30);
            this.btnRightR.TabIndex = 30;
            this.btnRightR.Text = "🡆";
            this.btnRightR.UseVisualStyleBackColor = true;
            this.btnRightR.Click += new System.EventHandler(this.btnRightR_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(18, 244);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "Roll";
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonClose.Location = new System.Drawing.Point(325, 235);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(97, 32);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "CLOSE HAND";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // btnOH
            // 
            this.btnOH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnOH.Location = new System.Drawing.Point(325, 181);
            this.btnOH.Margin = new System.Windows.Forms.Padding(2);
            this.btnOH.Name = "btnOH";
            this.btnOH.Size = new System.Drawing.Size(97, 32);
            this.btnOH.TabIndex = 19;
            this.btnOH.Text = "OPEN HAND";
            this.btnOH.UseVisualStyleBackColor = true;
            this.btnOH.Click += new System.EventHandler(this.btnOH_Click);
            // 
            // btnLeftR
            // 
            this.btnLeftR.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnLeftR.Location = new System.Drawing.Point(94, 237);
            this.btnLeftR.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftR.Name = "btnLeftR";
            this.btnLeftR.Size = new System.Drawing.Size(57, 30);
            this.btnLeftR.TabIndex = 29;
            this.btnLeftR.Text = "🡄";
            this.btnLeftR.UseVisualStyleBackColor = true;
            this.btnLeftR.Click += new System.EventHandler(this.btnLeftR_Click);
            // 
            // btnLeftS
            // 
            this.btnLeftS.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnLeftS.Location = new System.Drawing.Point(94, 74);
            this.btnLeftS.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftS.Name = "btnLeftS";
            this.btnLeftS.Size = new System.Drawing.Size(57, 30);
            this.btnLeftS.TabIndex = 21;
            this.btnLeftS.Text = "🡄";
            this.btnLeftS.UseVisualStyleBackColor = true;
            this.btnLeftS.Click += new System.EventHandler(this.btnLeftS_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(18, 206);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "Pitch";
            // 
            // btnRightS
            // 
            this.btnRightS.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnRightS.Location = new System.Drawing.Point(164, 74);
            this.btnRightS.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightS.Name = "btnRightS";
            this.btnRightS.Size = new System.Drawing.Size(57, 30);
            this.btnRightS.TabIndex = 22;
            this.btnRightS.Text = "🡆";
            this.btnRightS.UseVisualStyleBackColor = true;
            this.btnRightS.Click += new System.EventHandler(this.btnRightS_Click);
            // 
            // btnRightP
            // 
            this.btnRightP.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnRightP.Location = new System.Drawing.Point(164, 199);
            this.btnRightP.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightP.Name = "btnRightP";
            this.btnRightP.Size = new System.Drawing.Size(57, 30);
            this.btnRightP.TabIndex = 28;
            this.btnRightP.Text = "🡆";
            this.btnRightP.UseVisualStyleBackColor = true;
            this.btnRightP.Click += new System.EventHandler(this.btnRightP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(18, 167);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Twist";
            // 
            // btnLeftP
            // 
            this.btnLeftP.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnLeftP.Location = new System.Drawing.Point(94, 199);
            this.btnLeftP.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftP.Name = "btnLeftP";
            this.btnLeftP.Size = new System.Drawing.Size(57, 30);
            this.btnLeftP.TabIndex = 27;
            this.btnLeftP.Text = "🡄";
            this.btnLeftP.UseVisualStyleBackColor = true;
            this.btnLeftP.Click += new System.EventHandler(this.btnLeftP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(18, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Elbow";
            // 
            // btnLeftE
            // 
            this.btnLeftE.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnLeftE.Location = new System.Drawing.Point(94, 116);
            this.btnLeftE.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftE.Name = "btnLeftE";
            this.btnLeftE.Size = new System.Drawing.Size(57, 30);
            this.btnLeftE.TabIndex = 23;
            this.btnLeftE.Text = "🡄";
            this.btnLeftE.UseVisualStyleBackColor = true;
            this.btnLeftE.Click += new System.EventHandler(this.btnLeftE_Click);
            // 
            // btnRightE
            // 
            this.btnRightE.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnRightE.Location = new System.Drawing.Point(164, 116);
            this.btnRightE.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightE.Name = "btnRightE";
            this.btnRightE.Size = new System.Drawing.Size(57, 30);
            this.btnRightE.TabIndex = 24;
            this.btnRightE.Text = "🡆";
            this.btnRightE.UseVisualStyleBackColor = true;
            this.btnRightE.Click += new System.EventHandler(this.btnRightE_Click);
            // 
            // btnRightT
            // 
            this.btnRightT.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnRightT.Location = new System.Drawing.Point(164, 157);
            this.btnRightT.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightT.Name = "btnRightT";
            this.btnRightT.Size = new System.Drawing.Size(57, 30);
            this.btnRightT.TabIndex = 26;
            this.btnRightT.Text = "🡆";
            this.btnRightT.UseVisualStyleBackColor = true;
            this.btnRightT.Click += new System.EventHandler(this.btnRightT_Click);
            // 
            // btnLeftT
            // 
            this.btnLeftT.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btnLeftT.Location = new System.Drawing.Point(94, 157);
            this.btnLeftT.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftT.Name = "btnLeftT";
            this.btnLeftT.Size = new System.Drawing.Size(57, 31);
            this.btnLeftT.TabIndex = 25;
            this.btnLeftT.Text = "🡄";
            this.btnLeftT.UseVisualStyleBackColor = true;
            this.btnLeftT.Click += new System.EventHandler(this.btnLeftT_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(837, 326);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 21;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(894, 339);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manual Control";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.Enter);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.comboBox1);
            this.panel7.Location = new System.Drawing.Point(8, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(880, 327);
            this.panel7.TabIndex = 26;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Enter.ForeColor = System.Drawing.Color.Black;
            this.Enter.Location = new System.Drawing.Point(392, 192);
            this.Enter.Margin = new System.Windows.Forms.Padding(2);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(96, 35);
            this.Enter.TabIndex = 32;
            this.Enter.Text = "ENTER";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(540, 88);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 19);
            this.label22.TabIndex = 31;
            this.label22.Text = "Parameter";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(224, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 19);
            this.label20.TabIndex = 30;
            this.label20.Text = "Command List";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(531, 122);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 25);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GC",
            "GO",
            "DJ",
            "WH",
            "SP"});
            this.comboBox1.Location = new System.Drawing.Point(224, 122);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 26);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 377);
            this.Controls.Add(tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Jogspeed)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox chBoxRTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBoxDTR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.ComboBox cBOXCOMPORT;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.Button btnClearDataIN;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDRAW;
        private System.Windows.Forms.Button btnStraight;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tBoxX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBoxY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tBoxZ;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLeftW;
        private System.Windows.Forms.Button btnRightW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRightR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLeftR;
        private System.Windows.Forms.Button btnLeftS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRightS;
        private System.Windows.Forms.Button btnRightP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLeftP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLeftE;
        private System.Windows.Forms.Button btnRightE;
        private System.Windows.Forms.Button btnRightT;
        private System.Windows.Forms.Button btnLeftT;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnOH;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TrackBar Jogspeed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbjspeed;
        private System.Windows.Forms.CheckBox chBoxOldData;
        private System.Windows.Forms.CheckBox chBoxUpdate;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private new System.Windows.Forms.Button Enter;
    }
}

