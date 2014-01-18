using System;
using System.Collections.Generic;
using System.Linq;
using M2.Classes;

namespace WiennerProcess.Classes
{

    /// <summary>
    /// Describes Wiener Modeling
    /// Incapsulates logic for generating process
    /// </summary>
    public class WienerModeling
    {
        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        public double Distance { get; set; }

        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        /// <value>
        /// The radius.
        /// </value>
        public double Radius { get; set; }

        /// <summary>
        /// Generates the process.
        /// </summary>
        /// <returns></returns>
        public List<WienerPoint> GenerateProcess()
        {
            // Creates list with start point of process
            List<WienerPoint> processList = new List<WienerPoint>()
                                                {
                                                    { new WienerPoint() { Value = 0, YValue = 0, Number = 0, XValue = 0 } }
                                                };
            // Creates Uniform Distribution
            var length = Radius/Math.Sqrt(2);
            DistributionClass Distribution = new DistributionClass(length, 0, "Рівномірний", 0);
            Random rnd = new Random();
            //Modeling points for process
            for (int i = 1; i < Distance; i++)
            {
                var point = new WienerPoint();
                Distribution.realRnd1 = rnd.NextDouble();
                var lastPoint = processList.Last();
                point.XValue = Distribution.DistributionChoice(lastPoint.XValue + length, lastPoint.XValue - length);
                Distribution.realRnd1 = rnd.NextDouble();
                var maxY = Math.Sqrt(Math.Pow(length, 2) - Math.Pow(point.XValue - lastPoint.XValue, 2));
                point.YValue = Distribution.DistributionChoice(lastPoint.YValue + maxY, lastPoint.YValue - maxY);
                point.Number = i;
                point.Value = Math.Sqrt(Math.Pow(point.XValue - lastPoint.XValue, 2) + Math.Pow(point.YValue - lastPoint.YValue, 2));
                processList.Add(point);
            }
            return processList;
        }
    }

    /// <summary>
    /// Discribes point of process
    /// </summary>
    public class WienerPoint
    {
        public double Value { get; set; }
        public double XValue { get; set; }
        public double YValue { get; set; }
        public int Number { get; set; }
    }
}
