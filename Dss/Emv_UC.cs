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
    public partial class Emv_UC : UserControl
    {
        int rowDg, columnDg;

        public Emv_UC(int row, int column)
        {
            InitializeComponent();
            EMV_Dg.RowCount = row;
            EMV_Dg.ColumnCount = column;
            rowDg = row;
            columnDg = column;
        }


        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            List<double> mylist = new List<double>();
            for (int i = 0; i < rowDg; i++)
            {
                double emv = 0;
                for (int j = 0; j < columnDg; j++)
                {
                    if (j < columnDg)
                    {
                        double valu = Convert.ToDouble(EMV_Dg.Rows[i].Cells[j].Value);
                        double prob = Convert.ToDouble(EMV_Dg.Rows[rowDg].Cells[j].Value);
                        emv = emv + (valu * prob);
                    }
                    if (j == columnDg)
                    {
                        EMV_Dg.Rows[rowDg].Cells[j].Value = emv.ToString();

                    }


                }
                mylist.Add(emv);
                emv = 0;
            }
            label1.Text = "EMV : " + mylist.Max().ToString();
        }
        
    }
}
