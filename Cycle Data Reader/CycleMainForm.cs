// CREATED BY ARTUR PARTYKA C3469557 LEEDS BECKETT UNIVERSITY 2018
// CYCLE DATA READER PROGRAM FOR READING HRM DATA FILES AND DISPLAYING RESULTS IN A GRAPH AND DETAIL WINDOW

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using LogicForCycle;
using System.Threading;

namespace Cyle_Data
{
    public partial class CycleMainForm : Form
    {
        // instance of Cycle Form
        public static CycleMainForm instance = new CycleMainForm();

        // ZGraph Class
        ZedClass zgraph;

        private string path;

        // Objects and Collection for HRM files
        private HRMFileReaderClass HRMdata;
        private HRMObjectCollectionClass hrmObjectCollection;
        private HRMObjectClass powerbalance;
        private HRMObjectClass pedallingIndex;
        private HRMObjectClass heartRate;
        private HRMObjectClass altitude;
        private HRMObjectClass cadence;
        private HRMObjectSpeedClass speed;
        private HRMObjectPowerClass power;

        // Auto-detect Interval Settings
        public bool intervals_enabled = false;
        public List<int[]> interval;
        public int intervalIndex = -1;
        public int threshold = 170;
        public int tolerance = 150;
        public int least_interval_size = 5;
        public int end_peak_value_minus_tolerance_start = 2200;
        public int end_peak_value_minus_tolerance_end = 3979;

        // Drag Interval Line Variables
        int intervalIndex1 = 0, intervalIndex2 = 0;
        private bool mouseDragged = false;
        LineItem intervalLine;

        // Manual Interval Lines
        public List<int[]> manualintervalList;
        int[] manualInterval;
        double manualIntervalStart = -1;
        double manualIntervalEnd = -1;

        // User (Default)
        public double ftp = 320.0;
        public double mhr = 0.0;

        public CycleMainForm()
        {
           
            InitializeComponent();
 
        }


        //Menu Buttons
        private void dataReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HRMDataView hf = new HRMDataView(path);
            hf.MdiParent = this;
            hf.Show();
            zgc.Visible = false;
            panel2.Visible = false;
        }

