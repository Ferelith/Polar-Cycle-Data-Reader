namespace Cyle_Data
{
    partial class HRMDataView
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lboText = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtSMode = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rightPanelTitleLbl = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoRows = new System.Windows.Forms.TextBox();
            this.txtMaxSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxAlt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxHR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAvPower = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtMinHR = new System.Windows.Forms.TextBox();
            this.txtAvAlt = new System.Windows.Forms.TextBox();
            this.txtAvHR = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtMaxPower = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtAvSpeed = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 43;
            this.dgvData.Size = new System.Drawing.Size(1131, 546);
            this.dgvData.TabIndex = 57;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellMouseLeave);
            // 
            // lboText
            // 
            this.lboText.FormattingEnabled = true;
            this.lboText.Location = new System.Drawing.Point(12, 333);
            this.lboText.Name = "lboText";
            this.lboText.Size = new System.Drawing.Size(10, 4);
            this.lboText.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtDate);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.txtStartTime);
            this.panel3.Controls.Add(this.txtVersion);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.txtLength);
            this.panel3.Controls.Add(this.txtSMode);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.txtInterval);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1291, 33);
            this.panel3.TabIndex = 90;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(352, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 23);
            this.label18.TabIndex = 49;
            this.label18.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(421, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(72, 20);
            this.txtDate.TabIndex = 50;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(499, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 23);
            this.label20.TabIndex = 51;
            this.label20.Text = "Start Time:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(626, 6);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(72, 20);
            this.txtStartTime.TabIndex = 52;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(105, 6);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(72, 20);
            this.txtVersion.TabIndex = 61;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(704, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 23);
            this.label21.TabIndex = 53;
            this.label21.Text = "Length:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(6, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 23);
            this.label22.TabIndex = 60;
            this.label22.Text = "Version:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(796, 7);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(72, 20);
            this.txtLength.TabIndex = 54;
            // 
            // txtSMode
            // 
            this.txtSMode.Location = new System.Drawing.Point(274, 5);
            this.txtSMode.Name = "txtSMode";
            this.txtSMode.Size = new System.Drawing.Size(72, 20);
            this.txtSMode.TabIndex = 59;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(874, 5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 23);
            this.label23.TabIndex = 55;
            this.label23.Text = "Interval:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(179, 4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 23);
            this.label24.TabIndex = 58;
            this.label24.Text = "S Mode:";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(976, 7);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(72, 20);
            this.txtInterval.TabIndex = 56;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.txtDistance);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtNoRows);
            this.panel5.Controls.Add(this.txtMaxSpeed);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtMaxAlt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtMaxHR);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtAvPower);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.txtMinHR);
            this.panel5.Controls.Add(this.txtAvAlt);
            this.panel5.Controls.Add(this.txtAvHR);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.txtMaxPower);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.txtAvSpeed);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 546);
            this.panel5.TabIndex = 92;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.rightPanelTitleLbl);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 37);
            this.panel6.TabIndex = 92;
            // 
            // rightPanelTitleLbl
            // 
            this.rightPanelTitleLbl.AutoSize = true;
            this.rightPanelTitleLbl.BackColor = System.Drawing.Color.White;
            this.rightPanelTitleLbl.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPanelTitleLbl.ForeColor = System.Drawing.Color.Black;
            this.rightPanelTitleLbl.Location = new System.Drawing.Point(10, 3);
            this.rightPanelTitleLbl.Name = "rightPanelTitleLbl";
            this.rightPanelTitleLbl.Size = new System.Drawing.Size(104, 29);
            this.rightPanelTitleLbl.TabIndex = 24;
            this.rightPanelTitleLbl.Text = "Summary";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(22, 63);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(121, 20);
            this.txtDistance.TabIndex = 72;
            this.txtDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Max Speed:";
            // 
            // txtNoRows
            // 
            this.txtNoRows.Location = new System.Drawing.Point(32, 503);
            this.txtNoRows.Name = "txtNoRows";
            this.txtNoRows.Size = new System.Drawing.Size(115, 20);
            this.txtNoRows.TabIndex = 87;
            this.txtNoRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.Location = new System.Drawing.Point(24, 240);
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Size = new System.Drawing.Size(121, 20);
            this.txtMaxSpeed.TabIndex = 74;
            this.txtMaxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "No. of Rows:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Max Heart Rate:";
            // 
            // txtMaxAlt
            // 
            this.txtMaxAlt.Location = new System.Drawing.Point(26, 415);
            this.txtMaxAlt.Name = "txtMaxAlt";
            this.txtMaxAlt.Size = new System.Drawing.Size(121, 20);
            this.txtMaxAlt.TabIndex = 70;
            this.txtMaxAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "Av. Power:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Distance:";
            // 
            // txtMaxHR
            // 
            this.txtMaxHR.Location = new System.Drawing.Point(23, 195);
            this.txtMaxHR.Name = "txtMaxHR";
            this.txtMaxHR.Size = new System.Drawing.Size(121, 20);
            this.txtMaxHR.TabIndex = 76;
            this.txtMaxHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Av. Heart Rate:";
            // 
            // txtAvPower
            // 
            this.txtAvPower.Location = new System.Drawing.Point(24, 371);
            this.txtAvPower.Name = "txtAvPower";
            this.txtAvPower.Size = new System.Drawing.Size(121, 20);
            this.txtAvPower.TabIndex = 78;
            this.txtAvPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(32, 394);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 20);
            this.label25.TabIndex = 69;
            this.label25.Text = "Max Altitude:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(35, 263);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 20);
            this.label26.TabIndex = 83;
            this.label26.Text = "Av. Speed:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(18, 130);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 20);
            this.label27.TabIndex = 65;
            this.label27.Text = "Min Heart Rate:";
            // 
            // txtMinHR
            // 
            this.txtMinHR.Location = new System.Drawing.Point(23, 151);
            this.txtMinHR.Name = "txtMinHR";
            this.txtMinHR.Size = new System.Drawing.Size(121, 20);
            this.txtMinHR.TabIndex = 66;
            this.txtMinHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAvAlt
            // 
            this.txtAvAlt.Location = new System.Drawing.Point(27, 459);
            this.txtAvAlt.Name = "txtAvAlt";
            this.txtAvAlt.Size = new System.Drawing.Size(121, 20);
            this.txtAvAlt.TabIndex = 80;
            this.txtAvAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAvHR
            // 
            this.txtAvHR.Location = new System.Drawing.Point(23, 107);
            this.txtAvHR.Name = "txtAvHR";
            this.txtAvHR.Size = new System.Drawing.Size(121, 20);
            this.txtAvHR.TabIndex = 82;
            this.txtAvHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(35, 307);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 20);
            this.label28.TabIndex = 67;
            this.label28.Text = "Max Power:";
            // 
            // txtMaxPower
            // 
            this.txtMaxPower.Location = new System.Drawing.Point(23, 328);
            this.txtMaxPower.Name = "txtMaxPower";
            this.txtMaxPower.Size = new System.Drawing.Size(121, 20);
            this.txtMaxPower.TabIndex = 68;
            this.txtMaxPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.White;
            this.label29.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(35, 438);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 20);
            this.label29.TabIndex = 79;
            this.label29.Text = "Av. Altitude:";
            // 
            // txtAvSpeed
            // 
            this.txtAvSpeed.Location = new System.Drawing.Point(24, 284);
            this.txtAvSpeed.Name = "txtAvSpeed";
            this.txtAvSpeed.Size = new System.Drawing.Size(121, 20);
            this.txtAvSpeed.TabIndex = 84;
            this.txtAvSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(160, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1131, 546);
            this.panel2.TabIndex = 93;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvData);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1131, 546);
            this.panel4.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1164, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1066, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 63;
            this.checkBox1.Text = "Miles / KM";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // HRMDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lboText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "HRMDataView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRMDataView";
            this.Load += new System.EventHandler(this.HRMDataView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ListBox lboText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtSMode;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label rightPanelTitleLbl;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNoRows;
        private System.Windows.Forms.TextBox txtMaxSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxAlt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxHR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAvPower;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtMinHR;
        private System.Windows.Forms.TextBox txtAvAlt;
        private System.Windows.Forms.TextBox txtAvHR;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtMaxPower;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtAvSpeed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}