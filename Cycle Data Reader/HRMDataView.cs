using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicForCycle;
using ZedGraph;

namespace Cyle_Data
{
    public partial class HRMDataView : Form
    {
        HRMFileReaderClass HRMdata = new HRMFileReaderClass();

        string fileName, Version, SMode, Date, StartTime, Length, Interval, speedUnit, distanceUnit;
        int totalRows, columnIndex;
        double speed;
        DateTime dateTime = new DateTime();
        FindLengthOfRide rideLength = new FindLengthOfRide();
        ProcessSMode sMode = new ProcessSMode();
        ProcessDate changeDate = new ProcessDate();
        public static string[] line;
        public HRMDataView(string path)
        {
            InitializeComponent();

            fileName = path;

            readData();
        }
        
        private void HRMDataView_Load(object sender, EventArgs e)
        {
            this.ControlBox = true; //Remove the control box, so the form can't be closed and only hidden.
        }
        public void InitialiseDataGrid()
        {
            dgvData.ColumnCount = 8;
            dgvData.ColumnHeadersVisible = true;

            dgvData.Columns[0].Name = "Date";
            dgvData.Columns[1].Name = "Time";
            dgvData.Columns[2].Name = "Heart Rate";
            dgvData.Columns[3].Name = "Speed (" + speedUnit + ")";
            dgvData.Columns[4].Name = "Cadence";
            dgvData.Columns[5].Name = "Altitude (" + distanceUnit + ")";
            dgvData.Columns[6].Name = "Power";
            dgvData.Columns[7].Name = "Power Balance";
        }

        public void setEuroUnits()
        {
            speedUnit = "km/h";
            distanceUnit = "km";
            InitialiseDataGrid();
        }

        public void setUSUnits()
        {
            speedUnit = "mph";
            distanceUnit = "miles";
            InitialiseDataGrid();
        }

        public void setNewValues(bool Euro)
        {
            double value, multiplier;

            if (Euro)
            {
                multiplier = 1.609344;
            }
            else
            {
                multiplier = 0.621371;
            }

            //change the speed value
            columnIndex = 3;
            foreach (DataGridViewRow dgvRow in dgvData.Rows)
            {
                value = (Convert.ToDouble(dgvRow.Cells[columnIndex].Value) * multiplier);
                value = Math.Round(value, 1);
                dgvRow.Cells[columnIndex].Value = value.ToString();
            }

            //change the altitude value
            columnIndex = 5;
            foreach (DataGridViewRow dgvRow in dgvData.Rows)
            {
                value = (Convert.ToDouble(dgvRow.Cells[columnIndex].Value) * multiplier);
                value = Math.Round(value, 1);
                dgvRow.Cells[columnIndex].Value = value.ToString();
            }
        }

        public void checkSMode() // To be completed fully after first demonstration
        {
            bool speedMode, cadMode, altMode, powerMode, balanceMode, indexMode, hrccMode, unitMode;

            speedMode = sMode.includeSpeed(SMode);              //Checks whether speed was recorded
            cadMode = sMode.includeCadence(SMode);              //Checks whether cadence was recorded
            altMode = sMode.includeAltitude(SMode);             //Checks whether altitude was recorded
            powerMode = sMode.includePower(SMode);              //Checks whether power was recorded
            balanceMode = sMode.includePowerBalance(SMode);     //Checks whether power balance was recorded
            indexMode = sMode.includePedallingIndex(SMode);     //Checks whether pedalling index was recorded
            hrccMode = sMode.readCC(SMode);                     //Checks whether cycling data was recorded or just HR Data
            unitMode = sMode.readUnit(SMode);                   //Checks which unit the rider recorded the data in

            if (unitMode)
            {
                setEuroUnits();
                checkBox1.Checked = true;
            }
            else
            {
                setUSUnits();
                checkBox1.Checked = false;
            }
        }

        private void dgvData_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int count = dgvData.SelectedRows.Count;
            string[] hr = new string[count];
            string[] sp = new string[count];
            string[] cd = new string[count];
            string[] al = new string[count];
            string[] po = new string[count];
            string[] pb = new string[count];

            int i = 0;
            foreach (DataGridViewRow row in dgvData.SelectedRows)
            {
                hr[i] = row.Cells[2].Value.ToString();
                sp[i] = row.Cells[3].Value.ToString();
                cd[i] = row.Cells[4].Value.ToString();
                al[i] = row.Cells[5].Value.ToString();
                po[i] = row.Cells[6].Value.ToString();
                pb[i] = row.Cells[7].Value.ToString();

                i++;
            }

            PointPairList hrPairList = new PointPairList();
            PointPairList spPairList = new PointPairList();
            PointPairList cdPairList = new PointPairList();
            PointPairList alPairList = new PointPairList();
            PointPairList poPairList = new PointPairList();

