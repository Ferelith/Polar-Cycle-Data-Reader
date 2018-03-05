namespace Cyle_Data
{
    partial class CycleMainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cycleGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heartRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedalIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heartRateZonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerZonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ttttxt = new System.Windows.Forms.TextBox();
            this.trainingStressScoreLbl = new System.Windows.Forms.Label();
            this.intensityFactorLbl = new System.Windows.Forms.Label();
            this.normalisedPowerLbl = new System.Windows.Forms.Label();
            this.normalisedpowertxt = new System.Windows.Forms.TextBox();
            this.intensityfactortxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maximumAltitudetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.averageAltitudetxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maximumPowertxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.averagePowertxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.minimumHeartRatetxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maximumHeartRatetxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.averageHeartRatetxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maximumSpeedtxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.averageSpeedtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.totalDistancetxt = new System.Windows.Forms.TextBox();
            this.zgc = new ZedGraph.ZedGraphControl();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1354, 37);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 33);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cycleGraphToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.importToolStripMenuItem.Text = "Open File";
            // 
            // cycleGraphToolStripMenuItem
            // 
            this.cycleGraphToolStripMenuItem.Name = "cycleGraphToolStripMenuItem";
            this.cycleGraphToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.cycleGraphToolStripMenuItem.Text = "HRM File";
            this.cycleGraphToolStripMenuItem.Click += new System.EventHandler(this.cycleGraphToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(140, 34);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speedToolStripMenuItem,
            this.cadenceToolStripMenuItem,
            this.altitudeToolStripMenuItem,
            this.powerToolStripMenuItem,
            this.heartRateToolStripMenuItem,
            this.pedalIndexToolStripMenuItem,
            this.powerBalanceToolStripMenuItem,
            this.heartRateZonesToolStripMenuItem,
            this.powerZonesToolStripMenuItem,
            this.intervalsToolStripMenuItem});
            this.dataToolStripMenuItem.Enabled = false;
            this.dataToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(66, 33);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.Checked = true;
            this.speedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.speedToolStripMenuItem.Text = "Speed";
            this.speedToolStripMenuItem.Click += new System.EventHandler(this.speedToolStripMenuItem_Click);
            // 
            // cadenceToolStripMenuItem
            // 
            this.cadenceToolStripMenuItem.Checked = true;
            this.cadenceToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cadenceToolStripMenuItem.Name = "cadenceToolStripMenuItem";
            this.cadenceToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.cadenceToolStripMenuItem.Text = "Cadence";
            this.cadenceToolStripMenuItem.Click += new System.EventHandler(this.cadenceToolStripMenuItem_Click);
            // 
            // altitudeToolStripMenuItem
            // 
            this.altitudeToolStripMenuItem.Checked = true;
            this.altitudeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.altitudeToolStripMenuItem.Name = "altitudeToolStripMenuItem";
            this.altitudeToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.altitudeToolStripMenuItem.Text = "Altitude";
            this.altitudeToolStripMenuItem.Click += new System.EventHandler(this.altitudeToolStripMenuItem_Click);
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.Checked = true;
            this.powerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.powerToolStripMenuItem.Text = "Power";
            this.powerToolStripMenuItem.Click += new System.EventHandler(this.powerToolStripMenuItem_Click);
            // 
            // heartRateToolStripMenuItem
            // 
            this.heartRateToolStripMenuItem.Checked = true;
            this.heartRateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.heartRateToolStripMenuItem.Name = "heartRateToolStripMenuItem";
            this.heartRateToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.heartRateToolStripMenuItem.Text = "Heart Rate";
            this.heartRateToolStripMenuItem.Click += new System.EventHandler(this.heartRateToolStripMenuItem_Click);
            // 
            // pedalIndexToolStripMenuItem
            // 
            this.pedalIndexToolStripMenuItem.Checked = true;
            this.pedalIndexToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pedalIndexToolStripMenuItem.Name = "pedalIndexToolStripMenuItem";
            this.pedalIndexToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.pedalIndexToolStripMenuItem.Text = "Pedal Index";
            this.pedalIndexToolStripMenuItem.Click += new System.EventHandler(this.pedalIndexToolStripMenuItem_Click);
            // 
            // powerBalanceToolStripMenuItem
            // 
            this.powerBalanceToolStripMenuItem.Checked = true;
            this.powerBalanceToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.powerBalanceToolStripMenuItem.Name = "powerBalanceToolStripMenuItem";
            this.powerBalanceToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.powerBalanceToolStripMenuItem.Text = "Power Balance";
            this.powerBalanceToolStripMenuItem.Click += new System.EventHandler(this.powerBalanceToolStripMenuItem_Click);
            // 
            // heartRateZonesToolStripMenuItem
            // 
            this.heartRateZonesToolStripMenuItem.Name = "heartRateZonesToolStripMenuItem";
            this.heartRateZonesToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.heartRateZonesToolStripMenuItem.Text = "Heart Rate Zones";
            this.heartRateZonesToolStripMenuItem.Click += new System.EventHandler(this.heartRateZonesToolStripMenuItem_Click);
            // 
            // powerZonesToolStripMenuItem
            // 
            this.powerZonesToolStripMenuItem.Name = "powerZonesToolStripMenuItem";
            this.powerZonesToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.powerZonesToolStripMenuItem.Text = "Power Zones";
            this.powerZonesToolStripMenuItem.Click += new System.EventHandler(this.powerZonesToolStripMenuItem_Click);
            // 
            // intervalsToolStripMenuItem
            // 
            this.intervalsToolStripMenuItem.Name = "intervalsToolStripMenuItem";
            this.intervalsToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.intervalsToolStripMenuItem.Text = "Intervals (TEST)";
            this.intervalsToolStripMenuItem.Click += new System.EventHandler(this.intervalsToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pieToolStripMenuItem});
            this.chartToolStripMenuItem.Enabled = false;
            this.chartToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(73, 33);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // pieToolStripMenuItem
            // 
            this.pieToolStripMenuItem.Name = "pieToolStripMenuItem";
            this.pieToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.pieToolStripMenuItem.Text = "Pie Chart";
            this.pieToolStripMenuItem.Click += new System.EventHandler(this.pieToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Enabled = false;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(57, 33);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ttttxt);
            this.panel2.Controls.Add(this.trainingStressScoreLbl);
            this.panel2.Controls.Add(this.intensityFactorLbl);
            this.panel2.Controls.Add(this.normalisedPowerLbl);
            this.panel2.Controls.Add(this.normalisedpowertxt);
            this.panel2.Controls.Add(this.intensityfactortxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.maximumAltitudetxt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.averageAltitudetxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.maximumPowertxt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.averagePowertxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.minimumHeartRatetxt);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.maximumHeartRatetxt);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.averageHeartRatetxt);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.maximumSpeedtxt);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.averageSpeedtxt);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.totalDistancetxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1171, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 727);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // ttttxt
            // 
            this.ttttxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.ttttxt.Location = new System.Drawing.Point(13, 670);
            this.ttttxt.Name = "ttttxt";
            this.ttttxt.ReadOnly = true;
            this.ttttxt.Size = new System.Drawing.Size(148, 22);
            this.ttttxt.TabIndex = 62;
            this.ttttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trainingStressScoreLbl
            // 
            this.trainingStressScoreLbl.AutoSize = true;
            this.trainingStressScoreLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingStressScoreLbl.ForeColor = System.Drawing.Color.Black;
            this.trainingStressScoreLbl.Location = new System.Drawing.Point(10, 644);
            this.trainingStressScoreLbl.Name = "trainingStressScoreLbl";
            this.trainingStressScoreLbl.Size = new System.Drawing.Size(137, 20);
            this.trainingStressScoreLbl.TabIndex = 61;
            this.trainingStressScoreLbl.Text = "Training Stress Score";
            // 
            // intensityFactorLbl
            // 
            this.intensityFactorLbl.AutoSize = true;
            this.intensityFactorLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intensityFactorLbl.ForeColor = System.Drawing.Color.Black;
            this.intensityFactorLbl.Location = new System.Drawing.Point(30, 593);
            this.intensityFactorLbl.Name = "intensityFactorLbl";
            this.intensityFactorLbl.Size = new System.Drawing.Size(98, 20);
            this.intensityFactorLbl.TabIndex = 59;
            this.intensityFactorLbl.Text = "Intensity Factor";
            // 
            // normalisedPowerLbl
            // 
            this.normalisedPowerLbl.AutoSize = true;
            this.normalisedPowerLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalisedPowerLbl.ForeColor = System.Drawing.Color.Black;
            this.normalisedPowerLbl.Location = new System.Drawing.Point(24, 542);
            this.normalisedPowerLbl.Name = "normalisedPowerLbl";
            this.normalisedPowerLbl.Size = new System.Drawing.Size(119, 20);
            this.normalisedPowerLbl.TabIndex = 57;
            this.normalisedPowerLbl.Text = "Normalised Power";
            // 
            // normalisedpowertxt
            // 
            this.normalisedpowertxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalisedpowertxt.Location = new System.Drawing.Point(13, 568);
            this.normalisedpowertxt.Name = "normalisedpowertxt";
            this.normalisedpowertxt.ReadOnly = true;
            this.normalisedpowertxt.Size = new System.Drawing.Size(148, 22);
            this.normalisedpowertxt.TabIndex = 56;
            this.normalisedpowertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // intensityfactortxt
            // 
            this.intensityfactortxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intensityfactortxt.Location = new System.Drawing.Point(14, 619);
            this.intensityfactortxt.Name = "intensityfactortxt";
            this.intensityfactortxt.ReadOnly = true;
            this.intensityfactortxt.Size = new System.Drawing.Size(147, 22);
            this.intensityfactortxt.TabIndex = 58;
            this.intensityfactortxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Maximum Altitude";
            // 
            // maximumAltitudetxt
            // 
            this.maximumAltitudetxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumAltitudetxt.Location = new System.Drawing.Point(13, 517);
            this.maximumAltitudetxt.Name = "maximumAltitudetxt";
            this.maximumAltitudetxt.ReadOnly = true;
            this.maximumAltitudetxt.Size = new System.Drawing.Size(148, 22);
            this.maximumAltitudetxt.TabIndex = 54;
            this.maximumAltitudetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Average Alititude";
            // 
            // averageAltitudetxt
            // 
            this.averageAltitudetxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageAltitudetxt.Location = new System.Drawing.Point(13, 466);
            this.averageAltitudetxt.Name = "averageAltitudetxt";
            this.averageAltitudetxt.ReadOnly = true;
            this.averageAltitudetxt.Size = new System.Drawing.Size(148, 22);
            this.averageAltitudetxt.TabIndex = 52;
            this.averageAltitudetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Maximum Power";
            // 
            // maximumPowertxt
            // 
            this.maximumPowertxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumPowertxt.Location = new System.Drawing.Point(13, 415);
            this.maximumPowertxt.Name = "maximumPowertxt";
            this.maximumPowertxt.ReadOnly = true;
            this.maximumPowertxt.Size = new System.Drawing.Size(148, 22);
            this.maximumPowertxt.TabIndex = 50;
            this.maximumPowertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(30, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Average Power";
            // 
            // averagePowertxt
            // 
            this.averagePowertxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averagePowertxt.Location = new System.Drawing.Point(13, 364);
            this.averagePowertxt.Name = "averagePowertxt";
            this.averagePowertxt.ReadOnly = true;
            this.averagePowertxt.Size = new System.Drawing.Size(148, 22);
            this.averagePowertxt.TabIndex = 48;
            this.averagePowertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Minimum Heart Rate";
            // 
            // minimumHeartRatetxt
            // 
            this.minimumHeartRatetxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumHeartRatetxt.Location = new System.Drawing.Point(13, 282);
            this.minimumHeartRatetxt.Name = "minimumHeartRatetxt";
            this.minimumHeartRatetxt.ReadOnly = true;
            this.minimumHeartRatetxt.Size = new System.Drawing.Size(148, 22);
            this.minimumHeartRatetxt.TabIndex = 46;
            this.minimumHeartRatetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Maximum Heart Rate";
            // 
            // maximumHeartRatetxt
            // 
            this.maximumHeartRatetxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumHeartRatetxt.Location = new System.Drawing.Point(15, 231);
            this.maximumHeartRatetxt.Name = "maximumHeartRatetxt";
            this.maximumHeartRatetxt.ReadOnly = true;
            this.maximumHeartRatetxt.Size = new System.Drawing.Size(148, 22);
            this.maximumHeartRatetxt.TabIndex = 44;
            this.maximumHeartRatetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(16, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "Average Heart Rate";
            // 
            // averageHeartRatetxt
            // 
            this.averageHeartRatetxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageHeartRatetxt.Location = new System.Drawing.Point(13, 180);
            this.averageHeartRatetxt.Name = "averageHeartRatetxt";
            this.averageHeartRatetxt.ReadOnly = true;
            this.averageHeartRatetxt.Size = new System.Drawing.Size(148, 22);
            this.averageHeartRatetxt.TabIndex = 42;
            this.averageHeartRatetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(25, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 41;
            this.label12.Text = "Maximum Speed";
            // 
            // maximumSpeedtxt
            // 
            this.maximumSpeedtxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumSpeedtxt.Location = new System.Drawing.Point(15, 129);
            this.maximumSpeedtxt.Name = "maximumSpeedtxt";
            this.maximumSpeedtxt.ReadOnly = true;
            this.maximumSpeedtxt.Size = new System.Drawing.Size(148, 22);
            this.maximumSpeedtxt.TabIndex = 40;
            this.maximumSpeedtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(30, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Average Speed";
            // 
            // averageSpeedtxt
            // 
            this.averageSpeedtxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageSpeedtxt.Location = new System.Drawing.Point(15, 78);
            this.averageSpeedtxt.Name = "averageSpeedtxt";
            this.averageSpeedtxt.ReadOnly = true;
            this.averageSpeedtxt.Size = new System.Drawing.Size(148, 22);
            this.averageSpeedtxt.TabIndex = 38;
            this.averageSpeedtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(35, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Total Distance";
            // 
            // totalDistancetxt
            // 
            this.totalDistancetxt.Location = new System.Drawing.Point(15, 29);
            this.totalDistancetxt.Name = "totalDistancetxt";
            this.totalDistancetxt.ReadOnly = true;
            this.totalDistancetxt.Size = new System.Drawing.Size(148, 20);
            this.totalDistancetxt.TabIndex = 36;
            this.totalDistancetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zgc
            // 
            this.zgc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zgc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc.ForeColor = System.Drawing.Color.White;
            this.zgc.Location = new System.Drawing.Point(0, 0);
            this.zgc.Name = "zgc";
            this.zgc.ScrollGrace = 0D;
            this.zgc.ScrollMaxX = 0D;
            this.zgc.ScrollMaxY = 0D;
            this.zgc.ScrollMaxY2 = 0D;
            this.zgc.ScrollMinX = 0D;
            this.zgc.ScrollMinY = 0D;
            this.zgc.ScrollMinY2 = 0D;
            this.zgc.Size = new System.Drawing.Size(1171, 727);
            this.zgc.TabIndex = 11;
            this.zgc.UseExtendedPrintDialog = true;
            this.zgc.Visible = false;
            this.zgc.MouseDownEvent += new ZedGraph.ZedGraphControl.ZedMouseEventHandler(this.zgc_MouseDownEvent_1);
            this.zgc.MouseUpEvent += new ZedGraph.ZedGraphControl.ZedMouseEventHandler(this.zgc_MouseUpEvent_1);
            this.zgc.MouseMoveEvent += new ZedGraph.ZedGraphControl.ZedMouseEventHandler(this.zgc_MouseMoveEvent_1);
            this.zgc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.zgc_MouseDoubleClick_1);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.zgc);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 37);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1171, 727);
            this.panel8.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1120, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 29);
            this.button1.TabIndex = 67;
            this.button1.Text = "View Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CycleMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 764);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "CycleMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cycle Data Reader V1.2";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ttttxt;
        private System.Windows.Forms.Label trainingStressScoreLbl;
        private System.Windows.Forms.Label intensityFactorLbl;
        private System.Windows.Forms.Label normalisedPowerLbl;
        private System.Windows.Forms.TextBox normalisedpowertxt;
        private System.Windows.Forms.TextBox intensityfactortxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maximumAltitudetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox averageAltitudetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maximumPowertxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox averagePowertxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox minimumHeartRatetxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox maximumHeartRatetxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox averageHeartRatetxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox maximumSpeedtxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox averageSpeedtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox totalDistancetxt;
        private ZedGraph.ZedGraphControl zgc;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altitudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heartRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedalIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heartRateZonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerZonesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem intervalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pieToolStripMenuItem;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cycleGraphToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}



