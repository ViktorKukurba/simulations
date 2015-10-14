using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProductModel
{
    /// <summary>
    /// Class describes poisson process
    /// </summary>
    public class Generator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Generator"/> class.
        /// </summary>
        /// <param name="intenrval">The intenrval.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="intensity">The intensity.</param>
        /// <param name="distribution">The distribution.</param>
        public Generator(double intenrval = 1, double duration = 20, double intensity = 1, string distribution = "Рівномірний", double paramA = 1, double paramB = 1)
        {
            Duration = duration;
            Interval = intenrval;
            Intensity = intensity;
            _distribution = CreateDistribution(distribution, paramA, paramB);
            _processExpEvents = new List<PoissonPoint>()
                                                     {
                                                         new PoissonPoint()
                                                             {Number = 0, TimePoint = 0, TimeState = 0, Value = 0}
                                                     };
            _processPoisson = new List<PoissonPoint>();
        }

        /// <summary>
        /// Gets or sets the intensity.
        /// </summary>
        /// <value>
        /// The intensity.
        /// </value>
        public double Intensity { get; set; }
        /// <summary>
        /// Gets or sets the interval.
        /// </summary>
        /// <value>
        /// The interval.
        /// </value>
        public double Interval { get; set; }
        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public double Duration { get; set; }

        /// <summary>
        /// The _distribution
        /// </summary>
        private readonly IDistribution _distribution;

        /// <summary>
        /// The _process exp events
        /// </summary>
        private List<PoissonPoint> _processExpEvents = new List<PoissonPoint>();
        /// <summary>
        /// The _process poisson
        /// </summary>
        private readonly List<PoissonPoint> _processPoisson;

        /// <summary>
        /// Generates the exp events.
        /// </summary>
        /// <summary>
        /// Generates the exp events.
        /// </summary>
        /// <returns></returns>
        public List<PoissonPoint> GenerateExpEvents()
        {            
            //Generator of Random Numbers
            Random rnd = new Random();
            var i = 1;
            var j = 0;
            //Generating random events while max distance is not reached
            while (Interval * i <= Duration)
            {
                var timePoint = _processExpEvents.Last().TimePoint;
                if(_processExpEvents.Last().TimePoint == 0)
                {
                    timePoint = 0.001;
                }
                var time = _distribution.GetDistributionValue(timePoint);
                if (timePoint + time > Interval * i)
                {
                    i++;
                }
                if (timePoint + time >= Duration)
                {
                    break;
                }
                _processExpEvents.Add(new PoissonPoint()
                                        {
                                            Value = i,
                                            Number = j,
                                            TimePoint = timePoint + time,
                                            TimeState = time
                                        });
                j++;
                if (timePoint + time >= Duration)
                {
                    break;
                }
            }
            return _processExpEvents;
        }


        /// <summary>
        /// Generates the poisson.
        /// </summary>
        /// <returns></returns>
        public List<PoissonPoint> GeneratePoisson(List<PoissonPoint> processExpEvents)
        {
            if (processExpEvents!=null)
            {
                _processExpEvents = processExpEvents;
            }
            // Create process values using generated process
            for (var k = 0; k <= (int)Math.Ceiling(Duration / Interval); k++)
            {
                var index = k;
                var val = _processExpEvents.Count(
                                         _ => _.TimePoint > index * Interval && _.TimePoint < (index + 1) * Interval);
                _processPoisson.Add(new PoissonPoint()
                             {
                                 TimePoint = index*Interval,
                                 Value = val,
                                 SumValue = _processPoisson.Sum(_=>_.Value) + val,
                                 Number = k
                             });
            }
            double sum1 = _processExpEvents.Sum(_ => _.Value);
            double sum = _processPoisson.Sum(_ => _.Value);
            _processPoisson.ForEach(_ => { _.EmpValue = _.SumValue / sum; });
            return _processPoisson;
        }

        public List<PoissonPoint> GetIntensityData(double a, double b, double s)
        {
            var list = new List<PoissonPoint>() {
                new PoissonPoint()
                {
                    TimePoint = 0,
                    EmpValue = 0
                }

            };

            for (int i = 2; i < _processPoisson.Count; i++)
            {
                var t = _processPoisson[i].TimePoint;

                list.Add(new PoissonPoint()
                {
                    TimePoint = t,
                    EmpValue = a*Math.Pow(b,t + 1)*Math.Pow(s,t)*Math.Exp(-t*b)
                });
            }

            return list;
        }

        private IDistribution CreateDistribution(string distribution, double a, double b)
        {
            switch (distribution)
            {
                case "Експоненційний": return new ExponentialDistribution(a,b);
                case "Вейбула": return new WeibullDistribution(a,b);
                case "Ерланга": return new ErlangDistribution(a,b);
                default : return new ExponentialDistribution();
            }
        }
    }

        /// <summary>
        /// Describes Poisson Point
        /// </summary>
        [Serializable()]
        public class PoissonPoint
        {
            public int Value { get; set; }
            public double TimePoint { get; set; }
            public double TimeState { get; set; }
            public int Number { get; set; }
            public short Value1 { get{return 1;}}
            public double EmpValue { get; set; }
            public double SumValue { get; set; }
        }
}
