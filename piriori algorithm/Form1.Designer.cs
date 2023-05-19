
namespace piriori_algorithm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Item_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_item_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Bill_List = new System.Windows.Forms.ListBox();
            this.Item_List_CB = new System.Windows.Forms.CheckedListBox();
            this.Bill_List_btn = new System.Windows.Forms.Button();
            this.Mini_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Item_txt
            // 
            this.Item_txt.Location = new System.Drawing.Point(119, 19);
            this.Item_txt.Name = "Item_txt";
            this.Item_txt.Size = new System.Drawing.Size(125, 27);
            this.Item_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "item";
            // 
            // Add_item_btn
            // 
            this.Add_item_btn.Location = new System.Drawing.Point(294, 18);
            this.Add_item_btn.Name = "Add_item_btn";
            this.Add_item_btn.Size = new System.Drawing.Size(94, 29);
            this.Add_item_btn.TabIndex = 2;
            this.Add_item_btn.Text = "Add";
            this.Add_item_btn.UseVisualStyleBackColor = true;
            this.Add_item_btn.Click += new System.EventHandler(this.Add_item_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(588, 12);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(45, 39);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Bill_List
            // 
            this.Bill_List.FormattingEnabled = true;
            this.Bill_List.ItemHeight = 20;
            this.Bill_List.Location = new System.Drawing.Point(57, 299);
            this.Bill_List.Name = "Bill_List";
            this.Bill_List.Size = new System.Drawing.Size(150, 224);
            this.Bill_List.TabIndex = 5;
            // 
            // Item_List_CB
            // 
            this.Item_List_CB.CheckOnClick = true;
            this.Item_List_CB.FormattingEnabled = true;
            this.Item_List_CB.Location = new System.Drawing.Point(57, 64);
            this.Item_List_CB.Name = "Item_List_CB";
            this.Item_List_CB.Size = new System.Drawing.Size(150, 202);
            this.Item_List_CB.TabIndex = 6;
            // 
            // Bill_List_btn
            // 
            this.Bill_List_btn.Location = new System.Drawing.Point(294, 164);
            this.Bill_List_btn.Name = "Bill_List_btn";
            this.Bill_List_btn.Size = new System.Drawing.Size(94, 29);
            this.Bill_List_btn.TabIndex = 7;
            this.Bill_List_btn.Text = "Add To Bill List";
            this.Bill_List_btn.UseVisualStyleBackColor = true;
            this.Bill_List_btn.Click += new System.EventHandler(this.Bill_List_btn_Click);
            // 
            // Mini_txt
            // 
            this.Mini_txt.Location = new System.Drawing.Point(372, 295);
            this.Mini_txt.Name = "Mini_txt";
            this.Mini_txt.Size = new System.Drawing.Size(125, 27);
            this.Mini_txt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mini Support";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(294, 422);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(94, 29);
            this.Save_btn.TabIndex = 10;
            this.Save_btn.Text = "Start";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mini_txt);
            this.Controls.Add(this.Bill_List_btn);
            this.Controls.Add(this.Item_List_CB);
            this.Controls.Add(this.Bill_List);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Add_item_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Item_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Item_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_item_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.ListBox Bill_List;
        private System.Windows.Forms.CheckedListBox Item_List_CB;
        private System.Windows.Forms.Button Bill_List_btn;
        private System.Windows.Forms.TextBox Mini_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label label3;
    }
}

