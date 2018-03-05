using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicForCycle
{
    public class HRMObjectSpeedClass:HRMObjectClass
    {
        public HRMObjectSpeedClass(string legendText, int[] data, Color color)
            : base(legendText, data, color)
        { }

        public decimal calcDistance(List<int[]> interval = null, bool intervals_enabled = false, int interval_index = -1, double frequency = 0.0)
        {
            double records = 0.0;
            double distance = 0.0;

            if (intervals_enabled == true && interval_index >= 0 && interval_index < interval.Count)
            {
                for (int i = interval_index; i < interval_index + 1; i++)
                {
                    records += (interval[i][1] - interval[i][0]) + 1;
                }

                distance = calcAvg(interval, intervals_enabled, interval_index) / 60.0 / 60.0 * records * frequency;
            }
            else if (intervals_enabled == true)
            {
                for (int i = 0; i < interval.Count; i++)
                {
                    records += (interval[i][1] - interval[i][0]) + 1;
                }

                distance = calcAvg(interval, intervals_enabled) / 60.0 / 60.0 * records * frequency;
            }
            else
            {
                distance = calcAvg() / 60.0 / 60.0 * data.Length * frequency;
            }

            decimal roundedDistance = decimal.Round((decimal)distance, 2);
            return roundedDistance;
        }
    }
}
