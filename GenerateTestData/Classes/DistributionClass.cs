using System;
using System.Collections.Generic;

namespace GenerateTestData.Classes
{
    /// <summary>
    /// Abstract class for Distribution
    /// </summary>
    public interface  IDistribution
    {
        List<double> Parameters { get; set; }
        double GetDistributionValue();
        string DistributionName { get; set; }
    }

    public class RandomValue
    {
        private static Random _instance;
        private RandomValue()
        {
            _instance = new Random();
        }
        public static Random Instance()
        {
            return _instance ?? (_instance= new Random());
        }
    }

    /// <summary>
    /// Exponential distribution
    /// </summary>
    public class ExponentialDistribution:IDistribution
    {
        public List<double> Parameters { get; set; }

        public double GetDistributionValue()
        {
            return Parameters[1] - Math.Log(RandomValue.Instance().NextDouble()) / Parameters[0];
        }

        public string DistributionName { get; set; }

        public ExponentialDistribution()
        {
            DistributionName = "Експоненційний";
            Parameters = new List<double> {1, 0};
        }
        public ExponentialDistribution(double parameterA, double parameterB)
        {
            DistributionName = "Експоненційний";
            Parameters = new List<double> { parameterA, parameterB };
        }
    }

    /// <summary>
    /// Uniform distribution
    /// </summary>
    public class UniformDistribution : IDistribution
    {
        public List<double> Parameters { get; set; }

        public double GetDistributionValue()
        {
            return Parameters[0] + (Parameters[1] - Parameters[0]) * RandomValue.Instance().NextDouble();
        }

        public string DistributionName { get; set; }

        public UniformDistribution()
        {
            DistributionName = "Рівномірний";
            Parameters = new List<double> { 0, 1 };
        }
        public UniformDistribution(double parameterA, double parameterB)
        {
            Parameters = new List<double> { parameterA, parameterB };
            DistributionName = "Рівномірний";
        }
    }

    /// <summary>
    /// Weibull distribution
    /// </summary>
    public class WeibullDistribution : IDistribution
    {
        public List<double> Parameters { get; set; }

        public double GetDistributionValue()
        {
            var random = new Random();
            return Math.Pow(-1 / Parameters[0] * Math.Log(random.NextDouble()), (1 / Parameters[1]));
        }

        public string DistributionName { get; set; }

        public WeibullDistribution()
        {
            DistributionName = "Вейбула";
            Parameters = new List<double>() { 1, 1 };
        }
        public WeibullDistribution(double parameterA, double parameterB)
        {
            Parameters = new List<double>(){parameterA, parameterB};
            DistributionName = "Вейбула";
        }
    }


    /// <summary>
    /// Pseudo Normal distribution
    /// </summary>
    public class NormalDistribution : IDistribution
    {
        public List<double> Parameters { get; set; }

        public double GetDistributionValue()
        {
            var random = new Random();
            double x;
            x = Parameters[0] + Parameters[1] * Math.Sqrt(-2 * Math.Log(random.NextDouble())) * Math.Cos(2 * Math.PI * random.NextDouble());
            if (x < 0) { x = -x; }
            return x;
        }

        public string DistributionName { get; set; }

        public NormalDistribution()
        {
            Parameters = new List<double>() { 0, 1 };
            DistributionName = "Нормальний";
        }
        public NormalDistribution(double parameterA, double parameterB)
        {
            Parameters = new List<double>() { parameterA, parameterB};
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
       
        public double DistributionChoice(double t = 1)
            {
            if(t==0) t = 0.001;
                double x=0;
                if (this.DistributionName == "Рівномірний") x = this.Rivnomirnuj(this.a,this.b, t);
                if (this.DistributionName == "Експоненційний") x = this.Exponential(this.a, this.b, t);
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
                       
            public double Exponential(double a, double b, double time = 1)
            {
                return b - time*Math.Log(realRnd.NextDouble()) / a;
            }
            private double Rivnomirnuj(double a, double b, double time = 1)
            {
                return a + (b - a) * realRnd1*time;
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
