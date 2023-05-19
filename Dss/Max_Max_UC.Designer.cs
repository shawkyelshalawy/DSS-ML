
namespace DSS
{
    partial class Max_Max_UC
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
            this.Max_Max_dg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Max_Max_lbl = new System.Windows.Forms.Label();
            this.Calculate_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.Max_Max_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // Max_Max_dg
            // 
            this.Max_Max_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Max_Max_dg.Location = new System.Drawing.Point(3, 3);
            this.Max_Max_dg.Name = "Max_Max_dg";
            this.Max_Max_dg.RowHeadersWidth = 51;
            this.Max_Max_dg.RowTemplate.Height = 24;
            this.Max_Max_dg.Size = new System.Drawing.Size(906, 419);
            this.Max_Max_dg.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Max is :";
            // 
            // Max_Max_lbl
            // 
            this.Max_Max_lbl.AutoSize = true;
            this.Max_Max_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_Max_lbl.Location = new System.Drawing.Point(219, 486);
            this.Max_Max_lbl.Name = "Max_Max_lbl";
            this.Max_Max_lbl.Size = new System.Drawing.Size(0, 29);
            this.Max_Max_lbl.TabIndex = 2;
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Location = new System.Drawing.Point(664, 479);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(137, 36);
            this.Calculate_btn.TabIndex = 3;
            this.Calculate_btn.Values.Text = "Calc";
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // Max_Max_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.Max_Max_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Max_Max_dg);
            this.Name = "Max_Max_UC";
            this.Size = new System.Drawing.Size(912, 601);
            ((System.ComponentModel.ISupportInitialize)(this.Max_Max_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Max_Max_dg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Max_Max_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Calculate_btn;
    }
}
