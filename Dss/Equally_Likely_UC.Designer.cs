
namespace DSS
{
    partial class Equally_Likely_UC
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
            this.Equally_Likely_Dg = new System.Windows.Forms.DataGridView();
            this.Calculate_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Equally_Likely_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Equally_Likely_Dg)).BeginInit();
            this.SuspendLayout();
            // 
            // Equally_Likely_Dg
            // 
            this.Equally_Likely_Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Equally_Likely_Dg.Location = new System.Drawing.Point(3, 3);
            this.Equally_Likely_Dg.Name = "Equally_Likely_Dg";
            this.Equally_Likely_Dg.RowHeadersWidth = 51;
            this.Equally_Likely_Dg.RowTemplate.Height = 24;
            this.Equally_Likely_Dg.Size = new System.Drawing.Size(906, 473);
            this.Equally_Likely_Dg.TabIndex = 0;
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Location = new System.Drawing.Point(691, 520);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(137, 36);
            this.Calculate_btn.TabIndex = 4;
            this.Calculate_btn.Values.Text = "Calc";
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // Equally_Likely_lbl
            // 
            this.Equally_Likely_lbl.AutoSize = true;
            this.Equally_Likely_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equally_Likely_lbl.Location = new System.Drawing.Point(247, 522);
            this.Equally_Likely_lbl.Name = "Equally_Likely_lbl";
            this.Equally_Likely_lbl.Size = new System.Drawing.Size(0, 29);
            this.Equally_Likely_lbl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Equally Likely  :";
            // 
            // Equally_Likely_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Equally_Likely_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.Equally_Likely_Dg);
            this.Name = "Equally_Likely_UC";
            this.Size = new System.Drawing.Size(912, 601);
            ((System.ComponentModel.ISupportInitialize)(this.Equally_Likely_Dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Equally_Likely_Dg;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Calculate_btn;
        private System.Windows.Forms.Label Equally_Likely_lbl;
        private System.Windows.Forms.Label label1;
    }
}
