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
    public partial class Min_Max_UC : UserControl
    {
        int rowDg, columnDg;

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            List<int> mylist = new List<int>();
            for (int i = 0; i < rowDg; i++)
            {
                int val = int.Parse(Min_Max_dg.Rows[i].Cells[0].Value.ToString());
                for (int j = 1; j < columnDg; j++)
                {
                    if (int.Parse(Min_Max_dg.Rows[i].Cells[j].Value.ToString()) < val)
                    {
                        val = int.Parse(Min_Max_dg.Rows[i].Cells[j].Value.ToString());
                    }
                }
                mylist.Add(val);
            }
            Min_Max_lbl.Text = mylist.Max().ToString();
        }

        public Min_Max_UC(int row, int column)
        {
            InitializeComponent();
            Min_Max_dg.RowCount = row;
            Min_Max_dg.ColumnCount = column;
            rowDg = row;
            columnDg = column;
        }
    }
}
