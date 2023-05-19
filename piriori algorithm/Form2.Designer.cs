
namespace piriori_algorithm
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDataset = new System.Windows.Forms.TextBox();
            this.textBoxMinSupport = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelFrequentItemsets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDataset
            // 
            this.textBoxDataset.Location = new System.Drawing.Point(193, 41);
            this.textBoxDataset.Multiline = true;
            this.textBoxDataset.Name = "textBoxDataset";
            this.textBoxDataset.Size = new System.Drawing.Size(125, 27);
            this.textBoxDataset.TabIndex = 0;
            // 
            // textBoxMinSupport
            // 
            this.textBoxMinSupport.Location = new System.Drawing.Point(452, 41);
            this.textBoxMinSupport.Multiline = true;
            this.textBoxMinSupport.Name = "textBoxMinSupport";
            this.textBoxMinSupport.Size = new System.Drawing.Size(125, 27);
            this.textBoxMinSupport.TabIndex = 1;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(645, 39);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(94, 29);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "button1";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // labelFrequentItemsets
            // 
            this.labelFrequentItemsets.AutoSize = true;
            this.labelFrequentItemsets.Location = new System.Drawing.Point(863, 44);
            this.labelFrequentItemsets.Name = "labelFrequentItemsets";
            this.labelFrequentItemsets.Size = new System.Drawing.Size(50, 20);
            this.labelFrequentItemsets.TabIndex = 4;
            this.labelFrequentItemsets.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 752);
            this.Controls.Add(this.labelFrequentItemsets);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxMinSupport);
            this.Controls.Add(this.textBoxDataset);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDataset;
        private System.Windows.Forms.TextBox textBoxMinSupport;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelFrequentItemsets;
    }
}