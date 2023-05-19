
namespace DSS
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfRows = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.numberOfColumns = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Min_Max_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Min_max_Regret_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.EquallyLikelybtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Max_Max_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.PanelView = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Row       :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(763, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Column :";
            // 
            // numberOfRows
            // 
            this.numberOfRows.Location = new System.Drawing.Point(457, 62);
            this.numberOfRows.Name = "numberOfRows";
            this.numberOfRows.Size = new System.Drawing.Size(143, 27);
            this.numberOfRows.TabIndex = 2;
            // 
            // numberOfColumns
            // 
            this.numberOfColumns.Location = new System.Drawing.Point(910, 62);
            this.numberOfColumns.Name = "numberOfColumns";
            this.numberOfColumns.Size = new System.Drawing.Size(143, 27);
            this.numberOfColumns.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Min_Max_btn);
            this.panel1.Controls.Add(this.Min_max_Regret_btn);
            this.panel1.Controls.Add(this.EquallyLikelybtn);
            this.panel1.Controls.Add(this.Max_Max_btn);
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 736);
            this.panel1.TabIndex = 6;
            // 
            // Min_Max_btn
            // 
            this.Min_Max_btn.Location = new System.Drawing.Point(55, 125);
            this.Min_Max_btn.Name = "Min_Max_btn";
            this.Min_Max_btn.Size = new System.Drawing.Size(136, 63);
            this.Min_Max_btn.TabIndex = 10;
            this.Min_Max_btn.Values.Text = "Min Max";
            this.Min_Max_btn.Click += new System.EventHandler(this.Min_Max_btn_Click);
            // 
            // Min_max_Regret_btn
            // 
            this.Min_max_Regret_btn.Location = new System.Drawing.Point(55, 524);
            this.Min_max_Regret_btn.Name = "Min_max_Regret_btn";
            this.Min_max_Regret_btn.Size = new System.Drawing.Size(136, 63);
            this.Min_max_Regret_btn.TabIndex = 9;
            this.Min_max_Regret_btn.Values.Text = "Min max Regret";
            this.Min_max_Regret_btn.Click += new System.EventHandler(this.Min_max_Regret_btn_Click);
            // 
            // EquallyLikelybtn
            // 
            this.EquallyLikelybtn.Location = new System.Drawing.Point(55, 388);
            this.EquallyLikelybtn.Name = "EquallyLikelybtn";
            this.EquallyLikelybtn.Size = new System.Drawing.Size(136, 63);
            this.EquallyLikelybtn.TabIndex = 8;
            this.EquallyLikelybtn.Values.Text = "Equally likely";
            this.EquallyLikelybtn.Click += new System.EventHandler(this.EquallyLikelybtn_Click);
            // 
            // Max_Max_btn
            // 
            this.Max_Max_btn.Location = new System.Drawing.Point(55, 252);
            this.Max_Max_btn.Name = "Max_Max_btn";
            this.Max_Max_btn.Size = new System.Drawing.Size(136, 63);
            this.Max_Max_btn.TabIndex = 7;
            this.Max_Max_btn.Values.Text = "Max Max";
            this.Max_Max_btn.Click += new System.EventHandler(this.Max_Max_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(13, 13);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(39, 45);
            this.Exit_btn.TabIndex = 6;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // PanelView
            // 
            this.PanelView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelView.Location = new System.Drawing.Point(247, 135);
            this.PanelView.Name = "PanelView";
            this.PanelView.Size = new System.Drawing.Size(912, 601);
            this.PanelView.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1159, 736);
            this.Controls.Add(this.PanelView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numberOfColumns);
            this.Controls.Add(this.numberOfRows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox numberOfRows;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox numberOfColumns;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Min_max_Regret_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton EquallyLikelybtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Max_Max_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Panel PanelView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Min_Max_btn;
    }
}

