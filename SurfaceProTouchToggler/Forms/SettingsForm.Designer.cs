/**
 * Copyright (C) 2014  flamewave000
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>
 * 
 * This program can be used to enable and disable other types of files.
 * By modifying the hardware id in the settings to any other device,
 * the program will effectively toggle that device.
 */
namespace SurfaceProTouchToggler.Forms
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.hardwareIdGroupBox = new System.Windows.Forms.GroupBox();
			this.editHardwareIdButton = new System.Windows.Forms.Button();
			this.deviceListButton = new System.Windows.Forms.Button();
			this.hardwareIdLabel = new System.Windows.Forms.Label();
			this.hardwareIdTextBox = new System.Windows.Forms.TextBox();
			this.displayTextGroupBox = new System.Windows.Forms.GroupBox();
			this.deviceDisabledTextBox = new System.Windows.Forms.TextBox();
			this.deviceDisabledLabel = new System.Windows.Forms.Label();
			this.deviceEnabledTextBox = new System.Windows.Forms.TextBox();
			this.deviceEnabledLabel = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.runAtStartCheckBox = new System.Windows.Forms.CheckBox();
			this.hardwareIdGroupBox.SuspendLayout();
			this.displayTextGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// hardwareIdGroupBox
			// 
			this.hardwareIdGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hardwareIdGroupBox.Controls.Add(this.editHardwareIdButton);
			this.hardwareIdGroupBox.Controls.Add(this.deviceListButton);
			this.hardwareIdGroupBox.Controls.Add(this.hardwareIdLabel);
			this.hardwareIdGroupBox.Controls.Add(this.hardwareIdTextBox);
			this.hardwareIdGroupBox.Location = new System.Drawing.Point(13, 13);
			this.hardwareIdGroupBox.Name = "hardwareIdGroupBox";
			this.hardwareIdGroupBox.Size = new System.Drawing.Size(276, 82);
			this.hardwareIdGroupBox.TabIndex = 0;
			this.hardwareIdGroupBox.TabStop = false;
			this.hardwareIdGroupBox.Text = "Hardware ID";
			// 
			// editHardwareIdButton
			// 
			this.editHardwareIdButton.Location = new System.Drawing.Point(6, 18);
			this.editHardwareIdButton.Name = "editHardwareIdButton";
			this.editHardwareIdButton.Size = new System.Drawing.Size(183, 23);
			this.editHardwareIdButton.TabIndex = 3;
			this.editHardwareIdButton.Text = "Edit Hardware ID";
			this.editHardwareIdButton.UseVisualStyleBackColor = true;
			this.editHardwareIdButton.Click += new System.EventHandler(this.editHardwareIdButton_Click);
			// 
			// deviceListButton
			// 
			this.deviceListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deviceListButton.Location = new System.Drawing.Point(195, 18);
			this.deviceListButton.Name = "deviceListButton";
			this.deviceListButton.Size = new System.Drawing.Size(75, 23);
			this.deviceListButton.TabIndex = 2;
			this.deviceListButton.Text = "Devices";
			this.deviceListButton.UseVisualStyleBackColor = true;
			this.deviceListButton.Click += new System.EventHandler(this.deviceListButton_Click);
			// 
			// hardwareIdLabel
			// 
			this.hardwareIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hardwareIdLabel.AutoSize = true;
			this.hardwareIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hardwareIdLabel.Location = new System.Drawing.Point(7, 47);
			this.hardwareIdLabel.Name = "hardwareIdLabel";
			this.hardwareIdLabel.Size = new System.Drawing.Size(249, 26);
			this.hardwareIdLabel.TabIndex = 1;
			this.hardwareIdLabel.Text = "Warning: Do not change this unless you are sure of\r\nwhat you are doing";
			// 
			// hardwareIdTextBox
			// 
			this.hardwareIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hardwareIdTextBox.Location = new System.Drawing.Point(7, 20);
			this.hardwareIdTextBox.Name = "hardwareIdTextBox";
			this.hardwareIdTextBox.Size = new System.Drawing.Size(182, 20);
			this.hardwareIdTextBox.TabIndex = 0;
			this.hardwareIdTextBox.Visible = false;
			this.hardwareIdTextBox.TextChanged += new System.EventHandler(this.UpdateSaveButton);
			// 
			// displayTextGroupBox
			// 
			this.displayTextGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.displayTextGroupBox.Controls.Add(this.deviceDisabledTextBox);
			this.displayTextGroupBox.Controls.Add(this.deviceDisabledLabel);
			this.displayTextGroupBox.Controls.Add(this.deviceEnabledTextBox);
			this.displayTextGroupBox.Controls.Add(this.deviceEnabledLabel);
			this.displayTextGroupBox.Location = new System.Drawing.Point(13, 101);
			this.displayTextGroupBox.Name = "displayTextGroupBox";
			this.displayTextGroupBox.Size = new System.Drawing.Size(276, 114);
			this.displayTextGroupBox.TabIndex = 1;
			this.displayTextGroupBox.TabStop = false;
			this.displayTextGroupBox.Text = "Display Text";
			// 
			// deviceDisabledTextBox
			// 
			this.deviceDisabledTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.deviceDisabledTextBox.Location = new System.Drawing.Point(7, 86);
			this.deviceDisabledTextBox.Name = "deviceDisabledTextBox";
			this.deviceDisabledTextBox.Size = new System.Drawing.Size(263, 20);
			this.deviceDisabledTextBox.TabIndex = 3;
			this.deviceDisabledTextBox.TextChanged += new System.EventHandler(this.UpdateSaveButton);
			// 
			// deviceDisabledLabel
			// 
			this.deviceDisabledLabel.AutoSize = true;
			this.deviceDisabledLabel.Location = new System.Drawing.Point(7, 70);
			this.deviceDisabledLabel.Name = "deviceDisabledLabel";
			this.deviceDisabledLabel.Size = new System.Drawing.Size(109, 13);
			this.deviceDisabledLabel.TabIndex = 2;
			this.deviceDisabledLabel.Text = "Device Disabled Text";
			// 
			// deviceEnabledTextBox
			// 
			this.deviceEnabledTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.deviceEnabledTextBox.Location = new System.Drawing.Point(7, 37);
			this.deviceEnabledTextBox.Name = "deviceEnabledTextBox";
			this.deviceEnabledTextBox.Size = new System.Drawing.Size(263, 20);
			this.deviceEnabledTextBox.TabIndex = 1;
			this.deviceEnabledTextBox.TextChanged += new System.EventHandler(this.UpdateSaveButton);
			// 
			// deviceEnabledLabel
			// 
			this.deviceEnabledLabel.AutoSize = true;
			this.deviceEnabledLabel.Location = new System.Drawing.Point(7, 20);
			this.deviceEnabledLabel.Name = "deviceEnabledLabel";
			this.deviceEnabledLabel.Size = new System.Drawing.Size(107, 13);
			this.deviceEnabledLabel.TabIndex = 0;
			this.deviceEnabledLabel.Text = "Device Enabled Text";
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Location = new System.Drawing.Point(214, 260);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 0;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveButton.Enabled = false;
			this.saveButton.Location = new System.Drawing.Point(12, 260);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// runAtStartCheckBox
			// 
			this.runAtStartCheckBox.AutoSize = true;
			this.runAtStartCheckBox.Location = new System.Drawing.Point(20, 222);
			this.runAtStartCheckBox.Name = "runAtStartCheckBox";
			this.runAtStartCheckBox.Size = new System.Drawing.Size(178, 17);
			this.runAtStartCheckBox.TabIndex = 5;
			this.runAtStartCheckBox.Text = "Run program at windows startup";
			this.runAtStartCheckBox.UseVisualStyleBackColor = true;
			this.runAtStartCheckBox.CheckedChanged += new System.EventHandler(this.UpdateSaveButton);
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(301, 295);
			this.Controls.Add(this.runAtStartCheckBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.displayTextGroupBox);
			this.Controls.Add(this.hardwareIdGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.hardwareIdGroupBox.ResumeLayout(false);
			this.hardwareIdGroupBox.PerformLayout();
			this.displayTextGroupBox.ResumeLayout(false);
			this.displayTextGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox hardwareIdGroupBox;
		private System.Windows.Forms.Label hardwareIdLabel;
		private System.Windows.Forms.TextBox hardwareIdTextBox;
		private System.Windows.Forms.GroupBox displayTextGroupBox;
		private System.Windows.Forms.TextBox deviceDisabledTextBox;
		private System.Windows.Forms.Label deviceDisabledLabel;
		private System.Windows.Forms.TextBox deviceEnabledTextBox;
		private System.Windows.Forms.Label deviceEnabledLabel;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button deviceListButton;
		private System.Windows.Forms.Button editHardwareIdButton;
		private System.Windows.Forms.CheckBox runAtStartCheckBox;
	}
}