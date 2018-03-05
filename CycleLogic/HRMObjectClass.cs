using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicForCycle
{
    public class HRMObjectClass
    {
        public Color color;
        public string legendText;
        public int[] data;

        public HRMObjectClass(string legendText, int[] data, Color color)
        {
            this.legendText = legendText;
            this.data = data;
            this.color = color;
        }

        public int calcMin(List<int[]> interval = null, bool intervals_enabled = false, int interval_index = -1)
        {
            int min = int.MaxValue;

            if (intervals_enabled == true && interval_index >= 0 && interval_index < interval.Count)
            {
                for (int i = interval_index; i < interval_index + 1; i++)
                {
                    for (int j = interval[i][0]; j <= interval[i][1]; j++)
                    {
                        if (min > data[j])
                        {
                            min = data[j];
                        }
                    }
                }
            }
            else if (intervals_enabled == true)
            {
                for (int i = 0; i < interval.Count; i++)
                {
                    for (int j = interval[i][0]; j <= interval[i][1]; j++)
                    {
                        if (min > data[j])
                        {
                            min = data[j];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i <= data.Length - 1; i++)
                {
                    if (min > data[i])
                    {
                        min = data[i];
                    }
                }
            }

            return min;
        }

        public int calcMax(List<int[]> interval = null, bool intervals_enabled = false, int interval_index = -1)
        {
            int max = int.MinValue;

            if (intervals_enabled == true && interval_index >= 0 && interval_index < interval.Count)
            {
                for (int i = interval_index; i < interval_index + 1; i++)
                {
                    for (int j = interval[i][0]; j <= interval[i][1]; j++)
                    {
                        if (max < data[j])
                        {
                            max = data[j];
                        }
                    }
                }
            }
            else if (intervals_enabled == true)
            {
                for (int i = 0; i < interval.Count; i++)
                {
                    for (int j = interval[i][0]; j <= interval[i][1]; j++)
                    {
                        if (max < data[j])
                        {
                            max = data[j];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i <= data.Length - 1; i++)
                {
                    if (max < data[i])
                    {
                        max = data[i];
                    }
                }
            }

            return max;
        }

        public int calcTotal(List<int[]> interval = null, bool intervals_enabled = false, int interval_index = -1)
        {
            double total = 0.0;

            if (intervals_enabled == true && interval_index >= 0 && interval_index < interval.Count)
            {
                for (int i = interval_index; i < interval_index + 1; i++)
                {
                    for (int j = interval[i][0]; j <= interval[i][1]; j++)
                    {
                        total += data[j];
                    }
                }
            }
            else if (intervals_enabled == true)
            {
                for (int i = 0; i < interval.Count; i++)
                {
                    for (int j = interval[i][0]; j <= interval[i][1]; j++)
                    {
                        total += data[j];
                    }
                }
            }
            else
            {
                for (int i = 0; i <= data.Length - 1; i++)
                {
                    total += data[i];
                }
            }

            return (int)total;
        }

        public int calcAvg(List<int[]> interval = null, bool intervals_enabled = false, int interval_index = -1)
        {
            double total = 0.0;
            double records = 0.0;
            double avg = 0.0;

            if (intervals_enabled == true && interval_index >= 0 && interval_index < interval.Count)
            {
                for (int i = interval_index; i < interval_index + 1; i++)
                {
                    records += (interval[i][1] - interval[i][0]) + 1;
                }
            }
            else if (intervals_enabled == true)
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

            total = calcTotal(interval, intervals_enabled, interval_index);
            avg = total / records;

            return (int)avg;
        }
    }
}
