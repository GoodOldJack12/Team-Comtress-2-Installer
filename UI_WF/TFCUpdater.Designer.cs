using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class TFCUpdater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.Title_Label = new System.Windows.Forms.Label();
            this.TF2_Dir_Label = new System.Windows.Forms.Label();
            this.TF2Dir_Label_Label = new System.Windows.Forms.Label();
            this.TF2Dir_Button = new System.Windows.Forms.Button();
            this.TCDir_Button = new System.Windows.Forms.Button();
            this.TCDir_Label_Label = new System.Windows.Forms.Label();
            this.TCDir_Label = new System.Windows.Forms.Label();
            this.Directories_Box = new System.Windows.Forms.GroupBox();
            this.TF2Path_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TCPath_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.PatchButton = new System.Windows.Forms.Button();
            this.CleanPatchBox = new System.Windows.Forms.CheckBox();
            this.PatchStatusLabel = new System.Windows.Forms.Label();
            this.PatchStatusLabelLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CleanPatchBoxTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.OverwriteCheckbox = new System.Windows.Forms.CheckBox();
            this.OverwriteTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Directories_Box.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_Label.Font = new System.Drawing.Font("Segoe UI", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Title_Label.Location = new System.Drawing.Point(0, 0);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(800, 450);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "Team Comtress Updater";
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TF2_Dir_Label
            // 
            this.TF2_Dir_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TF2_Dir_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TF2_Dir_Label.Location = new System.Drawing.Point(8, 34);
            this.TF2_Dir_Label.Name = "TF2_Dir_Label";
            this.TF2_Dir_Label.Size = new System.Drawing.Size(705, 31);
            this.TF2_Dir_Label.TabIndex = 1;
            this.TF2_Dir_Label.Text = "none";
            this.TF2_Dir_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TF2Dir_Label_Label
            // 
            this.TF2Dir_Label_Label.Location = new System.Drawing.Point(8, 15);
            this.TF2Dir_Label_Label.Name = "TF2Dir_Label_Label";
            this.TF2Dir_Label_Label.Size = new System.Drawing.Size(77, 19);
            this.TF2Dir_Label_Label.TabIndex = 2;
            this.TF2Dir_Label_Label.Text = "TF2Path";
            this.TF2Dir_Label_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TF2Dir_Button
            // 
            this.TF2Dir_Button.Location = new System.Drawing.Point(720, 35);
            this.TF2Dir_Button.Name = "TF2Dir_Button";
            this.TF2Dir_Button.Size = new System.Drawing.Size(66, 29);
            this.TF2Dir_Button.TabIndex = 3;
            this.TF2Dir_Button.Text = "Select";
            this.TF2Dir_Button.UseVisualStyleBackColor = true;
            this.TF2Dir_Button.Click += new System.EventHandler(this.TF2Dir_Button_Click);
            // 
            // TCDir_Button
            // 
            this.TCDir_Button.Location = new System.Drawing.Point(720, 116);
            this.TCDir_Button.Name = "TCDir_Button";
            this.TCDir_Button.Size = new System.Drawing.Size(66, 29);
            this.TCDir_Button.TabIndex = 6;
            this.TCDir_Button.Text = "Select";
            this.TCDir_Button.UseVisualStyleBackColor = true;
            this.TCDir_Button.Click += new System.EventHandler(this.TCDir_Button_Click);
            // 
            // TCDir_Label_Label
            // 
            this.TCDir_Label_Label.Location = new System.Drawing.Point(8, 97);
            this.TCDir_Label_Label.Name = "TCDir_Label_Label";
            this.TCDir_Label_Label.Size = new System.Drawing.Size(77, 19);
            this.TCDir_Label_Label.TabIndex = 5;
            this.TCDir_Label_Label.Text = "TC2 Path";
            this.TCDir_Label_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TCDir_Label
            // 
            this.TCDir_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TCDir_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCDir_Label.Location = new System.Drawing.Point(8, 116);
            this.TCDir_Label.Name = "TCDir_Label";
            this.TCDir_Label.Size = new System.Drawing.Size(705, 31);
            this.TCDir_Label.TabIndex = 4;
            this.TCDir_Label.Text = "none";
            this.TCDir_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Directories_Box
            // 
            this.Directories_Box.Controls.Add(this.TCDir_Button);
            this.Directories_Box.Controls.Add(this.TCDir_Label_Label);
            this.Directories_Box.Controls.Add(this.TCDir_Label);
            this.Directories_Box.Controls.Add(this.TF2Dir_Button);
            this.Directories_Box.Controls.Add(this.TF2Dir_Label_Label);
            this.Directories_Box.Controls.Add(this.TF2_Dir_Label);
            this.Directories_Box.Dock = System.Windows.Forms.DockStyle.Top;
            this.Directories_Box.Location = new System.Drawing.Point(0, 0);
            this.Directories_Box.Name = "Directories_Box";
            this.Directories_Box.Size = new System.Drawing.Size(800, 162);
            this.Directories_Box.TabIndex = 7;
            this.Directories_Box.TabStop = false;
            this.Directories_Box.Text = "Directories";
            // 
            // TF2Path_Dialog
            // 
            this.TF2Path_Dialog.RootFolder = System.Environment.SpecialFolder.CommonProgramFilesX86;
            // 
            // TCPath_Dialog
            // 
            this.TCPath_Dialog.RootFolder = System.Environment.SpecialFolder.CommonProgramFilesX86;
            // 
            // PatchButton
            // 
            this.PatchButton.Location = new System.Drawing.Point(289, 267);
            this.PatchButton.Name = "PatchButton";
            this.PatchButton.Size = new System.Drawing.Size(222, 58);
            this.PatchButton.TabIndex = 8;
            this.PatchButton.Text = "Patch";
            this.PatchButton.UseVisualStyleBackColor = true;
            this.PatchButton.Click += new System.EventHandler(this.PatchButton_Click);
            // 
            // CleanPatchBox
            // 
            this.CleanPatchBox.Location = new System.Drawing.Point(359, 331);
            this.CleanPatchBox.Name = "CleanPatchBox";
            this.CleanPatchBox.Size = new System.Drawing.Size(79, 40);
            this.CleanPatchBox.TabIndex = 9;
            this.CleanPatchBox.Text = "Clean?";
            this.CleanPatchBoxTooltip.SetToolTip(this.CleanPatchBox, "Delete the TC Directory and start from scratch.");
            this.CleanPatchBox.UseVisualStyleBackColor = true;
            this.CleanPatchBox.CheckedChanged += new System.EventHandler(this.CleanPatchBox_CheckedChanged);
            // 
            // PatchStatusLabel
            // 
            this.PatchStatusLabel.Location = new System.Drawing.Point(65, 40);
            this.PatchStatusLabel.Name = "PatchStatusLabel";
            this.PatchStatusLabel.Size = new System.Drawing.Size(126, 24);
            this.PatchStatusLabel.TabIndex = 10;
            this.PatchStatusLabel.Text = "Idle";
            this.PatchStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatchStatusLabelLabel
            // 
            this.PatchStatusLabelLabel.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.PatchStatusLabelLabel.Location = new System.Drawing.Point(75, 11);
            this.PatchStatusLabelLabel.Name = "PatchStatusLabelLabel";
            this.PatchStatusLabelLabel.Size = new System.Drawing.Size(115, 28);
            this.PatchStatusLabelLabel.TabIndex = 11;
            this.PatchStatusLabelLabel.Text = "Patch Status";
            this.PatchStatusLabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PatchStatusLabelLabel);
            this.groupBox1.Controls.Add(this.PatchStatusLabel);
            this.groupBox1.Location = new System.Drawing.Point(272, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 74);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // OverwriteCheckbox
            // 
            this.OverwriteCheckbox.Location = new System.Drawing.Point(359, 377);
            this.OverwriteCheckbox.Name = "OverwriteCheckbox";
            this.OverwriteCheckbox.Size = new System.Drawing.Size(103, 32);
            this.OverwriteCheckbox.TabIndex = 13;
            this.OverwriteCheckbox.Text = "Overwrite?";
            this.OverwriteTooltip.SetToolTip(this.OverwriteCheckbox, "Copy TF2 files even if they already exist, overwriting the original files");
            this.OverwriteCheckbox.UseVisualStyleBackColor = true;
            this.OverwriteCheckbox.Visible = false;
            // 
            // TFCUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OverwriteCheckbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CleanPatchBox);
            this.Controls.Add(this.PatchButton);
            this.Controls.Add(this.Directories_Box);
            this.Controls.Add(this.Title_Label);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "TFCUpdater";
            this.Text = "Team Comtress 2 Installer";
            this.Directories_Box.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox OverwriteCheckbox;
        private System.Windows.Forms.ToolTip OverwriteTooltip;

        #endregion

        private System.Windows.Forms.FolderBrowserDialog TF2Path_Dialog;
        private System.Windows.Forms.GroupBox Directories_Box;
        private System.Windows.Forms.Label TCDir_Label;
        private System.Windows.Forms.Label TCDir_Label_Label;
        private System.Windows.Forms.Button TCDir_Button;
        private System.Windows.Forms.Button TF2Dir_Button;
        private System.Windows.Forms.Label TF2Dir_Label_Label;
        private System.Windows.Forms.Label TF2_Dir_Label;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.FolderBrowserDialog TCPath_Dialog;
        private System.Windows.Forms.Button PatchButton;
        private System.Windows.Forms.CheckBox CleanPatchBox;
        private System.Windows.Forms.Label PatchStatusLabel;
        private System.Windows.Forms.Label PatchStatusLabelLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private ToolTip CleanPatchBoxTooltip;
    }
}