
namespace CalendarNew
{
    partial class Registration
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
            this.name = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.familystatus = new System.Windows.Forms.TextBox();
            this.entername = new System.Windows.Forms.Label();
            this.enterlastname = new System.Windows.Forms.Label();
            this.entersurname = new System.Windows.Forms.Label();
            this.entersex = new System.Windows.Forms.Label();
            this.enterfamilystatus = new System.Windows.Forms.Label();
            this.enteraddition = new System.Windows.Forms.Label();
            this.addition = new System.Windows.Forms.TextBox();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.enterdateofbirth = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(15, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(326, 22);
            this.name.TabIndex = 0;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(15, 71);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(326, 22);
            this.lastname.TabIndex = 1;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(15, 116);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(326, 22);
            this.surname.TabIndex = 2;
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(15, 161);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(326, 22);
            this.sex.TabIndex = 3;
            // 
            // familystatus
            // 
            this.familystatus.Location = new System.Drawing.Point(15, 206);
            this.familystatus.Name = "familystatus";
            this.familystatus.Size = new System.Drawing.Size(326, 22);
            this.familystatus.TabIndex = 4;
            // 
            // entername
            // 
            this.entername.AutoSize = true;
            this.entername.Location = new System.Drawing.Point(12, 6);
            this.entername.Name = "entername";
            this.entername.Size = new System.Drawing.Size(88, 17);
            this.entername.TabIndex = 5;
            this.entername.Text = "Введіть ім\'я:";
            // 
            // enterlastname
            // 
            this.enterlastname.AutoSize = true;
            this.enterlastname.Location = new System.Drawing.Point(12, 51);
            this.enterlastname.Name = "enterlastname";
            this.enterlastname.Size = new System.Drawing.Size(125, 17);
            this.enterlastname.TabIndex = 6;
            this.enterlastname.Text = "Введіть прізвище:";
            // 
            // entersurname
            // 
            this.entersurname.AutoSize = true;
            this.entersurname.Location = new System.Drawing.Point(12, 96);
            this.entersurname.Name = "entersurname";
            this.entersurname.Size = new System.Drawing.Size(141, 17);
            this.entersurname.TabIndex = 7;
            this.entersurname.Text = "Введіть по-батькові:";
            // 
            // entersex
            // 
            this.entersex.AutoSize = true;
            this.entersex.Location = new System.Drawing.Point(12, 141);
            this.entersex.Name = "entersex";
            this.entersex.Size = new System.Drawing.Size(101, 17);
            this.entersex.TabIndex = 8;
            this.entersex.Text = "Введіть стать:";
            // 
            // enterfamilystatus
            // 
            this.enterfamilystatus.AutoSize = true;
            this.enterfamilystatus.Location = new System.Drawing.Point(12, 186);
            this.enterfamilystatus.Name = "enterfamilystatus";
            this.enterfamilystatus.Size = new System.Drawing.Size(171, 17);
            this.enterfamilystatus.TabIndex = 9;
            this.enterfamilystatus.Text = "Введіть сімейний статус:";
            // 
            // enteraddition
            // 
            this.enteraddition.AutoSize = true;
            this.enteraddition.Location = new System.Drawing.Point(15, 235);
            this.enteraddition.Name = "enteraddition";
            this.enteraddition.Size = new System.Drawing.Size(213, 17);
            this.enteraddition.TabIndex = 10;
            this.enteraddition.Text = "Введіть додаткову інформацію:";
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(15, 256);
            this.addition.Multiline = true;
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(773, 97);
            this.addition.TabIndex = 11;
            // 
            // dateofbirth
            // 
            this.dateofbirth.Location = new System.Drawing.Point(423, 51);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(200, 22);
            this.dateofbirth.TabIndex = 12;
            // 
            // enterdateofbirth
            // 
            this.enterdateofbirth.AutoSize = true;
            this.enterdateofbirth.Location = new System.Drawing.Point(423, 30);
            this.enterdateofbirth.Name = "enterdateofbirth";
            this.enterdateofbirth.Size = new System.Drawing.Size(181, 17);
            this.enterdateofbirth.TabIndex = 13;
            this.enterdateofbirth.Text = "Вкажіть дату народження:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(335, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(362, 404);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 17);
            this.message.TabIndex = 15;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.message);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enterdateofbirth);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.enteraddition);
            this.Controls.Add(this.enterfamilystatus);
            this.Controls.Add(this.entersex);
            this.Controls.Add(this.entersurname);
            this.Controls.Add(this.enterlastname);
            this.Controls.Add(this.entername);
            this.Controls.Add(this.familystatus);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.name);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox familystatus;
        private System.Windows.Forms.Label entername;
        private System.Windows.Forms.Label enterlastname;
        private System.Windows.Forms.Label entersurname;
        private System.Windows.Forms.Label entersex;
        private System.Windows.Forms.Label enterfamilystatus;
        private System.Windows.Forms.Label enteraddition;
        private System.Windows.Forms.TextBox addition;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.Label enterdateofbirth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label message;
    }
}

