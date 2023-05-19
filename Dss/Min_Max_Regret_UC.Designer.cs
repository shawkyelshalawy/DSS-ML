
namespace DSS
{
    partial class Min_Max_Regret_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Min_Max_Regret_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Calculate_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Min_Max_Regret_Dg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Min_Max_Regret_Dg)).BeginInit();
            this.SuspendLayout();
            // 
            // Min_Max_Regret_lbl
            // 
            this.Min_Max_Regret_lbl.AutoSize = true;
            this.Min_Max_Regret_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_Max_Regret_lbl.Location = new System.Drawing.Point(260, 520);
            this.Min_Max_Regret_lbl.Name = "Min_Max_Regret_lbl";
            this.Min_Max_Regret_lbl.Size = new System.Drawing.Size(0, 29);
            this.Min_Max_Regret_lbl.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Min Max Regret  :";
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Location = new System.Drawing.Point(691, 520);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(137, 36);
            this.Calculate_btn.TabIndex = 8;
            this.Calculate_btn.Values.Text = "Calc";
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // Min_Max_Regret_Dg
            // 
            this.Min_Max_Regret_Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Min_Max_Regret_Dg.Location = new System.Drawing.Point(3, 3);
            this.Min_Max_Regret_Dg.Name = "Min_Max_Regret_Dg";
            this.Min_Max_Regret_Dg.RowHeadersWidth = 51;
            this.Min_Max_Regret_Dg.RowTemplate.Height = 24;
            this.Min_Max_Regret_Dg.Size = new System.Drawing.Size(906, 473);
            this.Min_Max_Regret_Dg.TabIndex = 7;
            // 
            // Min_Max_Regret_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Min_Max_Regret_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.Min_Max_Regret_Dg);
            this.Name = "Min_Max_Regret_UC";
            this.Size = new System.Drawing.Size(912, 601);
            ((System.ComponentModel.ISupportInitialize)(this.Min_Max_Regret_Dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Min_Max_Regret_lbl;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Calculate_btn;
        private System.Windows.Forms.DataGridView Min_Max_Regret_Dg;
    }
}
