namespace GroceryListActivity
{
    partial class Form1
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
            this.GroceryListBox = new System.Windows.Forms.ListBox();
            this.Form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GroceryListBox
            // 
            this.GroceryListBox.FormattingEnabled = true;
            this.GroceryListBox.ItemHeight = 20;
            this.GroceryListBox.Location = new System.Drawing.Point(192, 73);
            this.GroceryListBox.Name = "GroceryListBox";
            this.GroceryListBox.Size = new System.Drawing.Size(368, 184);
            this.GroceryListBox.TabIndex = 0;
            // 
            // Form2
            // 
            this.Form2.Location = new System.Drawing.Point(420, 263);
            this.Form2.Name = "Form2";
            this.Form2.Size = new System.Drawing.Size(140, 32);
            this.Form2.TabIndex = 2;
            this.Form2.Text = "Add Item";
            this.Form2.UseVisualStyleBackColor = true;
            this.Form2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Form2);
            this.Controls.Add(this.GroceryListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GroceryListBox;
        private System.Windows.Forms.Button Form2;
    }
}

