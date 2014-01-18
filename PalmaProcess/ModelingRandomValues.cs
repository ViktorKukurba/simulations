using System;
using System.Collections.Generic;
using System.Windows.Forms;
using M2.ChiSquare;
using M2.Classes;
using M2.DbManager;
using ProcessModeling.RandomValuesClasses;

namespace M2
{
    public partial class ModelingRandomValues : Form
    {
        private DbManage _dbManage;
        private ChiSquareMethod _chiSquare;
        public ModelingRandomValues()
        {
            InitializeComponent();
            _dbManage = new DbManage();
            _chiSquare = new ChiSquareMethod();
        }

        private void btnGenRndValues_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(IterAmount.Text);
            GenerationRV RValues = new GenerationRV();
            List<double> Result = RValues.GenPoissonValues(n, 1500,0);
            //var testId = _dbManage.SaveInDb(Result);
            _chiSquare.ProofChiSquare(0);
            for (int i = 0; i < 20; i++)
            {
                var r = new List<double>();
                r.AddRange(Result);
                Result.Add(GenerateMarkovProcess.GenerateMarkovP(r));
            }

            GraphConsructingClass d = new GraphConsructingClass();

            d.DrawRandomValues(zedGraphRandomValues,Result );
            d.DrawKumulanteRandomValues(zedGraphKumulante, Result);
            TableClass t = new TableClass();
            t.CreateRVTable(Result, dataGridView1);




        }

        private void ModelingRandomValues_Load(object sender, EventArgs e)
        {

        }



    }
}
