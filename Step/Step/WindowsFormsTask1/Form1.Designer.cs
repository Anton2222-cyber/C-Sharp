
namespace WindowsFormsTask1 {
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
			this.buttonLoad = new System.Windows.Forms.Button();
			this.treeView = new System.Windows.Forms.TreeView();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// buttonLoad
			// 
			this.buttonLoad.Location = new System.Drawing.Point(584, 12);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(204, 42);
			this.buttonLoad.TabIndex = 0;
			this.buttonLoad.Text = "Завантажити XML";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// treeView
			// 
			this.treeView.Location = new System.Drawing.Point(12, 12);
			this.treeView.Name = "treeView";
			this.treeView.Size = new System.Drawing.Size(566, 514);
			this.treeView.TabIndex = 1;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 538);
			this.Controls.Add(this.treeView);
			this.Controls.Add(this.buttonLoad);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.TreeView treeView;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

