using System;

namespace ProcessModeling.Classes
{
    /// <summary>
    /// Abstract class for Distribution
    /// </summary>
    public abstract  class Distribution
    {
        public abstract double ParameterA { get; set; }
        public abstract double ParameterB { get; set; }
        public abstract double GetDistributionValue();
        public abstract string DistributionName { get; set; }
    }

    /// <summary>
    /// Exponential distribution
    /// </summary>
    public class ExponentialDistribution:Distribution
    {
        public override sealed double ParameterA { get; set; }

        public override sealed double ParameterB { get; set; }

        public override double GetDistributionValue()
        {
            var random = new Random();
            return ParameterB - Math.Log(random.NextDouble()) / ParameterA;
        }

        public override sealed string DistributionName { get; set; }

        public ExponentialDistribution()
        {
            DistributionName = "Експоненційний";
        }
        public ExponentialDistribution(double parameterA, double parameterB)
        {
            ParameterA = parameterA;
            ParameterB = parameterB;
            DistributionName = "Експоненційний";
        }
    }

    /// <summary>
    /// Uniform distribution
    /// </summary>
    public class UniformDistribution : Distribution
    {
        public override sealed double ParameterA { get; set; }

        public override sealed double ParameterB { get; set; }

        public override double GetDistributionValue()
        {
            var random = new Random();
            return ParameterA + (ParameterB - ParameterA) * random.NextDouble();
        }

        public override sealed string DistributionName { get; set; }

        public UniformDistribution()
        {
            DistributionName = "Рівномірний";
        }
        public UniformDistribution(double parameterA, double parameterB)
        {
            ParameterA = parameterA;
            ParameterB = parameterB;
            DistributionName = "Рівномірний";
        }
    }

    /// <summary>
    /// Weibull distribution
    /// </summary>
    public class WeibullDistribution : Distribution
    {
        public override sealed double ParameterA { get; set; }

        public override sealed double ParameterB { get; set; }

        public override double GetDistributionValue()
        {
            var random = new Random();
            return Math.Pow(-1 / ParameterA * Math.Log(random.NextDouble()), (1 / ParameterB));
        }

        public override sealed string DistributionName { get; set; }

        public WeibullDistribution()
        {
            DistributionName = "Вейбула";
        }
        public WeibullDistribution(double parameterA, double parameterB)
        {
            ParameterA = parameterA;
            ParameterB = parameterB;
            DistributionName = "Вейбула";
        }
    }


    /// <summary>
    /// Normal distribution
    /// </summary>
    public class NormalDistribution : Distribution
    {
        public override sealed double ParameterA { get; set; }

        public override sealed double ParameterB { get; set; }

        public override double GetDistributionValue()
        {
            var random = new Random();
            double x;
            x = ParameterA + ParameterB * Math.Sqrt(-2 * Math.Log(random.NextDouble())) * Math.Cos(2 * Math.PI * random.NextDouble());
            if (x < 0) { x = -x; }
            return x;
        }

        public override sealed string DistributionName { get; set; }

        public NormalDistribution()
        {
            DistributionName = "Нормальний";
        }
        public NormalDistribution(double parameterA, double parameterB)
        {
            ParameterA = parameterA;
            ParameterB = parameterB;
            DistributionName = "Нормальний";
        }
    }



    /// <summary>
    /// Class that have disrtibution functions, and method that make choice of d.function
    /// </summary>
    public class DistributionClass
    {
        //private int state;
        /// <summary>
        /// Random Number
        /// </summary>
        public double realRnd1{get; set;}
        private Random realRnd = new Random();
        /// <summary>
        /// Parameter of Distribution(Lower limit or ...)
        /// </summary>
        public double a{get;set;}
        /// <summary>
        /// Parameter of Distribution(Upper limit or ...)
        /// </summary>
        public double b{get;set;}
        /// <summary>
        /// Name of Distribution
        /// </summary>
        private string DistributionName { get; set; }
        /// <summary>
        /// Method that gives value distribution f.
        /// </summary>
        /// <returns>value of chosen distribution</returns>
       
