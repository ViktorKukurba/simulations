using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M2.Classes
{
/// <summary>
/// Class that is constructed for building tables
/// </summary>
    class TableClass
    {
        public int rows{get;set;}
        public int colls { get; set; }
        
        public void CreateTable(double[,] matrixOfProcess, System.Windows.Forms.DataGridView DGV)
        {
            if (this.rows == 2)
            {
                DGV.RowCount = 4;
                if (this.colls < 500) DGV.ColumnCount = this.colls + 1;
                else DGV.ColumnCount = 500;

                double[] Time = new double[matrixOfProcess.Length / 2];
                ProcessModeling.Classes.ProcessClass PC = new ProcessModeling.Classes.ProcessClass();
                Time = ProcessModeling.Classes.ProcessClass.Accumulation(matrixOfProcess);

                DGV.Rows[0].Cells[0].Value = Convert.ToString("Номер переходу");
                DGV.Rows[1].Cells[0].Value = Convert.ToString("Стан {-1; 0; +1},{"+(PC.State(matrixOfProcess, -1).Length/2-1).ToString()+";"+(PC.State(matrixOfProcess, 0).Length/2-1).ToString()+";"+(PC.State(matrixOfProcess, 1).Length/2-1).ToString()+"}");
                DGV.Rows[2].Cells[0].Value = Convert.ToString("Час перебування" + (PC.MatrixSum(PC.State(matrixOfProcess, -1))).ToString() + ";" + (PC.MatrixSum(PC.State(matrixOfProcess, 0))).ToString() + ";" + (PC.MatrixSum(PC.State(matrixOfProcess, 1))).ToString() + ")");
                DGV.Rows[3].Cells[0].Value = Convert.ToString("Тривалість процесу" + (Time[this.colls-1]).ToString());


                //Stan1.DefaultIfEmpty();
                for (int i = 0; i < DGV.ColumnCount-1; i++)
                {
                    DGV.Rows[0].Cells[i + 1].Value = Convert.ToString(i);
                    DGV.Rows[1].Cells[i + 1].Value = Convert.ToString(matrixOfProcess[i, 0]);
                    DGV.Rows[2].Cells[i + 1].Value = Convert.ToString(matrixOfProcess[i, 1]);
                    DGV.Rows[3].Cells[i + 1].Value = Convert.ToString(Time[i+1]);
                }
            }
        }
        public void CreateRVTable(List<double> List, System.Windows.Forms.DataGridView DGV)
        {
            DGV.RowCount = 2;
            if (List.Count > 500)
            {
                DGV.ColumnCount = 500;
            }
            else
            {
                DGV.ColumnCount = List.Count + 1;
            }
            DGV.Rows[0].Cells[0].Value = Convert.ToString("Номер ітерації");
            DGV.Rows[1].Cells[0].Value = Convert.ToString("Кількість помилок");


            //Stan1.DefaultIfEmpty();
            for (int i = 0; i < DGV.ColumnCount - 1; i++)
            {
                DGV.Rows[0].Cells[i + 1].Value = Convert.ToString(i);
                DGV.Rows[1].Cells[i + 1].Value = Convert.ToString(List[i]);
            }
 
        }

    }
}
