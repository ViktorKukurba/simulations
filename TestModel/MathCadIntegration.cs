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
            try
            {
                var a = _mathCadWorkSheet.GetValue("alpha");
                var b = _mathCadWorkSheet.GetValue("beta");
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