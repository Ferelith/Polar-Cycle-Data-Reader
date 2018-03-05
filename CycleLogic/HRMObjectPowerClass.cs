using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicForCycle
{
   public class HRMObjectPowerClass : HRMObjectClass
    {
        public HRMObjectPowerClass(string legendText, int[] data, Color color)
              : base(legendText, data, color)
        { }

        private double calcNormalisedTotal(List<int[]> interval = null, bool intervals_enabled = false)
        {
            double total = 0.0;

            if (intervals_enabled == true)
            {
                for (int i = 0; i < interval.Count; i++)
                {
                    for (int j = interval[i][0]; j <= interval[i][1]; j++)
                    {
                        total += Math.Pow(data[j], 4);
                    }
                }
            }
            else
            {
                for (int i = 0; i <= data.Length - 1; i++)
                {
                    total += Math.Pow(data[i], 4);
                }
            }

            return total;
        }

        private double calcNormalisedAvg(List<int[]> interval = null, bool intervals_enabled = false)
        {
            double total = 0.0;
            double records = 0.0;
            double normalisedavg = 0.0;

            if (intervals_enabled == true)
            {
                for (int i = 0; i < interval.Count; i++)
                {
                    records += (interval[i][1] - interval[i][0]) + 1;
                }
            }
            else
            {
                records = data.Length;
            }

            total = calcNormalisedTotal(interval, intervals_enabled);
            normalisedavg = total / records;

            return normalisedavg;
        }

        public int calcNormalisedPower(List<int[]> interval, bool intervals_enabled)
        {
            double normalisedPower = (double)Math.Pow(calcNormalisedAvg(interval, intervals_enabled), 0.25);

            return (int)normalisedPower;
        }

        public int calcIntensityFactor(List<int[]> interval, bool intervals_enabled, double ftp)
        {
            double intensityFactor = (calcNormalisedPower(interval, intervals_enabled) / ftp) * 100;

            return (int)intensityFactor;
        }

        public int calcTSS(List<int[]> interval, bool intervals_enabled, double ftp, double frequency)
        {
            double records = 0.0;

            if (intervals_enabled == true)
            {
                for (int i = 0; i < interval.Count; i++)
                {
                    records += (interval[i][1] - interval[i][0]) + 1;
                }
            }
            else
            {
                records = data.Length;
            }

            double durationHours = records * frequency / 60 / 60;
            double intensityFactor = calcIntensityFactor(interval, intervals_enabled, ftp) / 100.0;
            double trainingTestScore = Math.Pow(intensityFactor, 2.0) * durationHours * 100.0;

            return (int)trainingTestScore;
        }

        public List<int[]> createIntervals(int threshold, int tolerance, int least_interval_size, int end_peak_value_minus_tolerance_start, int end_peak_value_minus_tolerance_end)
        {
            List<int[]> intervals = new List<int[]>();

            bool peak = false;
            int start_peak = 0;
            int end_peak = 0;
            int start_peak_value = 0;
            int end_peak_value = 0;

            // Check (Power from Cycle.cs) ZedGraph points
            for (int i = 1; i < data.Length; i++)
            {
                int previous_value = data[i - 1];
                int this_value = data[i];

                if (peak == false)
                {
                    // Direction of Curve = /
                    if (previous_value < this_value)
                    {

                    }
                    // Direction of Curve = \
                    else if (previous_value >= this_value && this_value > threshold)
                    {
                        peak = true;
                        i--;
                        start_peak = i;
                        start_peak_value = data[i];
                    }
                }
                else if (peak == true)
                {
                    // Two modes. End-Peak-Value-Highest and End-Peak-Value-Minus-Tolerance
                    // End-Peak-Value-Highest is enabled by default
                    // Setting End-Peak-Value-Minus-Tolerence-Start and End means that this mode
                    // will be active between these records
                    if (start_peak_value < this_value + tolerance || start_peak_value < this_value - tolerance)
                    {
                        if (end_peak_value_minus_tolerance_start <= i && i <= end_peak_value_minus_tolerance_end)
                        {

                            if (this_value > end_peak_value - tolerance)
                            {
                                end_peak_value = this_value;
                                end_peak = i;
                            }
                        }
                        else
                        {
                            if (this_value > end_peak_value)
                            {
                                end_peak_value = this_value;
                                end_peak = i;
                            }
                        }

                    }
                    else
                    {
                        if (end_peak - start_peak > least_interval_size)
                        {
                            int[] interval = new int[2] { start_peak, end_peak };
                            intervals.Add(interval);
                        }

                        end_peak_value = 0;

                        peak = false;
                    }
                }
            }

            return intervals;
        }
    }
}
