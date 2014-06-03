using System;
using System.Collections.Generic;
using System.Linq;
using TestProductModel;

namespace GenerateTestData.DataViz
{
/// <summary>
/// Class that is constructed for building tables
/// </summary>
    class TableClass
    {
        /// <summary>
        /// Creates the table.
        /// </summary>
        /// <param name="processPoints">The points of process.</param>
        /// <param name="DGV">The DGV.</param>
        public void CreateTable(List<PoissonPoint> processPoints, System.Windows.Forms.DataGridView DGV)
        {
                DGV.RowCount = 4;
                if (processPoints.Count < 500) DGV.ColumnCount = processPoints.Count+1;
                else DGV.ColumnCount = 500;
                DGV.Rows[0].Cells[0].Value = Convert.ToString("Номер інтервалу");
                DGV.Rows[1].Cells[0].Value = Convert.ToString("К-сть подій");
                DGV.Rows[2].Cells[0].Value = Convert.ToString("Сумарна к-сть");

                for (var i = 0; i < DGV.ColumnCount-1; i++)
                {
                    DGV.Rows[0].Cells[i + 1].Value = Convert.ToString(i);
                    DGV.Rows[1].Cells[i + 1].Value = Convert.ToString(processPoints[i].Value);
                    DGV.Rows[2].Cells[i + 1].Value = Convert.ToString(processPoints.Take(i+1).Sum(_=>_.Value));
                }
            }
        }
}
