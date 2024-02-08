
namespace ProgressBarMyTest
{
    partial class Test
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
            this.Question = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.RadioButton();
            this.b = new System.Windows.Forms.RadioButton();
            this.c = new System.Windows.Forms.RadioButton();
            this.d = new System.Windows.Forms.RadioButton();
            this.button = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Question.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.ForeColor = System.Drawing.Color.Red;
            this.Question.Location = new System.Drawing.Point(12, 37);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(776, 145);
            this.Question.TabIndex = 0;
            this.Question.Text = "1.Вкажіть комп’ютер, який надає ресурси:";
            // 
            // a
            // 
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a.ForeColor = System.Drawing.Color.Blue;
            this.a.Location = new System.Drawing.Point(35, 185);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(760, 41);
            this.a.TabIndex = 1;
            this.a.TabStop = true;
            this.a.Text = "сервер";
            this.a.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b.ForeColor = System.Drawing.Color.Blue;
            this.b.Location = new System.Drawing.Point(36, 232);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(752, 42);
            this.b.TabIndex = 2;
            this.b.TabStop = true;
            this.b.Text = "клієнт";
            this.b.UseVisualStyleBackColor = true;
            // 
            // c
            // 
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c.ForeColor = System.Drawing.Color.Blue;
            this.c.Location = new System.Drawing.Point(36, 280);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(752, 35);
            this.c.TabIndex = 3;
            this.c.TabStop = true;
            this.c.Text = "робоча станція";
            this.c.UseVisualStyleBackColor = true;
            // 
            // d
            // 
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d.ForeColor = System.Drawing.Color.Blue;
            this.d.Location = new System.Drawing.Point(36, 321);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(753, 23);
            this.d.TabIndex = 4;
            this.d.TabStop = true;
            this.d.Text = "немає правильної відповіді";
            this.d.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Gold;
            this.button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button.Location = new System.Drawing.Point(365, 358);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(93, 42);
            this.button.TabIndex = 5;
            this.button.Text = "Далі";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(35, 406);
            this.progressBar.Maximum = 12;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(753, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 6;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.Question);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.RadioButton a;
        private System.Windows.Forms.RadioButton b;
        private System.Windows.Forms.RadioButton c;
        private System.Windows.Forms.RadioButton d;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