            for (int j = 0; j < count; j++)
            {
                hrPairList.Add(j, Double.Parse(hr[j]));
                spPairList.Add(j, Double.Parse(sp[j]));
                cdPairList.Add(j, Double.Parse(cd[j]));
                alPairList.Add(j, Double.Parse(al[j]));
                poPairList.Add(j, Double.Parse(po[j]));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool Euro;

            if (checkBox1.Checked)
            {
                Euro = true;
                setEuroUnits();
                setNewValues(Euro);
                getInfoFromData();
            }
            else
            {
                Euro = false;
                setUSUnits();
                setNewValues(Euro);
                getInfoFromData();
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void readData()
        {
            if (File.Exists(fileName))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string line, row, splitTime;
                        string[] sections, column, time;
                        int x;
                        int i = 0;
                        bool found = false;

                        while ((line = reader.ReadLine()) != null)
                        {
                            //Extract version from header
                            if (line.Contains("Version"))
                            {
                                sections = line.Split('=');
                                Version = sections[1];
                                txtVersion.Text = Version;
                            }

                            //Extract sMode from header
                            if (line.Contains("SMode"))
                            {
                                sections = line.Split('=');
                                SMode = sections[1];
                                txtSMode.Text = SMode;
                            }

                            //Extract date from header
                            if (line.Contains("Date"))
                            {
                                sections = line.Split('=');
                                Date = sections[1];
                                Date = changeDate.dateToUK(Date);
                                txtDate.Text = Date;
                            }

                            //Extract start time from header
                            if (line.Contains("StartTime"))
                            {
                                sections = line.Split('=');
                                StartTime = sections[1];
                                txtStartTime.Text = StartTime;
                            }

                            //Extract length from header
                            if (line.Contains("Length"))
                            {
                                sections = line.Split('=');
                                Length = sections[1];
                                txtLength.Text = Length;
                            }

                            //Extract start time from header
                            if (line.Contains("Interval"))
                            {
                                sections = line.Split('=');
                                Interval = sections[1];
                                txtInterval.Text = Interval;
                            }

                            if (found == true)
                            {
                                lboText.Items.Add(line);
                            }

                            //Split the data and the header
                            if (line == "[HRData]")
                            {
                                found = true;
                            }
                        }

                        dateTime = DateTime.Parse(StartTime);
                        splitTime = dateTime.ToString();
                        time = splitTime.Split(' ');

                        checkSMode();
                        totalRows = rideLength.findLengthInSeconds(Length);
                        totalRows = totalRows / Convert.ToInt16(Interval);
                        x = lboText.TopIndex;

                        for (i = 1; i <= totalRows; i++)
                        {
                            row = lboText.Items[x].ToString();
                            column = row.Split('\t');

                            speed = Convert.ToDouble(column[1]);
                            speed = speed / 10;
                            column[1] = speed.ToString();

                            dgvData.Rows.Add(Date, time[1], column[0], column[1], column[2], column[3], column[4], column[5]);
                            x++;
                            dateTime = dateTime.AddSeconds(Convert.ToDouble(Interval));
                            splitTime = dateTime.ToString();
                            time = splitTime.Split(' ');
                        }

                        getInfoFromData();
                       // lblFileName.Text = fileName;
                        txtNoRows.Text = totalRows.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        public double distanceTravelled()
        {
            double distanceSum = 0;
            columnIndex = 3;

            foreach (DataGridViewRow dgvRow in dgvData.Rows)
            {
                distanceSum += Convert.ToDouble(dgvRow.Cells[columnIndex].Value);
            }

            distanceSum = distanceSum / 3600;
            distanceSum = Math.Round(distanceSum, 1);

            return distanceSum;
        }

        public double findAverage(int columnIndex)
        {
            double average, sum = 0;

            foreach (DataGridViewRow dgvRow in dgvData.Rows)
            {
                sum += Convert.ToDouble(dgvRow.Cells[columnIndex].Value);
            }

            average = sum / totalRows;
            average = Math.Round(average, 0);

            return average;
        }

        public double findMax(int columnIndex)
        {
            double maximum = dgvData.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToDouble(r.Cells[columnIndex].Value));

            return maximum;
        }

        public int minHR()
        {
            string heartRate = string.Empty;
            columnIndex = 2;
            int minHR = dgvData.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt16(r.Cells[columnIndex].Value));

            foreach (DataGridViewRow dgvRow in dgvData.Rows)
            {
                heartRate = (string)dgvRow.Cells[columnIndex].Value;
                if (Convert.ToInt16(heartRate) < minHR && Convert.ToInt16(heartRate) != 0)
                {
                    minHR = Convert.ToInt16(heartRate);
                }
            }

            return minHR;
        }

        private void chooseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*selectFile();
            dgvData.Rows.Clear();
            readData();*/
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void getInfoFromData()
        {
            //Distance
            double distanceSum = distanceTravelled();
            txtDistance.Text = distanceSum.ToString() + " " + distanceUnit;
            //Speed
            columnIndex = 3;
            double averageSpeed = findAverage(columnIndex);
            double maxSpeed = findMax(columnIndex);
            txtAvSpeed.Text = averageSpeed.ToString() + " " + speedUnit;
            txtMaxSpeed.Text = maxSpeed.ToString() + " " + speedUnit;
            //Heart rate
            columnIndex = 2;
            double averageHR = findAverage(columnIndex);
            double maxHR = findMax(columnIndex);
            int minimumHR = minHR();
            txtAvHR.Text = averageHR.ToString() + " bpm";
            txtMaxHR.Text = maxHR.ToString() + " bpm";
            txtMinHR.Text = minimumHR.ToString() + " bpm";
            //Power
            columnIndex = 6;
            double averagePower = findAverage(columnIndex);
            double maxPower = findMax(columnIndex);
            txtAvPower.Text = averagePower.ToString() + " W";
            txtMaxPower.Text = maxPower.ToString() + " W";
            //Altitude
            columnIndex = 5;
            double averageAlt = findAverage(columnIndex);
            double maxAlt = findMax(columnIndex);
            txtAvAlt.Text = averageAlt.ToString() + " " + distanceUnit;
            txtMaxAlt.Text = maxAlt.ToString() + " " + distanceUnit;
        }

        private void rBtnEuro_CheckedChanged(object sender, EventArgs e)
        {
           
        }

    }

