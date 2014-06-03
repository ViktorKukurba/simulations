using System;
using System.Runtime.InteropServices;
using Mathcad;

namespace TestProductModel
{
    /// <summary>
    /// MathCad Integration
    /// </summary>
    public class MathCadIntegration
    {
        public MathCadIntegration(string file)
        {
            MathCadFilePath = file;
            _mathCad = new Application();
            _mathCadWorkSheets = _mathCad.Worksheets;
            _mathCadWorkSheet = _mathCadWorkSheets.Open(MathCadFilePath);
        }
        public string MathCadFilePath { get; set; }
        protected readonly IMathcadApplication _mathCad;
        protected IMathcadWorksheets _mathCadWorkSheets;
        protected IMathcadWorksheet _mathCadWorkSheet;

        public void SetValues(string property, dynamic value)
        {
            _mathCadWorkSheet.SetValue(property, value);
        }

        public void Calculate()
        {
            _mathCadWorkSheet.Recalculate();
        }

        public void GetValue(string variable)
        {
            var t = ((MatrixValue)_mathCadWorkSheet.GetValue("t"));
            var time = ((MatrixValue)_mathCadWorkSheet.GetValue("time"));
            var n = _mathCadWorkSheet.GetValue("n");
            Console.WriteLine("time: {0};", time.Type);
            try
            {
                var a = _mathCadWorkSheet.GetValue("alpha");
                var b = _mathCadWorkSheet.GetValue("beta");
                Console.WriteLine("a: {0}; b: {1};", a, b);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            catch (COMException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            finally
            {
                dynamic mk = _mathCadWorkSheet.GetValue(variable);
                Console.WriteLine("alfa: {0}; n {1}", (_mathCadWorkSheet.GetValue("alfa") as INumericValue).Real, n);
                //Console.WriteLine("{0}: {1}", "t", ().ToString());MWNumericArray
                Console.WriteLine("{0}: {1};{2};", variable, t.Type, ((INumericValue) t.GetElement(0, 0)).Real);
                Console.WriteLine("{0}: {1}", variable, (mk).ToString());
                Console.WriteLine("{0}: {1};{2};{3}", "t", t.Cols, t.Rows, ((INumericValue)t.GetElement(2, 0)).Real);
                //Console.WriteLine("C = A + B = {0}", (_mathCadWorkSheet.GetValue("C") as INumericValue).Real);
                _mathCad.Visible = true;
                _mathCad.ActiveWorksheet.Close(Mathcad.MCSaveOption.mcDiscardChanges);
                _mathCad.Quit(Mathcad.MCSaveOption.mcDiscardChanges);
            }
        }
    }

    public class TestModelMathCad:MathCadIntegration
    {
        public TestModelMathCad(string file):base(file) {}

        public TestModel GetModelData()
        {
            TestModel modelData;
            try
            {
                modelData = new TestModel
                {
                    Alpha = ((INumericValue)_mathCadWorkSheet.GetValue("alpha")).Real,
                    Beta = ((INumericValue)_mathCadWorkSheet.GetValue("beta")).Real,
                    S = ((INumericValue)_mathCadWorkSheet.GetValue("es")).Real,
                    Total = ((INumericValue)_mathCadWorkSheet.GetValue("TotalErr")).Real
                };
                //var l = _mathCadWorkSheet.GetValue("lambda");
                //Console.WriteLine("Logger: {0};", l);
                //Console.WriteLine("Logger: {0};", l.Type);
            }
            catch (InvalidCastException e)
            {
                throw new Exception("Розв'язок не знайдено.");
            }
            catch (COMException e)
            {
                throw new Exception("Розв'язок не знайдено.");
            }
            finally
            {
                _mathCad.Visible = true;
                _mathCad.ActiveWorksheet.Close(MCSaveOption.mcDiscardChanges);
                _mathCad.Quit(MCSaveOption.mcDiscardChanges);
            }
            return modelData;
        }
    }

    public class SOPMathCad : MathCadIntegration
    {
        public SOPMathCad(string file) : base(file) { }

        public TestModel GetSOPData()
        {
            var testModel = new TestModel();
            MatrixValue s;
            try
            {
                s = (MatrixValue)_mathCadWorkSheet.GetValue("Y");
                testModel.S = ((INumericValue)s.GetElement(s.Rows-1, s.Cols-1)).Real;
                testModel.Total = ((INumericValue)_mathCadWorkSheet.GetValue("TotalErr")).Real;
            }
            catch (InvalidCastException e)
            {
                throw new Exception("Розв'язок не знайдено.");
            }
            catch (COMException e)
            {
                throw new Exception("Розв'язок не знайдено.");
            }
            finally
            {
                _mathCad.Visible = true;
                _mathCad.ActiveWorksheet.Close(MCSaveOption.mcDiscardChanges);
                _mathCad.Quit(MCSaveOption.mcDiscardChanges);
            }
            return testModel;
        }
    }

    public class TestModel
    {
        public double Alpha { get; set; }
        public double Beta { get; set; }
        public double S { get; set; }
        public double Total { get; set; }
    }
}