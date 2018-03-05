using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;


namespace LogicForCycle
{
    public class ZedClass
    {
        private double duration;
        private DateTime startDateTime;

        /* Point Pairs for Manually Created Intervals
         * 
         * PointPair[0] to PointPair[1] are Interval 1 start Line
         * PointPair[2] to PointPair[3] are Interval 1 end Line etc...
         */
        PointPairList intervalManualClickList = new PointPairList();

        // Construct Zgraph with X-Axis parameters only
        public ZedClass(ZedGraphControl zgc, DateTime startDateTime, double duration)
        {
            this.duration = duration;
            this.startDateTime = startDateTime;
         
        }

        /* Plot ZedGraph Line Graph
         * @param ZedGraphControl zgc - the zedgraphcontrol (displays chart area)
         * @param HRMObjectCollection hrmobjectcollection - the collection of hrmobjects to display as plotted x,y data
         * @param int interval - the interval between each recorded line of data (polar cycle can be set to record data every x seconds)
         * @param List<int[]> intervals - a list of integer arrays of size 2, storing start and end x co-ordinates for each exercise interval 
         */
        public GraphPane plotLineGraph(ZedGraphControl zgc, HRMObjectCollectionClass hrmObjectCollection, int frequency, List<int[]> intervals = null)
        {
            if (hrmObjectCollection.getCount() == 0 || hrmObjectCollection.getObject(0).data == null)
            {
                throw new ArgumentException("HRMObjectCollection is Empty");
            }

            
            // and labelled X-axis
            GraphPane pane = zgc.GraphPane;
            clearPane(pane);
            pane.AddYAxis("");
            pane.Title.Text = "Polar Data Reader";
            pane.XAxis.Title.Text = "Time (HH:MM:SS)";
            pane.XAxis.IsVisible = true;

            // Plot
            // Loop through HRMObject Collection plotting each one individually
            for (int i = 0; i < hrmObjectCollection.getCount(); i++)
            {
                PointPairList ppList = new PointPairList();

                for (int j = 0; j < duration; j++)
                {
                    // X-Value
                    double a = new XDate(startDateTime.AddSeconds(j * frequency).ToOADate());
                    // Note: this "frequency" is the polar cycle rate at which it records data by x seconds times

                    // HRMObject Y-Value
                    double b = hrmObjectCollection.getObject(i).data[j];

                    // Add to Point Pair List
                    ppList.Add(a, b);

                    // Intervals From HRMObjectPower
                    if (intervals != null && hrmObjectCollection.getObject(i) is HRMObjectPowerClass)
                    {
                        for (int k = 0; k < intervals.Count(); k++)
                        {
                            for (int l = 0; l < intervals[k].Length; l++)
                            {
                                if (intervals[k][l] == j)
                                {
                                    LineItem line = new LineItem(String.Empty, new[] { a, a },
                                        new[] { 0.0, hrmObjectCollection.getObject(i).calcMax() }, // Set height of interval lines to max of this HRMObject's y-value
                                        Color.Black, SymbolType.None);
                                    line.Line.Width = 1f;

                                    // Add Interval Line
                                    pane.CurveList.Add(line);
                                }
                            }

                        }
                    }

                    // Display the Y axis grid lines
                    pane.YAxis.MajorGrid.IsVisible = true;
                    pane.YAxis.MinorGrid.IsVisible = true;

                }

                // Add HRMObject Data Line
                LineItem myCurve = pane.AddCurve(hrmObjectCollection.getObject(i).legendText, ppList, hrmObjectCollection.getObject(i).color, SymbolType.Diamond);
                myCurve.Symbol.Fill = new Fill(Color.White);
            }

            // Format X-axis as Date
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.XAxis.Type = AxisType.Date;
            pane.XAxis.Scale.Format = "T";

            // Set X-axis scale to default
            pane.XAxis.Scale.Align = AlignP.Inside;
            pane.XAxis.Scale.MinAuto = true;
            pane.XAxis.Scale.MaxAuto = true;
            pane.XAxis.Scale.MinorStepAuto = true;
            pane.XAxis.Scale.MajorStepAuto = true;

            // Set Y-axis scale to default
            pane.YAxis.Scale.Align = AlignP.Inside;
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;
            pane.YAxis.Scale.MinorStepAuto = true;
            pane.YAxis.Scale.MajorStepAuto = true;

            pane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);

            ZGraphControl(zgc);

            return pane;
        }

