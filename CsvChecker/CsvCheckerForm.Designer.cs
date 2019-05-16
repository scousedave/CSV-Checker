namespace CsvChecker
{
	partial class CsvCheckerForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.qitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutCSVCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.buttonOpenFile = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxfilePath = new System.Windows.Forms.TextBox();
			this.labelColumns = new System.Windows.Forms.Label();
			this.textBoxColumns = new System.Windows.Forms.TextBox();
			this.buttonProcess = new System.Windows.Forms.Button();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.labelLineCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxSeparator = new System.Windows.Forms.TextBox();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Location = new System.Drawing.Point(0, 40);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1275, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuStrip2
			// 
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(1275, 40);
			this.menuStrip2.TabIndex = 1;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// qitToolStripMenuItem
			// 
			this.qitToolStripMenuItem.Name = "qitToolStripMenuItem";
			this.qitToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
			this.qitToolStripMenuItem.Text = "Quit";
			this.qitToolStripMenuItem.Click += new System.EventHandler(this.qitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCSVCheckerToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// aboutCSVCheckerToolStripMenuItem
			// 
			this.aboutCSVCheckerToolStripMenuItem.Name = "aboutCSVCheckerToolStripMenuItem";
			this.aboutCSVCheckerToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
			this.aboutCSVCheckerToolStripMenuItem.Text = "About CSV Checker";
			this.aboutCSVCheckerToolStripMenuItem.Click += new System.EventHandler(this.aboutCSVCheckerToolStripMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "All files|*.*|CSV files|*.csv|Text files|*.txt";
			this.openFileDialog1.RestoreDirectory = true;
			this.openFileDialog1.ShowReadOnly = true;
			this.openFileDialog1.SupportMultiDottedExtensions = true;
			// 
			// buttonOpenFile
			// 
			this.buttonOpenFile.Location = new System.Drawing.Point(971, 168);
			this.buttonOpenFile.Name = "buttonOpenFile";
			this.buttonOpenFile.Size = new System.Drawing.Size(264, 48);
			this.buttonOpenFile.TabIndex = 2;
			this.buttonOpenFile.Text = "Select File To check";
			this.buttonOpenFile.UseVisualStyleBackColor = true;
			this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "File Path";
			// 
			// textBoxfilePath
			// 
			this.textBoxfilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxfilePath.Location = new System.Drawing.Point(211, 90);
			this.textBoxfilePath.Name = "textBoxfilePath";
			this.textBoxfilePath.ReadOnly = true;
			this.textBoxfilePath.Size = new System.Drawing.Size(1024, 31);
			this.textBoxfilePath.TabIndex = 5;
			// 
			// labelColumns
			// 
			this.labelColumns.AutoSize = true;
			this.labelColumns.Location = new System.Drawing.Point(22, 263);
			this.labelColumns.Name = "labelColumns";
			this.labelColumns.Size = new System.Drawing.Size(160, 25);
			this.labelColumns.TabIndex = 6;
			this.labelColumns.Text = "Columns In File";
			// 
			// textBoxColumns
			// 
			this.textBoxColumns.Location = new System.Drawing.Point(211, 263);
			this.textBoxColumns.Name = "textBoxColumns";
			this.textBoxColumns.Size = new System.Drawing.Size(75, 31);
			this.textBoxColumns.TabIndex = 7;
			this.textBoxColumns.Text = "9";
			// 
			// buttonProcess
			// 
			this.buttonProcess.Enabled = false;
			this.buttonProcess.Location = new System.Drawing.Point(1037, 263);
			this.buttonProcess.Name = "buttonProcess";
			this.buttonProcess.Size = new System.Drawing.Size(198, 48);
			this.buttonProcess.TabIndex = 8;
			this.buttonProcess.Text = "Check File";
			this.buttonProcess.UseVisualStyleBackColor = true;
			this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOutput.Location = new System.Drawing.Point(211, 384);
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxOutput.Size = new System.Drawing.Size(1024, 501);
			this.textBoxOutput.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 25);
			this.label2.TabIndex = 10;
			this.label2.Text = "Lines In File";
			// 
			// labelLineCount
			// 
			this.labelLineCount.AutoSize = true;
			this.labelLineCount.Location = new System.Drawing.Point(206, 168);
			this.labelLineCount.Name = "labelLineCount";
			this.labelLineCount.Size = new System.Drawing.Size(24, 25);
			this.labelLineCount.TabIndex = 11;
			this.labelLineCount.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(329, 263);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 25);
			this.label3.TabIndex = 12;
			this.label3.Text = "Column Separator";
			// 
			// textBoxSeparator
			// 
			this.textBoxSeparator.Location = new System.Drawing.Point(520, 260);
			this.textBoxSeparator.Name = "textBoxSeparator";
			this.textBoxSeparator.Size = new System.Drawing.Size(67, 31);
			this.textBoxSeparator.TabIndex = 13;
			this.textBoxSeparator.Text = ",";
			// 
			// CsvCheckerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1275, 940);
			this.Controls.Add(this.textBoxSeparator);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelLineCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.buttonProcess);
			this.Controls.Add(this.textBoxColumns);
			this.Controls.Add(this.labelColumns);
			this.Controls.Add(this.textBoxfilePath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOpenFile);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "CsvCheckerForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "CSV Checker";
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem qitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutCSVCheckerToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button buttonOpenFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxfilePath;
		private System.Windows.Forms.Label labelColumns;
		private System.Windows.Forms.TextBox textBoxColumns;
		private System.Windows.Forms.Button buttonProcess;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelLineCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxSeparator;
	}
}

