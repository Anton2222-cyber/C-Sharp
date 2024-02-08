
namespace WindowsFormsTask3 {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.listBox = new System.Windows.Forms.ListBox();
			this.listBoxDirectoryViewer = new System.Windows.Forms.ListBox();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.buttonUndo = new System.Windows.Forms.Button();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 16;
			this.listBox.Location = new System.Drawing.Point(12, 52);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(204, 228);
			this.listBox.TabIndex = 0;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
			// 
			// listBoxDirectoryViewer
			// 
			this.listBoxDirectoryViewer.ContextMenuStrip = this.contextMenuStrip;
			this.listBoxDirectoryViewer.FormattingEnabled = true;
			this.listBoxDirectoryViewer.ItemHeight = 16;
			this.listBoxDirectoryViewer.Location = new System.Drawing.Point(223, 40);
			this.listBoxDirectoryViewer.Name = "listBoxDirectoryViewer";
			this.listBoxDirectoryViewer.Size = new System.Drawing.Size(718, 548);
			this.listBoxDirectoryViewer.TabIndex = 1;
			this.listBoxDirectoryViewer.DoubleClick += new System.EventHandler(this.listBoxDirectoryViewer_DoubleClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUpdate,
            this.назадToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(140, 52);
			// 
			// ToolStripMenuItemUpdate
			// 
			this.ToolStripMenuItemUpdate.Name = "ToolStripMenuItemUpdate";
			this.ToolStripMenuItemUpdate.Size = new System.Drawing.Size(139, 24);
			this.ToolStripMenuItemUpdate.Text = "Оновити";
			this.ToolStripMenuItemUpdate.Click += new System.EventHandler(this.ToolStripMenuItemUpdate_Click);
			// 
			// назадToolStripMenuItem
			// 
			this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
			this.назадToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
			this.назадToolStripMenuItem.Text = "Назад";
			this.назадToolStripMenuItem.Click += new System.EventHandler(this.buttonUndo_Click);
			// 
			// textBoxPath
			// 
			this.textBoxPath.Location = new System.Drawing.Point(223, 12);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.ReadOnly = true;
			this.textBoxPath.Size = new System.Drawing.Size(718, 22);
			this.textBoxPath.TabIndex = 2;
			// 
			// buttonUndo
			// 
			this.buttonUndo.Location = new System.Drawing.Point(13, 12);
			this.buttonUndo.Name = "buttonUndo";
			this.buttonUndo.Size = new System.Drawing.Size(204, 34);
			this.buttonUndo.TabIndex = 3;
			this.buttonUndo.Text = "Незад";
			this.buttonUndo.UseVisualStyleBackColor = true;
			this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 593);
			this.Controls.Add(this.buttonUndo);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.listBoxDirectoryViewer);
			this.Controls.Add(this.listBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.ListBox listBoxDirectoryViewer;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button buttonUndo;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUpdate;
	}
}

