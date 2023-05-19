
namespace DSS
{
    partial class Min_Max_UC
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
            this.Calculate_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Min_Max_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Min_Max_dg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Min_Max_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Location = new System.Drawing.Point(664, 479);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(137, 36);
            this.Calculate_btn.TabIndex = 7;
            this.Calculate_btn.Values.Text = "Calc";
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // Min_Max_lbl
            // 
            this.Min_Max_lbl.AutoSize = true;
            this.Min_Max_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_Max_lbl.Location = new System.Drawing.Point(219, 486);
            this.Min_Max_lbl.Name = "Min_Max_lbl";
            this.Min_Max_lbl.Size = new System.Drawing.Size(0, 29);
            this.Min_Max_lbl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Min Max is :";
            // 
            // Min_Max_dg
            // 
            this.Min_Max_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Min_Max_dg.Location = new System.Drawing.Point(3, 3);
            this.Min_Max_dg.Name = "Min_Max_dg";
            this.Min_Max_dg.RowHeadersWidth = 51;
            this.Min_Max_dg.RowTemplate.Height = 24;
            this.Min_Max_dg.Size = new System.Drawing.Size(906, 419);
            this.Min_Max_dg.TabIndex = 4;
            // 
            // Min_Max_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.Min_Max_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Min_Max_dg);
            this.Name = "Min_Max_UC";
            this.Size = new System.Drawing.Size(912, 601);
            ((System.ComponentModel.ISupportInitialize)(this.Min_Max_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton Calculate_btn;
        private System.Windows.Forms.Label Min_Max_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Min_Max_dg;
    }
}
