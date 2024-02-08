
namespace MyTextRedactor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копіюватиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.скасуватиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скасуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виділитиВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колірШрифтуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колірФонуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openicon = new System.Windows.Forms.ToolStripButton();
            this.saveicon = new System.Windows.Forms.ToolStripButton();
            this.copyicon = new System.Windows.Forms.ToolStripButton();
            this.cuticon = new System.Windows.Forms.ToolStripButton();
            this.pasteicon = new System.Windows.Forms.ToolStripButton();
            this.undoicon = new System.Windows.Forms.ToolStripButton();
            this.Parameters = new System.Windows.Forms.ToolStripDropDownButton();
            this.колірШрифтуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.колірФонуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.ContextMenuStrip = this.contextMenuStrip1;
            this.txt.Location = new System.Drawing.Point(12, 73);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(1190, 480);
            this.txt.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копіюватиToolStripMenuItem1,
            this.вирізатиToolStripMenuItem1,
            this.вставитиToolStripMenuItem1,
            this.скасуватиToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 128);
            // 
            // копіюватиToolStripMenuItem1
            // 
            this.копіюватиToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.копіюватиToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.копіюватиToolStripMenuItem1.Name = "копіюватиToolStripMenuItem1";
            this.копіюватиToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.копіюватиToolStripMenuItem1.Text = "Копіювати";
            this.копіюватиToolStripMenuItem1.Click += new System.EventHandler(this.копіюватиToolStripMenuItem_Click);
            // 
            // вирізатиToolStripMenuItem1
            // 
            this.вирізатиToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.вирізатиToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.вирізатиToolStripMenuItem1.Name = "вирізатиToolStripMenuItem1";
            this.вирізатиToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.вирізатиToolStripMenuItem1.Text = "Вирізати";
            this.вирізатиToolStripMenuItem1.Click += new System.EventHandler(this.вирізатиToolStripMenuItem_Click);
            // 
            // вставитиToolStripMenuItem1
            // 
            this.вставитиToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.вставитиToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.вставитиToolStripMenuItem1.Name = "вставитиToolStripMenuItem1";
            this.вставитиToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.вставитиToolStripMenuItem1.Text = "Вставити";
            this.вставитиToolStripMenuItem1.Click += new System.EventHandler(this.вставитиToolStripMenuItem_Click);
            // 
            // скасуватиToolStripMenuItem1
            // 
            this.скасуватиToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.скасуватиToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.скасуватиToolStripMenuItem1.Name = "скасуватиToolStripMenuItem1";
            this.скасуватиToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.скасуватиToolStripMenuItem1.Text = "Скасувати";
            this.скасуватиToolStripMenuItem1.Click += new System.EventHandler(this.скасуватиToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.копіюватиToolStripMenuItem,
            this.вирізатиToolStripMenuItem,
            this.вставитиToolStripMenuItem,
            this.скасуватиToolStripMenuItem,
            this.виділитиВсеToolStripMenuItem,
            this.налаштуванняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.відкритиToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.зберегтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem1,
            this.зберегтиЯкToolStripMenuItem});
            this.зберегтиToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // зберегтиToolStripMenuItem1
            // 
            this.зберегтиToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.зберегтиToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.зберегтиToolStripMenuItem1.Name = "зберегтиToolStripMenuItem1";
            this.зберегтиToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.зберегтиToolStripMenuItem1.Text = "Зберегти";
            this.зберегтиToolStripMenuItem1.Click += new System.EventHandler(this.зберегтиToolStripMenuItem1_Click);
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.зберегтиЯкToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як";
            this.зберегтиЯкToolStripMenuItem.Click += new System.EventHandler(this.зберегтиЯкToolStripMenuItem_Click);
            // 
            // копіюватиToolStripMenuItem
            // 
            this.копіюватиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.копіюватиToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            this.копіюватиToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.копіюватиToolStripMenuItem.Text = "Копіювати";
            this.копіюватиToolStripMenuItem.Click += new System.EventHandler(this.копіюватиToolStripMenuItem_Click);
            // 
            // вирізатиToolStripMenuItem
            // 
            this.вирізатиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.вирізатиToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            this.вирізатиToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.вирізатиToolStripMenuItem.Text = "Вирізати";
            this.вирізатиToolStripMenuItem.Click += new System.EventHandler(this.вирізатиToolStripMenuItem_Click);
            // 
            // вставитиToolStripMenuItem
            // 
            this.вставитиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.вставитиToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            this.вставитиToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.вставитиToolStripMenuItem.Text = "Вставити";
            this.вставитиToolStripMenuItem.Click += new System.EventHandler(this.вставитиToolStripMenuItem_Click);
            // 
            // скасуватиToolStripMenuItem
            // 
            this.скасуватиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.скасуватиToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.скасуватиToolStripMenuItem.Name = "скасуватиToolStripMenuItem";
            this.скасуватиToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.скасуватиToolStripMenuItem.Text = "Скасувати";
            this.скасуватиToolStripMenuItem.Click += new System.EventHandler(this.скасуватиToolStripMenuItem_Click);
            // 
            // виділитиВсеToolStripMenuItem
            // 
            this.виділитиВсеToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.виділитиВсеToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.виділитиВсеToolStripMenuItem.Name = "виділитиВсеToolStripMenuItem";
            this.виділитиВсеToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.виділитиВсеToolStripMenuItem.Text = "Виділити все";
            this.виділитиВсеToolStripMenuItem.Click += new System.EventHandler(this.виділитиВсеToolStripMenuItem_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.налаштуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колірШрифтуToolStripMenuItem,
            this.шрифтToolStripMenuItem,
            this.колірФонуToolStripMenuItem});
            this.налаштуванняToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            // 
            // колірШрифтуToolStripMenuItem
            // 
            this.колірШрифтуToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.колірШрифтуToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.колірШрифтуToolStripMenuItem.Name = "колірШрифтуToolStripMenuItem";
            this.колірШрифтуToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.колірШрифтуToolStripMenuItem.Text = "Колір шрифту";
            this.колірШрифтуToolStripMenuItem.Click += new System.EventHandler(this.колірШрифтуToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.шрифтToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // колірФонуToolStripMenuItem
            // 
            this.колірФонуToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.колірФонуToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.колірФонуToolStripMenuItem.Name = "колірФонуToolStripMenuItem";
            this.колірФонуToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.колірФонуToolStripMenuItem.Text = "Колір фону";
            this.колірФонуToolStripMenuItem.Click += new System.EventHandler(this.колірФонуToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openicon,
            this.saveicon,
            this.copyicon,
            this.cuticon,
            this.pasteicon,
            this.undoicon,
            this.Parameters});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1214, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openicon
            // 
            this.openicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openicon.Image = ((System.Drawing.Image)(resources.GetObject("openicon.Image")));
            this.openicon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openicon.Name = "openicon";
            this.openicon.Size = new System.Drawing.Size(29, 24);
            this.openicon.Text = "Відкрити";
            this.openicon.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // saveicon
            // 
            this.saveicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveicon.Image = ((System.Drawing.Image)(resources.GetObject("saveicon.Image")));
            this.saveicon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveicon.Name = "saveicon";
            this.saveicon.Size = new System.Drawing.Size(29, 24);
            this.saveicon.Text = "Зберегти";
            this.saveicon.Click += new System.EventHandler(this.зберегтиToolStripMenuItem1_Click);
            // 
            // copyicon
            // 
            this.copyicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyicon.Image = ((System.Drawing.Image)(resources.GetObject("copyicon.Image")));
            this.copyicon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyicon.Name = "copyicon";
            this.copyicon.Size = new System.Drawing.Size(29, 24);
            this.copyicon.Text = "Копіювати";
            this.copyicon.Click += new System.EventHandler(this.копіюватиToolStripMenuItem_Click);
            // 
            // cuticon
            // 
            this.cuticon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cuticon.Image = ((System.Drawing.Image)(resources.GetObject("cuticon.Image")));
            this.cuticon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cuticon.Name = "cuticon";
            this.cuticon.Size = new System.Drawing.Size(29, 24);
            this.cuticon.Text = "Вирізати";
            this.cuticon.Click += new System.EventHandler(this.вирізатиToolStripMenuItem_Click);
            // 
            // pasteicon
            // 
            this.pasteicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteicon.Image = ((System.Drawing.Image)(resources.GetObject("pasteicon.Image")));
            this.pasteicon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteicon.Name = "pasteicon";
            this.pasteicon.Size = new System.Drawing.Size(29, 24);
            this.pasteicon.Text = "Вставити";
            this.pasteicon.Click += new System.EventHandler(this.вставитиToolStripMenuItem_Click);
            // 
            // undoicon
            // 
            this.undoicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoicon.Image = ((System.Drawing.Image)(resources.GetObject("undoicon.Image")));
            this.undoicon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoicon.Name = "undoicon";
            this.undoicon.Size = new System.Drawing.Size(29, 24);
            this.undoicon.Text = "Скасувати";
            this.undoicon.Click += new System.EventHandler(this.скасуватиToolStripMenuItem_Click);
            // 
            // Parameters
            // 
            this.Parameters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Parameters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колірШрифтуToolStripMenuItem1,
            this.шрифтToolStripMenuItem1,
            this.колірФонуToolStripMenuItem1});
            this.Parameters.Image = ((System.Drawing.Image)(resources.GetObject("Parameters.Image")));
            this.Parameters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(34, 24);
            this.Parameters.Text = "Налаштування";
            // 
            // колірШрифтуToolStripMenuItem1
            // 
            this.колірШрифтуToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.колірШрифтуToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.колірШрифтуToolStripMenuItem1.Name = "колірШрифтуToolStripMenuItem1";
            this.колірШрифтуToolStripMenuItem1.Size = new System.Drawing.Size(188, 26);
            this.колірШрифтуToolStripMenuItem1.Text = "Колір шрифту";
            this.колірШрифтуToolStripMenuItem1.Click += new System.EventHandler(this.колірШрифтуToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem1
            // 
            this.шрифтToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.шрифтToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.шрифтToolStripMenuItem1.Name = "шрифтToolStripMenuItem1";
            this.шрифтToolStripMenuItem1.Size = new System.Drawing.Size(188, 26);
            this.шрифтToolStripMenuItem1.Text = "Шрифт";
            this.шрифтToolStripMenuItem1.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // колірФонуToolStripMenuItem1
            // 
            this.колірФонуToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.колірФонуToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.колірФонуToolStripMenuItem1.Name = "колірФонуToolStripMenuItem1";
            this.колірФонуToolStripMenuItem1.Size = new System.Drawing.Size(188, 26);
            this.колірФонуToolStripMenuItem1.Text = "Колір фону";
            this.колірФонуToolStripMenuItem1.Click += new System.EventHandler(this.колірФонуToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1214, 565);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyRedactor";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скасуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem виділитиВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem колірШрифтуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem колірФонуToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem скасуватиToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openicon;
        private System.Windows.Forms.ToolStripButton saveicon;
        private System.Windows.Forms.ToolStripButton copyicon;
        private System.Windows.Forms.ToolStripButton cuticon;
        private System.Windows.Forms.ToolStripButton pasteicon;
        private System.Windows.Forms.ToolStripButton undoicon;
        private System.Windows.Forms.ToolStripDropDownButton Parameters;
        private System.Windows.Forms.ToolStripMenuItem колірШрифтуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem колірФонуToolStripMenuItem1;
    }
}

