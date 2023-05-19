
namespace DSS
{
    partial class Emv_UC
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
            this.EMV_Dg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EMV_Dg)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Location = new System.Drawing.Point(681, 508);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(137, 36);
            this.Calculate_btn.TabIndex = 6;
            this.Calculate_btn.Values.Text = "Calc";
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // EMV_Dg
            // 
            this.EMV_Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EMV_Dg.Location = new System.Drawing.Point(3, 3);
            this.EMV_Dg.Name = "EMV_Dg";
            this.EMV_Dg.RowHeadersWidth = 51;
            this.EMV_Dg.RowTemplate.Height = 24;
            this.EMV_Dg.Size = new System.Drawing.Size(906, 473);
            this.EMV_Dg.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 7;
            // 
            // Emv_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.EMV_Dg);
            this.Name = "Emv_UC";
            this.Size = new System.Drawing.Size(912, 601);
            ((System.ComponentModel.ISupportInitialize)(this.EMV_Dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton Calculate_btn;
        private System.Windows.Forms.DataGridView EMV_Dg;
        private System.Windows.Forms.Label label1;
    }
}
