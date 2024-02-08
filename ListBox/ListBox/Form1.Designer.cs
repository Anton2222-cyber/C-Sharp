
namespace ListBox
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.Red;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(12, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(377, 224);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.listBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.ForeColor = System.Drawing.Color.Red;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(407, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(381, 400);
            this.listBox2.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 279);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(389, 22);
            this.txt.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Blue;
            this.Add.ForeColor = System.Drawing.Color.Yellow;
            this.Add.Location = new System.Drawing.Point(55, 333);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(149, 39);
            this.Add.TabIndex = 3;
            this.Add.Text = "AddToListBox";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.Color.Blue;
            this.Copy.ForeColor = System.Drawing.Color.Yellow;
            this.Copy.Location = new System.Drawing.Point(230, 333);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(149, 39);
            this.Copy.TabIndex = 4;
            this.Copy.Text = "CopyFromListBox";
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Blue;
            this.Remove.ForeColor = System.Drawing.Color.Yellow;
            this.Remove.Location = new System.Drawing.Point(115, 396);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(149, 39);
            this.Remove.TabIndex = 5;
            this.Remove.Text = "RemoveSelected";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Remove;
    }
}