    public class FindLengthOfRide
    {
        public int findLengthInSeconds(string lengthOfTime)
        {
            int lengthInSeconds, hrs, min, sec;
            double extendedSec;
            string[] split;

            split = lengthOfTime.Split(':');

            hrs = Convert.ToInt16(split[0]);
            min = Convert.ToInt16(split[1]);
            extendedSec = Convert.ToDouble(split[2]);
            sec = (int)Math.Round(extendedSec);

            hrs = hrs * 3600;
            min = min * 60;

            lengthInSeconds = hrs + min + sec;

            return lengthInSeconds;
        }
    }

    public class ProcessSMode //read SMode string to find out configuration
    {
        public bool includeSpeed(string sMode) //Check if speed was recorded during the ride
        {
            bool sSpeed;
            string mode = sMode.Substring(0, 1);

            if (mode == "0")                  //If 0 speed wasn't recorded
            {
                sSpeed = false;
            }
            else                             //If 1 speed was recorded
            {
                sSpeed = true;
            }

            return sSpeed;
        }

        public bool includeCadence(string sMode) //Check if cadence was recorded during the ride
        {
            bool sCad;
            string mode = sMode.Substring(1, 1);

            if (mode == "0")                  //If 0 cadence wasn't recorded
            {
                sCad = false;
            }
            else                             //If 1 cadence was recorded
            {
                sCad = true;
            }

            return sCad;
        }

        public bool includeAltitude(string sMode) //Check if altitude was recorded during the ride
        {
            bool sAlt;
            string mode = sMode.Substring(2, 1);

            if (mode == "0")                  //If 0 altitude wasn't recorded
            {
                sAlt = false;
            }
            else                             //If 1 altitude was recorded
            {
                sAlt = true;
            }

            return sAlt;
        }

        public bool includePower(string sMode) //Check if power was recorded during the ride
        {
            bool sPower;
            string mode = sMode.Substring(3, 1);

            if (mode == "0")                  //If 0 power wasn't recorded
            {
                sPower = false;
            }
            else                             //If 1 power was recorded
            {
                sPower = true;
            }

            return sPower;
        }

        public bool includePowerBalance(string sMode) //Check if power balance was recorded during the ride
        {
            bool sPB;
            string mode = sMode.Substring(4, 1);

            if (mode == "0")                  //If 0 power balance wasn't recorded
            {
                sPB = false;
            }
            else                             //If 1 power balance was recorded
            {
                sPB = true;
            }

            return sPB;
        }

        public bool includePedallingIndex(string sMode) //Check if pedalling index was recorded during the ride
        {
            bool sPI;
            string mode = sMode.Substring(5, 1);

            if (mode == "0")                  //If 0 pedalling index wasn't recorded
            {
                sPI = false;
            }
            else                             //If 1 pedalling index was recorded
            {
                sPI = true;
            }

            return sPI;
        }

        public bool readCC(string sMode) //Check if HR Data orHR and cycling data was recorded during the ride
        {
            bool sHRCC;
            string mode = sMode.Substring(6, 1);

            if (mode == "0")                  //If 0 HR Data only
            {
                sHRCC = false;
            }
            else                             //If 1 HR and cycling data
            {
                sHRCC = true;
            }

            return sHRCC;
        }

        public bool readUnit(string sMode) //Find units used to record data while on ride
        {
            bool unit;
            string unitsUsed = sMode.Substring(7, 1);

            if (unitsUsed == "0")              //If 0 Euro units
            {
                unit = true;
            }
            else                              //If 1 US units
            {
                unit = false;
            }

            return unit;
        }
    }

    public class ProcessDate
    {
        public string dateToUK(string date) //set date to UK standard
        {
            string year, month, day, newDate;

            year = date.Substring(0, 4);
            month = date.Substring(4, 2);
            day = date.Substring(6, 2);

            newDate = day + "/" + month + "/" + year;

            return newDate;
        }
    }

}
