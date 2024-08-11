namespace Network_Diagnostics
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.txtIpAddresses = new System.Windows.Forms.TextBox();
			this.clear1 = new System.Windows.Forms.Button();
			this.clear2 = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.txtLogs = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSaveLog = new System.Windows.Forms.Button();
			this.rdoPing = new System.Windows.Forms.RadioButton();
			this.rdoTracert = new System.Windows.Forms.RadioButton();
			this.lblProgress = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTimeTaken = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(88, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP Address(es)";
			// 
			// txtIpAddresses
			// 
			this.txtIpAddresses.Location = new System.Drawing.Point(214, 105);
			this.txtIpAddresses.Name = "txtIpAddresses";
			this.txtIpAddresses.Size = new System.Drawing.Size(426, 22);
			this.txtIpAddresses.TabIndex = 1;
			// 
			// clear1
			// 
			this.clear1.BackColor = System.Drawing.Color.LimeGreen;
			this.clear1.FlatAppearance.BorderSize = 0;
			this.clear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clear1.ForeColor = System.Drawing.Color.Transparent;
			this.clear1.Location = new System.Drawing.Point(646, 100);
			this.clear1.Name = "clear1";
			this.clear1.Size = new System.Drawing.Size(98, 31);
			this.clear1.TabIndex = 2;
			this.clear1.Text = "Clear";
			this.clear1.UseVisualStyleBackColor = false;
			this.clear1.Click += new System.EventHandler(this.clear1_Click);
			// 
			// clear2
			// 
			this.clear2.BackColor = System.Drawing.Color.Crimson;
			this.clear2.FlatAppearance.BorderSize = 0;
			this.clear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clear2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.clear2.Location = new System.Drawing.Point(646, 217);
			this.clear2.Name = "clear2";
			this.clear2.Size = new System.Drawing.Size(98, 31);
			this.clear2.TabIndex = 2;
			this.clear2.Text = "Clear ";
			this.clear2.UseVisualStyleBackColor = false;
			this.clear2.Click += new System.EventHandler(this.clear2_Click);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnStart.FlatAppearance.BorderSize = 0;
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.ForeColor = System.Drawing.Color.SaddleBrown;
			this.btnStart.Location = new System.Drawing.Point(214, 217);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(131, 31);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// txtLogs
			// 
			this.txtLogs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtLogs.Location = new System.Drawing.Point(60, 254);
			this.txtLogs.Multiline = true;
			this.txtLogs.Name = "txtLogs";
			this.txtLogs.ReadOnly = true;
			this.txtLogs.Size = new System.Drawing.Size(764, 399);
			this.txtLogs.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(61, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(434, 40);
			this.label2.TabIndex = 3;
			this.label2.Text = "Perform Network Diagnostics";
			// 
			// btnSaveLog
			// 
			this.btnSaveLog.BackColor = System.Drawing.Color.SeaGreen;
			this.btnSaveLog.FlatAppearance.BorderSize = 0;
			this.btnSaveLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSaveLog.Location = new System.Drawing.Point(416, 217);
			this.btnSaveLog.Name = "btnSaveLog";
			this.btnSaveLog.Size = new System.Drawing.Size(131, 31);
			this.btnSaveLog.TabIndex = 2;
			this.btnSaveLog.Text = "Save";
			this.btnSaveLog.UseVisualStyleBackColor = false;
			this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
			// 
			// rdoPing
			// 
			this.rdoPing.AutoSize = true;
			this.rdoPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoPing.Location = new System.Drawing.Point(214, 159);
			this.rdoPing.Name = "rdoPing";
			this.rdoPing.Size = new System.Drawing.Size(58, 22);
			this.rdoPing.TabIndex = 4;
			this.rdoPing.TabStop = true;
			this.rdoPing.Text = "Ping";
			this.rdoPing.UseVisualStyleBackColor = true;
			// 
			// rdoTracert
			// 
			this.rdoTracert.AutoSize = true;
			this.rdoTracert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoTracert.Location = new System.Drawing.Point(416, 159);
			this.rdoTracert.Name = "rdoTracert";
			this.rdoTracert.Size = new System.Drawing.Size(76, 22);
			this.rdoTracert.TabIndex = 4;
			this.rdoTracert.TabStop = true;
			this.rdoTracert.Text = "Tracert";
			this.rdoTracert.UseVisualStyleBackColor = true;
			// 
			// lblProgress
			// 
			this.lblProgress.AutoSize = true;
			this.lblProgress.Location = new System.Drawing.Point(57, 225);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(111, 16);
			this.lblProgress.TabIndex = 5;
			this.lblProgress.Text = "\" Status: Waiting \"";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(580, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(275, 48);
			this.label3.TabIndex = 6;
			this.label3.Text = "       Note:\r\nSeperate multiple ip addresses with either a\r\ncomma(,) semicolon(;)" +
    " or start on the next line.";
			// 
			// lblTimeTaken
			// 
			this.lblTimeTaken.AutoSize = true;
			this.lblTimeTaken.Location = new System.Drawing.Point(57, 186);
			this.lblTimeTaken.Name = "lblTimeTaken";
			this.lblTimeTaken.Size = new System.Drawing.Size(130, 16);
			this.lblTimeTaken.TabIndex = 7;
			this.lblTimeTaken.Text = "\" Time Taken: 0 ms \"";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.MintCream;
			this.ClientSize = new System.Drawing.Size(888, 687);
			this.Controls.Add(this.lblTimeTaken);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblProgress);
			this.Controls.Add(this.rdoTracert);
			this.Controls.Add(this.rdoPing);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSaveLog);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.clear2);
			this.Controls.Add(this.clear1);
			this.Controls.Add(this.txtLogs);
			this.Controls.Add(this.txtIpAddresses);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Network Diagnostics";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIpAddresses;
		private System.Windows.Forms.Button clear1;
		private System.Windows.Forms.Button clear2;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtLogs;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSaveLog;
		private System.Windows.Forms.RadioButton rdoPing;
		private System.Windows.Forms.RadioButton rdoTracert;
		private System.Windows.Forms.Label lblProgress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTimeTaken;
	}
}

