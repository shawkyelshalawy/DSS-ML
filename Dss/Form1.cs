using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace DSS
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Max_Max_btn_Click(object sender, EventArgs e)
        {
            int row = int.Parse(numberOfRows.Text.ToString());
            int column = int.Parse(numberOfColumns.Text.ToString());

            Max_Max_UC max_Max_UC = new Max_Max_UC(row, column);
            PanelView.Controls.Clear();
            PanelView.Controls.Add(max_Max_UC);
        }

        private void Min_Max_btn_Click(object sender, EventArgs e)
        {
            int row = int.Parse(numberOfRows.Text.ToString());
            int column = int.Parse(numberOfColumns.Text.ToString());

            Min_Max_UC min_Max_UC = new Min_Max_UC(row, column);
            PanelView.Controls.Clear();
            PanelView.Controls.Add(min_Max_UC);

        }

        private void EquallyLikelybtn_Click(object sender, EventArgs e)
        {
            int row = int.Parse(numberOfRows.Text.ToString());
            int column = int.Parse(numberOfColumns.Text.ToString());

            Equally_Likely_UC egaully_Likely_UC = new Equally_Likely_UC(row, column);
            PanelView.Controls.Clear();
            PanelView.Controls.Add(egaully_Likely_UC);

        }

        private void Min_max_Regret_btn_Click(object sender, EventArgs e)
        {
            int row = int.Parse(numberOfRows.Text.ToString());
            int column = int.Parse(numberOfColumns.Text.ToString());

            Min_Max_Regret_UC min_Max_Regret_UC = new Min_Max_Regret_UC(row, column);
            PanelView.Controls.Clear();
            PanelView.Controls.Add(min_Max_Regret_UC);

        }

        private void Emv_btn_Click(object sender, EventArgs e)
        {
            int row = int.Parse(numberOfRows.Text.ToString());
            int column = int.Parse(numberOfColumns.Text.ToString());

            Emv_UC emv_UC_UC = new Emv_UC(row, column);
            PanelView.Controls.Clear();
            PanelView.Controls.Add(emv_UC_UC);

        }
    }
}
