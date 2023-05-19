using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS
{
    public partial class Min_Max_Regret_UC : UserControl
    {
        int rowDg, columnDg;

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            int rowCount = Min_Max_Regret_Dg.Rows.Count;
            int columnCount = Min_Max_Regret_Dg.Columns.Count;
            double[,] newArray = new double[rowCount, columnCount];

            for (int j = 0; j < columnCount; j++)
            {
                double max = double.MinValue;
                for (int i = 0; i < rowCount; i++)
                {
                    double cellValue = Convert.ToDouble(Min_Max_Regret_Dg.Rows[i].Cells[j].Value);
                    if (cellValue > max)
                    {
                        max = cellValue;
                    }
                }

                for (int i = 0; i < rowCount; i++)
                {
                    double cellValue = Convert.ToDouble(Min_Max_Regret_Dg.Rows[i].Cells[j].Value);
                    newArray[i, j] = max - cellValue;
                }
            }
            List<double> maxValues = new List<double>();
            for (int i = 0; i < rowCount; i++)
            {
                double max = double.MinValue;
                for (int j = 0; j < columnCount; j++)
                {
                    double cellValue = newArray[i, j];
                    if (cellValue > max)
                    {
                        max = cellValue;
                    }
                }
                maxValues.Add(max);
            }
            double Miniregret = maxValues[0];
            for (int i = 0; i < maxValues.Count; i++)
            {
                if (maxValues[i] < Miniregret)
                {
                    Miniregret = maxValues[i];
                }
            }
            Min_Max_Regret_lbl.Text = Miniregret.ToString();

        }

        public Min_Max_Regret_UC(int row,int column)
        {
            InitializeComponent();
            Min_Max_Regret_Dg.RowCount = row;
            Min_Max_Regret_Dg.ColumnCount = column;
            rowDg = row;
            columnDg = column;
        }
    }
}
