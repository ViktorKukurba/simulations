using System;
using System.Collections.Generic;

namespace WiennerProcess.Classes
{
/// <summary>
/// Class that is constructed for building tables
/// </summary>
    class TableClass
    {
        public int colls { get; set; }

        public void CreateTable(List<WienerPoint> matrixOfProcess, System.Windows.Forms.DataGridView DGV)
        {
                DGV.RowCount = 4;
                if (this.colls < 500) DGV.ColumnCount = this.colls + 1;
                else DGV.ColumnCount = 500;
                DGV.Rows[0].Cells[0].Value = Convert.ToString("Номер переходу");
                DGV.Rows[1].Cells[0].Value = Convert.ToString("Зміна по X");
                DGV.Rows[2].Cells[0].Value = Convert.ToString("Зміна по Y");
                DGV.Rows[3].Cells[0].Value = Convert.ToString("Відстань");
                for (int i = 0; i < DGV.ColumnCount-1; i++)
                {
                    DGV.Rows[0].Cells[i + 1].Value = Convert.ToString(i);
                    DGV.Rows[1].Cells[i + 1].Value = Convert.ToString(matrixOfProcess[i].XValue);
                    DGV.Rows[2].Cells[i + 1].Value = Convert.ToString(matrixOfProcess[i].YValue);
                    DGV.Rows[3].Cells[i + 1].Value = Convert.ToString(matrixOfProcess[i].Value);
                }
        }
    }
}