        public double DistributionChoice()
            {
                double x=0;
                if (this.DistributionName == "Рівномірний") x = this.Rivnomirnuj(this.a,this.b);
                if (this.DistributionName == "Експоненційний") x = this.Exponential(this.a, this.b);
                if (this.DistributionName == "розподіл Вейбула") x = this.RVejbyla(this.a, this.b);
                if (this.DistributionName == "Нормальний розподіл") x = this.RNormal(this.a, this.b);
                if (this.DistributionName == "Бета-розподіл") x = this.RBeta(this.a, this.b);
                if (this.DistributionName == "Логарифмічно нормальний") x = this.RLogNorm(this.a, this.b);
                if (this.DistributionName == "Ерланга") x = this.RErlang(this.a, this.b);
                if (this.DistributionName == "хі-квадрат") x = this.RHiKvadrat(this.a);
                if (this.DistributionName == "розподіл Релея") x = this.RReleja(this.a);
                if (this.DistributionName == "Стьюдента") x = this.RStudenta(this.a);
                if (this.DistributionName == "Фішера") x = this.RFischera(this.a, this.b);

                if ( x < 0 ) x=-x;
        
                return x;
            }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="a">Parameter of Distribution(Lower limit or ...)</param>
        /// <param name="b">Parameter of Distribution(Upper limit or ...)</param>
        /// <param name="distributionName">Name of distribution</param>
        /// <param name="rand"></param>
            public DistributionClass(double a, double b, string distributionName,double rand)
            {
                this.a = a; this.b = b; this.DistributionName = distributionName; this.realRnd1 = rand;
            }

        
        /// <summary>
        /// Block of distribution functions
        /// </summary>
                       
            public double Exponential(double a, double b)
            {
                return b - Math.Log(realRnd1) / a;
            }
            private double Rivnomirnuj(double a, double b)
            {
                return a + (b - a) * realRnd1;
            }
            private double RVejbyla(double a, double b)
            {
                return Math.Pow(-1 / a * Math.Log(realRnd1), (1 / b));
            }
            private double RNormal(double a, double b)
            {
                double x;
                x = a + b * Math.Sqrt(-2 * Math.Log(realRnd1)) * Math.Cos(2 * Math.PI * realRnd1);
                if (x < 0) { x = -x; }
                return x;
            }
            private double RLogNorm(double a, double b)
            {
                double z = 0;
                for (int k = 0; k < 12; k++)
                {
                    z = z + realRnd.NextDouble();
                }
                z = z - 6;
                return Math.Exp((a + b * z));

            }
            private double RErlang(double a, double b)
            {
                
                double z = 1;
                for (int k = 0; k < a; k++)
                {
                    z = z * realRnd1;
                }
                return -1 / b * Math.Log(z);
            }
            private double RHiKvadrat(double a)
            {
                double[] zhi = new double[12];
                double z = 0, x = 0;
                for (int l = 1; l <= a; l++)
                {
                    z = 0;
                    for (int k = 0; k < 12; k++)
                    {
                        z = z + realRnd.NextDouble();
                    }
                    zhi[l] = z - 6;
                    x = x + Math.Pow(zhi[l], 2);
                }
                return x;
            }
            private double RReleja(double a)
            {
                double x = 0; ;
                x = (a * Math.Pow(-2 * Math.Log(realRnd1), (1 / 2)));
                return x;
            }
            private double RStudenta(double a)
            {
                double[] zhi = new double[12];
                double z = -6, z2, x = 0;
                for (int k = 0; k < 12; k++)
                {
                    z = z + realRnd.NextDouble();
                }
                z = z * Math.Pow(a, (1 / 2));

                for (int l = 0; l < a; l++)
                {
                    z2 = -6;
                    for (int k = 0; k < 12; k++)
                    {
                        z2 = z2 + realRnd.NextDouble();
                    }
                    zhi[l] = z2;
                    x = x + Math.Pow(zhi[l], 2);
                }
                z = z / Math.Pow(x, (1 / 2));
                return z;
            }
            private double RFischera(double n1, double n2)
            {
                double[] zhi = new double[12];
                double z = 0, x1 = 0, x = 0;
                for (int l = 0; l < n1; l++)
                {
                    z = 0;
                    for (int k = 0; k < 12; k++)
                    {
                        z = z + realRnd.NextDouble();
                    }
                    zhi[l] = z - 6;
                    x1 = x1 + Math.Pow(zhi[l], 2);
                }
                x1 = n2 * x1;

                for (int l = Convert.ToInt32(n1); l < n2 + n1; l++)
                {
                    z = 0;
                    for (int k = 0; k < 12; k++)
                    {
                        z = z + realRnd.NextDouble();
                    }
                    zhi[l] = z - 6;
                    x = x + Math.Pow(zhi[l], 2);
                }
                x = n1 * x;
                x = x1 / x;
                return x;
            }
            private double RBeta(double n, double m)
            {
                double[] zhi = new double[12];
                double z, x1 = 0, x = 0;
                for (int l = 0; l < m; l++)
                {
                    z = 0;
                    for (int k = 0; k < 12; k++)
                    {
                        z = z + realRnd.NextDouble();
                    }
                    zhi[l] = z - 6;
                    x1 = x1 + Math.Pow(zhi[l], 2);
                }

                for (int l = 0; l < (m + n); l++)
                {
                    z = 0;
                    for (int k = 0; k < 12; k++)
                    {
                        z = z + realRnd.NextDouble();
                    }
                    zhi[l] = z - 6;
                    x = x + Math.Pow(zhi[l], 2);
                }
                return x1 / x;
            }
        
    
        }
    }