        /*  Create Coggan's MHR and Power Zones for Line Graph based on HRMObject
        *   Draw band box at 105% of value 11% of HRMObject height downwards
        */
        public void createZonesForLineGraph(ZedGraphControl zgc, string type, double value)
        {
            GraphPane pane = zgc.GraphPane;

            if (type == "Heart Rate")
            {

                // Lactate Threshold 95-105%
                BoxObj box1 = new BoxObj(0, 1.05 * value, int.MaxValue, 0.11 * value, Color.Empty, Color.Empty);
                box1.Fill = new Fill(Color.White, Color.Red, 45.0F);
                box1.ZOrder = ZOrder.F_BehindGrid;
                box1.IsClippedToChartRect = true;
                pane.GraphObjList.Add(box1);

                // Tempo 84-94%
                BoxObj box2 = new BoxObj(0, 0.94 * value, int.MaxValue, 0.11 * value, Color.Empty, Color.Empty);
                box2.Fill = new Fill(Color.White, Color.Yellow, 45.0F);
                box2.ZOrder = ZOrder.F_BehindGrid;
                box2.IsClippedToChartRect = true;
                pane.GraphObjList.Add(box2);

                // Endurance 69-83%
                BoxObj box3 = new BoxObj(0, 0.83 * value, int.MaxValue, 0.15 * value, Color.Empty, Color.Empty);
                box3.Fill = new Fill(Color.White, Color.LightGreen, 45.0F);
                box3.ZOrder = ZOrder.F_BehindGrid;
                box3.IsClippedToChartRect = true;
                pane.GraphObjList.Add(box3);
            }

            else if (type == "Power")
            {
                // Lactate Threshold 91-105%
                BoxObj box1 = new BoxObj(0, 1.05 * value, int.MaxValue, 0.15 * value, Color.Empty, Color.Empty);
                box1.Fill = new Fill(Color.White, Color.Red, 45.0F);
                box1.ZOrder = ZOrder.F_BehindGrid;
                box1.IsClippedToChartRect = true;
                pane.GraphObjList.Add(box1);

                // Tempo 76-90%
                BoxObj box2 = new BoxObj(0, 0.90 * value, int.MaxValue, 0.15 * value, Color.Empty, Color.Empty);
                box2.Fill = new Fill(Color.White, Color.Yellow, 45.0F);
                box2.ZOrder = ZOrder.F_BehindGrid;
                box2.IsClippedToChartRect = true;
                pane.GraphObjList.Add(box2);

                // Endurance 56-75%
                BoxObj box3 = new BoxObj(0, 0.75 * value, int.MaxValue, 0.20 * value, Color.Empty, Color.Empty);
                box3.Fill = new Fill(Color.White, Color.LightGreen, 45.0F);
                box3.ZOrder = ZOrder.F_BehindGrid;
                box3.IsClippedToChartRect = true;
                pane.GraphObjList.Add(box3);
            }
        }

        public void clearZonesForLineGraph(ZedGraphControl zgc)
        {
            GraphPane pane = zgc.GraphPane;
            pane.GraphObjList.Clear();
        }

        public GraphPane plotPieChart(ZedGraphControl zgc, HRMObjectClass hrmObject)
        {
            GraphPane pane = zgc.GraphPane;
            clearPane(pane);
            pane.AddYAxis("");
            pane.Title.Text = "Power Balance";

            // Left Right Balance % distribution
            PieItem segment1 = pane.AddPieSlice(hrmObject.calcAvg(), Color.LightBlue, 0F, "Left Leg");
            PieItem segment2 = pane.AddPieSlice(100 - hrmObject.calcAvg(), Color.LightGreen, 0F, "Right Leg");

            // Segment Label Type (Name and %)
            segment1.LabelType = PieLabelType.Percent;
            segment2.LabelType = PieLabelType.Percent;

            ZGraphControl(zgc);

            return pane;
        }

        public LineItem createIntervals(ZedGraphControl zgc, MouseEventArgs e, HRMObjectClass hrmobject)
        {
            GraphPane pane = zgc.GraphPane;

            // x & y variables to store the axis values
            double xVal;
            double yVal;

            pane.ReverseTransform(e.Location, out xVal, out yVal);

            LineItem line = new LineItem(String.Empty, new[] { xVal, xVal },
                new[] { 0.0, hrmobject.calcMax() },
                Color.Black, SymbolType.None);
            line.Line.Width = 1f;

            // Add Interval Points to List
            intervalManualClickList.Add(xVal, pane.YAxis.Scale.Min);
            intervalManualClickList.Add(xVal, hrmobject.calcMax());

            // Add Curve to Zedgraph
            pane.CurveList.Add(line);

            zgc.Refresh();

            return line;
        }

        private void clearPane(GraphPane pane)
        {
            pane.YAxisList.Clear();
            pane.CurveList.Clear();
        }

        private void ZGraphControl(ZedGraphControl zgc)
        {
            // Enable scrollbars if needed
            zgc.IsShowHScrollBar = true;
            zgc.IsShowVScrollBar = true;
            zgc.IsAutoScrollRange = true;
            zgc.IsScrollY2 = true;

            // Tell ZedGraph to calculate the axis ranges
            zgc.AxisChange();

            // Make sure the Graph gets redrawn
            zgc.Invalidate();
        }


        //  Convert Interval Line X-co-ordinate to HRMObject.data[index]      
        public int ConvertPointToHRMObjectIndex(LineItem intervalLine, int frequency)
        {
            int index = 0;

            if (intervalLine != null)
            {
                double[] xValues = new double[(int)duration];

                for (int i = 0; i < duration; i++)
                {
                    // X-Values
                    xValues[i] = new XDate(startDateTime.AddSeconds(i * frequency).ToOADate());
                }

                double x = intervalLine.Points[0].X;
                double closest_value = xValues[0];
                double subtract_result = Math.Abs(closest_value - x);

                for (int i = 1; i < xValues.Count(); i++)
                {
                    if (Math.Abs(xValues[i] - x) < subtract_result)
                    {
                        subtract_result = Math.Abs(xValues[i] - x);
                        closest_value = xValues[i];
                        index = i + 1;
                    }
                }
            }

            return index;
        }
    }
}
