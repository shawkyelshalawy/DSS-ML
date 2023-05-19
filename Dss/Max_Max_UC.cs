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
    public partial class Max_Max_UC : UserControl
    {
        int rowDg, columnDg;
        public Max_Max_UC(int row, int column)
        {
            InitializeComponent();
            Max_Max_dg.RowCount = row;
            Max_Max_dg.ColumnCount = column;
            rowDg = row;
            columnDg = column;
        }

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            int val = int.Parse(Max_Max_dg.Rows[0].Cells[0].Value.ToString());
            List<int> mylist = new List<int>();
            for (int i = 0; i < rowDg; i++)
            {
                for (int j = 1; j < columnDg; j++)
                {
                    if (int.Parse(Max_Max_dg.Rows[i].Cells[j].Value.ToString()) > val)
                    {
                        val = int.Parse(Max_Max_dg.Rows[i].Cells[j].Value.ToString());
                    }
                }
                mylist.Add(val);
            }
            Max_Max_lbl.Text = mylist.Max().ToString();
        }
    }
}
