namespace BinaryDataExtractor
{
	partial class Main
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
			this.connectionGroup = new System.Windows.Forms.GroupBox();
			this.trustedConnectionSelector = new System.Windows.Forms.CheckBox();
			this.passwordInput = new System.Windows.Forms.TextBox();
			this.usernameInput = new System.Windows.Forms.TextBox();
			this.databaseInput = new System.Windows.Forms.TextBox();
			this.serverInput = new System.Windows.Forms.TextBox();
			this.databaseLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.serverLabel = new System.Windows.Forms.Label();
			this.queryGroup = new System.Windows.Forms.GroupBox();
			this.queryInstructions = new System.Windows.Forms.Label();
			this.queryInput = new System.Windows.Forms.TextBox();
			this.outputGroup = new System.Windows.Forms.GroupBox();
			this.folderButton = new System.Windows.Forms.Button();
			this.folderInput = new System.Windows.Forms.TextBox();
			this.exportButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.connectionGroup.SuspendLayout();
			this.queryGroup.SuspendLayout();
			this.outputGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// connectionGroup
			// 
			this.connectionGroup.Controls.Add(this.trustedConnectionSelector);
			this.connectionGroup.Controls.Add(this.passwordInput);
			this.connectionGroup.Controls.Add(this.usernameInput);
			this.connectionGroup.Controls.Add(this.databaseInput);
			this.connectionGroup.Controls.Add(this.serverInput);
			this.connectionGroup.Controls.Add(this.databaseLabel);
			this.connectionGroup.Controls.Add(this.passwordLabel);
			this.connectionGroup.Controls.Add(this.usernameLabel);
			this.connectionGroup.Controls.Add(this.serverLabel);
			this.connectionGroup.Location = new System.Drawing.Point(8, 13);
			this.connectionGroup.Name = "connectionGroup";
			this.connectionGroup.Size = new System.Drawing.Size(608, 123);
			this.connectionGroup.TabIndex = 0;
			this.connectionGroup.TabStop = false;
			this.connectionGroup.Text = "SQL Database Connection";
			// 
			// trustedConnectionSelector
			// 
			this.trustedConnectionSelector.AutoSize = true;
			this.trustedConnectionSelector.Location = new System.Drawing.Point(456, 88);
			this.trustedConnectionSelector.Name = "trustedConnectionSelector";
			this.trustedConnectionSelector.Size = new System.Drawing.Size(141, 17);
			this.trustedConnectionSelector.TabIndex = 4;
			this.trustedConnectionSelector.Text = "Use Trusted Connection";
			this.trustedConnectionSelector.UseVisualStyleBackColor = true;
			this.trustedConnectionSelector.CheckedChanged += new System.EventHandler(this.TrustedConnectionCheckbox_CheckedChanged);
			// 
			// passwordInput
			// 
			this.passwordInput.Location = new System.Drawing.Point(104, 96);
			this.passwordInput.Name = "passwordInput";
			this.passwordInput.PasswordChar = '*';
			this.passwordInput.Size = new System.Drawing.Size(328, 20);
			this.passwordInput.TabIndex = 3;
			this.passwordInput.TextChanged += new System.EventHandler(this.passwordInput_TextChanged);
			// 
			// usernameInput
			// 
			this.usernameInput.Location = new System.Drawing.Point(104, 72);
			this.usernameInput.Name = "usernameInput";
			this.usernameInput.Size = new System.Drawing.Size(328, 20);
			this.usernameInput.TabIndex = 2;
			this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_TextChanged);
			// 
			// databaseInput
			// 
			this.databaseInput.Location = new System.Drawing.Point(104, 48);
			this.databaseInput.Name = "databaseInput";
			this.databaseInput.Size = new System.Drawing.Size(488, 20);
			this.databaseInput.TabIndex = 1;
			this.databaseInput.TextChanged += new System.EventHandler(this.databaseInput_TextChanged);
			// 
			// serverInput
			// 
			this.serverInput.Location = new System.Drawing.Point(104, 24);
			this.serverInput.Name = "serverInput";
			this.serverInput.Size = new System.Drawing.Size(488, 20);
			this.serverInput.TabIndex = 0;
			this.serverInput.TextChanged += new System.EventHandler(this.serverInput_TextChanged);
			// 
			// databaseLabel
			// 
			this.databaseLabel.AutoSize = true;
			this.databaseLabel.Location = new System.Drawing.Point(8, 48);
			this.databaseLabel.Name = "databaseLabel";
			this.databaseLabel.Size = new System.Drawing.Size(87, 13);
			this.databaseLabel.TabIndex = 1;
			this.databaseLabel.Text = "Database Name:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(8, 96);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(56, 13);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "Password:";
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(8, 72);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(55, 13);
			this.usernameLabel.TabIndex = 2;
			this.usernameLabel.Text = "Username";
			// 
			// serverLabel
			// 
			this.serverLabel.AutoSize = true;
			this.serverLabel.Location = new System.Drawing.Point(8, 24);
			this.serverLabel.Name = "serverLabel";
			this.serverLabel.Size = new System.Drawing.Size(72, 13);
			this.serverLabel.TabIndex = 0;
			this.serverLabel.Text = "Server Name:";
			// 
			// queryGroup
			// 
			this.queryGroup.Controls.Add(this.queryInstructions);
			this.queryGroup.Controls.Add(this.queryInput);
			this.queryGroup.Location = new System.Drawing.Point(8, 152);
			this.queryGroup.Name = "queryGroup";
			this.queryGroup.Size = new System.Drawing.Size(608, 408);
			this.queryGroup.TabIndex = 1;
			this.queryGroup.TabStop = false;
			this.queryGroup.Text = "SQL Query";
			this.queryGroup.UseCompatibleTextRendering = true;
			// 
			// queryInstructions
			// 
			this.queryInstructions.AutoSize = true;
			this.queryInstructions.Location = new System.Drawing.Point(16, 272);
			this.queryInstructions.Name = "queryInstructions";
			this.queryInstructions.Size = new System.Drawing.Size(285, 65);
			this.queryInstructions.TabIndex = 1;
			this.queryInstructions.Text = "Use the following aliases within your query.\r\n\r\nFileName:  The column containing " +
    "the name of the file.\r\n\r\nFileData: The column containing the binary data for the" +
    " file.";
			// 
			// queryInput
			// 
			this.queryInput.Location = new System.Drawing.Point(16, 24);
			this.queryInput.Multiline = true;
			this.queryInput.Name = "queryInput";
			this.queryInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.queryInput.Size = new System.Drawing.Size(576, 240);
			this.queryInput.TabIndex = 0;
			this.queryInput.TextChanged += new System.EventHandler(this.queryInput_TextChanged);
			// 
			// outputGroup
			// 
			this.outputGroup.Controls.Add(this.folderButton);
			this.outputGroup.Controls.Add(this.folderInput);
			this.outputGroup.Location = new System.Drawing.Point(8, 576);
			this.outputGroup.Name = "outputGroup";
			this.outputGroup.Size = new System.Drawing.Size(608, 56);
			this.outputGroup.TabIndex = 2;
			this.outputGroup.TabStop = false;
			this.outputGroup.Text = "Output Path";
			// 
			// folderButton
			// 
			this.folderButton.Location = new System.Drawing.Point(520, 22);
			this.folderButton.Name = "folderButton";
			this.folderButton.Size = new System.Drawing.Size(75, 23);
			this.folderButton.TabIndex = 1;
			this.folderButton.Text = "Browse...";
			this.folderButton.UseVisualStyleBackColor = true;
			this.folderButton.Click += new System.EventHandler(this.FolderButton_Click);
			// 
			// folderInput
			// 
			this.folderInput.Location = new System.Drawing.Point(16, 24);
			this.folderInput.Name = "folderInput";
			this.folderInput.Size = new System.Drawing.Size(488, 20);
			this.folderInput.TabIndex = 0;
			// 
			// exportButton
			// 
			this.exportButton.Location = new System.Drawing.Point(440, 648);
			this.exportButton.Name = "exportButton";
			this.exportButton.Size = new System.Drawing.Size(75, 23);
			this.exportButton.TabIndex = 3;
			this.exportButton.Text = "Export";
			this.exportButton.UseVisualStyleBackColor = true;
			this.exportButton.Click += new System.EventHandler(this.ExportButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(528, 648);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 682);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.exportButton);
			this.Controls.Add(this.outputGroup);
			this.Controls.Add(this.queryGroup);
			this.Controls.Add(this.connectionGroup);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Binary Data Extractor";
			this.connectionGroup.ResumeLayout(false);
			this.connectionGroup.PerformLayout();
			this.queryGroup.ResumeLayout(false);
			this.queryGroup.PerformLayout();
			this.outputGroup.ResumeLayout(false);
			this.outputGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox connectionGroup;
		private System.Windows.Forms.Label serverLabel;
		private System.Windows.Forms.Label databaseLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.TextBox passwordInput;
		private System.Windows.Forms.TextBox usernameInput;
		private System.Windows.Forms.TextBox databaseInput;
		private System.Windows.Forms.TextBox serverInput;
		private System.Windows.Forms.GroupBox queryGroup;
		private System.Windows.Forms.TextBox queryInput;
		private System.Windows.Forms.GroupBox outputGroup;
		private System.Windows.Forms.TextBox folderInput;
		private System.Windows.Forms.Button exportButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.CheckBox trustedConnectionSelector;
		private System.Windows.Forms.Label queryInstructions;
		private System.Windows.Forms.Button folderButton;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}

