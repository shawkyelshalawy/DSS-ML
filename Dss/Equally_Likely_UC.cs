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
    public partial class Equally_Likely_UC : UserControl
    {
        int rowDg, columnDg;
        public Equally_Likely_UC(int row,int column)
        {
            InitializeComponent();
            Equally_Likely_Dg.RowCount = row;
            Equally_Likely_Dg.ColumnCount = column;
            rowDg = row;
            columnDg = column;
        }

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            List<int> rowSums = new List<int>();
            List<double> rowAverages = new List<double>();

            foreach (DataGridViewRow row in Equally_Likely_Dg.Rows)
            {
                int sum = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() != "")
                    {
                        sum += Convert.ToInt32(cell.Value);
                    }
                }
                rowSums.Add(sum);
                rowAverages.Add((double)sum / row.Cells.Count);
            }
            double maxAverage = rowAverages[0];
            foreach (double item in rowAverages)
            {
                if (item > maxAverage) 
                { 
                    maxAverage = item; 
                }
            }
            Equally_Likely_lbl.Text = maxAverage.ToString();

        }
    }
}