        private void cycleGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importHRMData();
            
        }
        // Toggle Data displayed on Zedgraph by Removing or Adding HRMObjects to/from HRM Object Collection ...

        private void speedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && speedToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                speedToolStripMenuItem.Checked = !speedToolStripMenuItem.Checked;

                if (speedToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(speed);
                else
                    hrmObjectCollection.remove(speed);

                plot("linegraph");
            }
        }

        private void cadenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && cadenceToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                cadenceToolStripMenuItem.Checked = !cadenceToolStripMenuItem.Checked;

                if (cadenceToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(cadence);
                else
                    hrmObjectCollection.remove(cadence);

                plot("linegraph");
            }
        }

        private void altitudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && altitudeToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                altitudeToolStripMenuItem.Checked = !altitudeToolStripMenuItem.Checked;

                if (altitudeToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(altitude);
                else
                    hrmObjectCollection.remove(altitude);

                plot("linegraph");
            }
        }

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && powerToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                powerToolStripMenuItem.Checked = !powerToolStripMenuItem.Checked;

                if (powerToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(power);
                else
                    hrmObjectCollection.remove(power);

                plot("linegraph");
            }
        }

        private void heartRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && heartRateToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                heartRateToolStripMenuItem.Checked = !heartRateToolStripMenuItem.Checked;

                if (heartRateToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(heartRate);
                else
                    hrmObjectCollection.remove(heartRate);

                plot("linegraph");
            }
        }

        private void pedalIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && pedalIndexToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                pedalIndexToolStripMenuItem.Checked = !pedalIndexToolStripMenuItem.Checked;

                if (pedalIndexToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(pedallingIndex);
                else
                    hrmObjectCollection.remove(pedallingIndex);

                plot("linegraph");
            }
        }

        private void powerBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && powerBalanceToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                powerBalanceToolStripMenuItem.Checked = !powerBalanceToolStripMenuItem.Checked;

                if (powerBalanceToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(powerbalance);
                else
                    hrmObjectCollection.remove(powerbalance);

                plot("linegraph");
            }
        }

        // Toggle Heart Rate Zones
        private void heartRateZonesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            heartRateZonesToolStripMenuItem.Checked = !heartRateZonesToolStripMenuItem.Checked;
            if (heartRateZonesToolStripMenuItem.Checked == true) powerZonesToolStripMenuItem.Checked = false;
            plot("linegraph");
        }

        // Toggle Power Zones
        private void powerZonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            powerZonesToolStripMenuItem.Checked = !powerZonesToolStripMenuItem.Checked;
            if (powerZonesToolStripMenuItem.Checked == true) heartRateZonesToolStripMenuItem.Checked = false;
            plot("linegraph");
        }

        // Toggle Interval Detection Feedback on Zedgraph
        private void intervalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intervals_enabled = !intervals_enabled;

            if (intervals_enabled == true)
                intervalsToolStripMenuItem.Checked = true;
            else
                intervalsToolStripMenuItem.Checked = false;

            plot("linegraph");
            populateRightPanel();
        }

        // Toggle Graph Type
        private void pieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pieToolStripMenuItem.Text == "Pie Chart")
            {
                dataToolStripMenuItem.Enabled = false;
                plot("piechart");
                pieToolStripMenuItem.Text = "Line Graph";
            }
            else if (pieToolStripMenuItem.Text == "Line Graph")
            {
                dataToolStripMenuItem.Enabled = true;
                plot("linegraph");
                pieToolStripMenuItem.Text = "Pie Chart";
            }
        }

        //Exit from the Application
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            intervalIndex--;

            if (intervalIndex <= -1) intervalIndex = interval.Count;

            if (intervalIndex == interval.Count)
            {
                metrics(true);
                populateRightPanel();
            }
            else
            {
                metrics(false);
                populateRightPanel();
            }
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            intervalIndex++;

            if (intervalIndex >= interval.Count)
            {
                metrics(true);
                populateRightPanel();
                intervalIndex = -1;
            }
            else
            {
                metrics(false);
                populateRightPanel();
            }
        }

        //Exit from the Application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //ENd of the Toogle Menu Button //



        public void importHRMData(string[] line = null)
        {

            // Clear All Previous HRM Data and Reset Toggled Data
            if (hrmObjectCollection != null) hrmObjectCollection.clear();
            powerToolStripMenuItem.Checked = true;
            pedalIndexToolStripMenuItem.Checked = true;
            powerBalanceToolStripMenuItem.Checked = true;
            speedToolStripMenuItem.Checked = true;
            cadenceToolStripMenuItem.Checked = true;
            altitudeToolStripMenuItem.Checked = true;
            heartRateToolStripMenuItem.Checked = true;


            // Load and Parse HRM Data 
            HRMdata = new HRMFileReaderClass();

            if (line == null)
            {
                path = HRMdata.get_fileName();
                line = HRMdata.open_specific_file(path);
            }
            HRMdata.read_file(line);
       

            // Create HRM Objects From HRMdata
            powerbalance = new HRMObjectClass("Power Balance (%)", HRMdata.LRBalanceLeftLeg, Color.Sienna);
            speed = new HRMObjectSpeedClass("Speed (" + HRMdata.SpeedMeasurementUnit + ")", HRMdata.Speed, Color.Red);
            pedallingIndex = new HRMObjectClass("Pedal Index (%)", HRMdata.PedallingIndex, Color.Peru);
            heartRate = new HRMObjectClass("Heart Rate (bpm)", HRMdata.HeartRate, Color.Orange);
            power = new HRMObjectPowerClass("Power (watts)", HRMdata.Power, Color.Violet);
            altitude = new HRMObjectClass("Altitude (ft)", HRMdata.Altitude, Color.Green);
            cadence = new HRMObjectClass("Cadence (rpm)", HRMdata.Cadence, Color.Blue);

            // Add HRM Objects to HRMObjectCollection
            hrmObjectCollection = new HRMObjectCollectionClass();
            hrmObjectCollection.add(speed);
            hrmObjectCollection.add(cadence);
            hrmObjectCollection.add(altitude);
            hrmObjectCollection.add(power);
            hrmObjectCollection.add(pedallingIndex);
            hrmObjectCollection.add(powerbalance);
            hrmObjectCollection.add(heartRate);

            // Populate Right Panel with Summary for Whole Data Read / Interval Read
            populateRightPanel();

            // Plot Zedgraph
            plot("linegraph");

            // Show ZGraphControl (displays zedgraph chart area)
            this.zgc.Visible = true;
            this.panel2.Visible = true;

            // Enable Menus
            dataToolStripMenuItem.Enabled = true;
            chartToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;

            // Set Default Max Heart Rate (MHR) from HRM Data
            mhr = heartRate.calcMax();
        }


        // Populate Right Panel with Summary for Whole Data Read / Interval Read
        public void populateRightPanel()
        {
            // Show Summary Panel at Start and End of Interval List
         

            // Methods are called from HRMObject Class
            normalisedpowertxt.Text = power.calcNormalisedPower(interval, intervals_enabled) + " watts";
            intensityfactortxt.Text = power.calcIntensityFactor(interval, intervals_enabled, ftp) + "%";
            ttttxt.Text = power.calcTSS(interval, intervals_enabled, ftp, HRMdata.Frequency).ToString();
            totalDistancetxt.Text = speed.calcDistance(interval, intervals_enabled, intervalIndex, HRMdata.Frequency) + " " + HRMdata.DistanceMeasurementUnit;
            averageSpeedtxt.Text = speed.calcAvg(interval, intervals_enabled, intervalIndex) + " " + HRMdata.SpeedMeasurementUnit;
            maximumSpeedtxt.Text = speed.calcMax(interval, intervals_enabled, intervalIndex) + " " + HRMdata.SpeedMeasurementUnit;
            averageHeartRatetxt.Text = heartRate.calcAvg(interval, intervals_enabled, intervalIndex) + " bpm";
            maximumHeartRatetxt.Text = heartRate.calcMax(interval, intervals_enabled, intervalIndex) + " bpm";
            minimumHeartRatetxt.Text = heartRate.calcMin(interval, intervals_enabled, intervalIndex) + " bpm";
            averagePowertxt.Text = power.calcAvg(interval, intervals_enabled, intervalIndex) + " watts";
            maximumPowertxt.Text = power.calcMax(interval, intervals_enabled, intervalIndex) + " watts";
            averageAltitudetxt.Text = altitude.calcAvg(interval, intervals_enabled, intervalIndex) + " ft";
            maximumAltitudetxt.Text = altitude.calcMax(interval, intervals_enabled, intervalIndex) + " ft";
        }




        public void plot(string chartType)
        {
            // ZGraph using HRMData for X-Axis values
            zgraph = new ZedClass(this.zgc, HRMdata.StartDateTime, HRMdata.DurationSeconds);

            if (chartType == "linegraph")
            {
                // Plot x,y data (with or without intervals)
                // Currently uses Power HRMObject to detect intervals
                // Could be changed to use any HRMObject
                if (intervals_enabled == false)
                {
                    zgraph.plotLineGraph(this.zgc, hrmObjectCollection, HRMdata.Frequency);

                    // Set Right Panel to Summary
                    intervalIndex = -1;

                    // Hide L/R Buttons
                    panelButtons(false);
                }
                else
                {
                    if (manualintervalList == null)
                    {
                        if (interval == null) interval = power.createIntervals(threshold, tolerance, least_interval_size, end_peak_value_minus_tolerance_start, end_peak_value_minus_tolerance_end);
                    }
                    else interval = manualintervalList;
                    zgraph.plotLineGraph(this.zgc, hrmObjectCollection, HRMdata.Frequency, interval);

                    // Show L/R Buttons
                    panelButtons(true);
                }

                // Create Zgraph Bands for Power and Heart Rate HRMObjects
                zgraph.clearZonesForLineGraph(this.zgc);
                if (heartRateZonesToolStripMenuItem.Checked == true) zgraph.createZonesForLineGraph(zgc, "Heart Rate", mhr);
                if (powerZonesToolStripMenuItem.Checked == true) zgraph.createZonesForLineGraph(zgc, "Power", ftp);
            }
            else if (chartType == "piechart")
            {
                zgraph.plotPieChart(this.zgc, powerbalance);
            }
        }



        // Toggle Metric Display (NP, IF, TSS)
        private void metrics(bool display)
        {
            normalisedpowertxt.Visible = display;
            normalisedPowerLbl.Visible = display;
            intensityfactortxt.Visible = display;
            intensityFactorLbl.Visible = display;
            ttttxt.Visible = display;
            trainingStressScoreLbl.Visible = display;
        }
        // Add Interval Manual Double Click Event   
        private void zgc_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (manualintervalList == null) manualintervalList = new List<int[]>();

            if (manualIntervalStart < 0)
            {
                manualIntervalStart = zgraph.ConvertPointToHRMObjectIndex(zgraph.createIntervals(zgc, e, power), HRMdata.Frequency);
            }
            else if (manualIntervalEnd < 0)
            {
                manualIntervalEnd = zgraph.ConvertPointToHRMObjectIndex(zgraph.createIntervals(zgc, e, power), HRMdata.Frequency);
                manualInterval = new int[2] { (int)manualIntervalStart, (int)manualIntervalEnd };
                manualIntervalStart = -1;
                manualIntervalEnd = -1;
                manualintervalList.Add(manualInterval);
                intervals_enabled = true;
                intervalsToolStripMenuItem.Checked = true;
                interval = null;
                plot("linegraph");
                populateRightPanel();
                panelButtons(true);
            }
        }


        // Mouse Events for Moving Interval Lines ...
        private bool zgc_MouseDownEvent_1(ZedGraphControl sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && ModifierKeys.HasFlag(Keys.Control))
            {
                GraphPane pane = zgc.GraphPane;

                object nearestObject;
                int index;

                pane.FindNearestObject(new PointF(e.X, e.Y), this.CreateGraphics(), out nearestObject, out index);

                if (nearestObject != null && nearestObject.GetType() == typeof(LineItem))
                {
                    intervalLine = (LineItem)nearestObject;

                    int hrmObjectIndex = zgraph.ConvertPointToHRMObjectIndex(intervalLine, HRMdata.Frequency);
                    int tempValue = hrmObjectIndex;
                    int oldDiff = int.MaxValue, newDiff = 0;

                    for (int i = 0; i < interval.Count; i++)
                    {
                        for (int j = 0; j < interval[i].Count(); j++)
                        {
                            newDiff = hrmObjectIndex - interval[i][j];

                            if (newDiff < oldDiff && newDiff > 0)
                            {
                                intervalIndex1 = i;
                                intervalIndex2 = j;
                                oldDiff = newDiff;
                            }
                        }
                    }
                    mouseDragged = true;
                }
            }
            return default(bool);
        }

        private bool zgc_MouseMoveEvent_1(ZedGraphControl sender, MouseEventArgs e)
        {
            if (mouseDragged == true)
            {
                GraphPane pane = zgc.GraphPane;

                // x & y variables to store the axis values
                double xVal;
                double yVal;

                pane.ReverseTransform(e.Location, out xVal, out yVal);

                // Move line to New X Value
                intervalLine.Points[0].X = xVal;
                intervalLine.Points[1].X = xVal;

                zgc.Invalidate();
            }

            return default(bool);
        }

        private bool zgc_MouseUpEvent_1(ZedGraphControl sender, MouseEventArgs e)
        {
            if (mouseDragged == true)
            {
                interval[intervalIndex1][intervalIndex2] = zgraph.ConvertPointToHRMObjectIndex(intervalLine, HRMdata.Frequency);
                populateRightPanel();
                mouseDragged = false;
            }

            return default(bool);
        }
        private void btnHRMDataView_Click(object sender, EventArgs e)
        {
            HRMDataView hdv = new HRMDataView(path);
            hdv.ShowDialog();
        }

        private void chkspeed_CheckedChanged(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && speedToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                speedToolStripMenuItem.Checked = !speedToolStripMenuItem.Checked;

                if (speedToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(speed);
                else
                    hrmObjectCollection.remove(speed);

                plot("linegraph");
            }
        }

        private void chkheartrate_CheckedChanged(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && heartRateToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                heartRateToolStripMenuItem.Checked = !heartRateToolStripMenuItem.Checked;

                if (heartRateToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(heartRate);
                else
                    hrmObjectCollection.remove(heartRate);

                plot("linegraph");
            }
        }

        private void chkaltitude_CheckedChanged(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && altitudeToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                altitudeToolStripMenuItem.Checked = !altitudeToolStripMenuItem.Checked;

                if (altitudeToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(altitude);
                else
                    hrmObjectCollection.remove(altitude);

                plot("linegraph");
            }
        }

        private void chkcadence_CheckedChanged(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && cadenceToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                cadenceToolStripMenuItem.Checked = !cadenceToolStripMenuItem.Checked;

                if (cadenceToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(cadence);
                else
                    hrmObjectCollection.remove(cadence);

                plot("linegraph");
            }
        }

        private void chkpower_CheckedChanged(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && powerToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                powerToolStripMenuItem.Checked = !powerToolStripMenuItem.Checked;

                if (powerToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(power);
                else
                    hrmObjectCollection.remove(power);

                plot("linegraph");
            }
        }

        private void chkPedalIndex_CheckedChanged(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && pedalIndexToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                pedalIndexToolStripMenuItem.Checked = !pedalIndexToolStripMenuItem.Checked;

                if (pedalIndexToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(pedallingIndex);
                else
                    hrmObjectCollection.remove(pedallingIndex);

                plot("linegraph");
            }
        }

        private void chkpowerbalance_CheckedChanged(object sender, EventArgs e)
        {
            if (hrmObjectCollection.getCount() == 1 && powerBalanceToolStripMenuItem.Checked == true)
                MessageBox.Show("Dataset cannot be empty");
            else
            {
                powerBalanceToolStripMenuItem.Checked = !powerBalanceToolStripMenuItem.Checked;

                if (powerBalanceToolStripMenuItem.Checked == true)
                    hrmObjectCollection.add(powerbalance);
                else
                    hrmObjectCollection.remove(powerbalance);

                plot("linegraph");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HRMDataView hdv = new HRMDataView(path);
            hdv.ShowDialog();
        }

        //End of mouse events


        // Toggle Panel Navigation
        private void panelButtons(bool display)
        {
            
        }
    }
}
