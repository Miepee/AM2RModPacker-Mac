﻿namespace AM2R_ModPacker
{
    partial class ModPacker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModPacker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ModLabel = new System.Windows.Forms.Label();
            this.ModButton = new System.Windows.Forms.Button();
            this.OriginalLabel = new System.Windows.Forms.Label();
            this.OriginalButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linuxLabel = new System.Windows.Forms.Label();
            this.linuxButton = new System.Windows.Forms.Button();
            this.saveTextBox = new System.Windows.Forms.TextBox();
            this.linuxCheckBox = new System.Windows.Forms.CheckBox();
            this.winSaveButton = new System.Windows.Forms.Button();
            this.ApkLabel = new System.Windows.Forms.Label();
            this.ApkButton = new System.Windows.Forms.Button();
            this.AndroidCheckBox = new System.Windows.Forms.CheckBox();
            this.YYCCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveCheckBox = new System.Windows.Forms.CheckBox();
            this.MusicCheckBox = new System.Windows.Forms.CheckBox();
            this.modNotesTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.modNotesLabel = new System.Windows.Forms.Label();
            this.macLabel = new System.Windows.Forms.Label();
            this.macButton = new System.Windows.Forms.Button();
            this.macCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreateLabel);
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Controls.Add(this.ModLabel);
            this.panel1.Controls.Add(this.ModButton);
            this.panel1.Controls.Add(this.OriginalLabel);
            this.panel1.Controls.Add(this.OriginalButton);
            this.panel1.Location = new System.Drawing.Point(312, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 86);
            this.panel1.TabIndex = 0;
            // 
            // CreateLabel
            // 
            this.CreateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateLabel.Location = new System.Drawing.Point(5, 71);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(283, 13);
            this.CreateLabel.TabIndex = 6;
            this.CreateLabel.Text = "Mod package created!";
            this.CreateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateLabel.Visible = false;
            // 
            // CreateButton
            // 
            this.CreateButton.Enabled = false;
            this.CreateButton.Location = new System.Drawing.Point(3, 45);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(285, 23);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create mod package(s)";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ModLabel
            // 
            this.ModLabel.AutoSize = true;
            this.ModLabel.Location = new System.Drawing.Point(201, 29);
            this.ModLabel.Name = "ModLabel";
            this.ModLabel.Size = new System.Drawing.Size(66, 13);
            this.ModLabel.TabIndex = 4;
            this.ModLabel.Text = "Mod loaded!";
            this.ModLabel.Visible = false;
            // 
            // ModButton
            // 
            this.ModButton.Location = new System.Drawing.Point(177, 3);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(111, 23);
            this.ModButton.TabIndex = 3;
            this.ModButton.Text = "Load modded game";
            this.ModButton.UseVisualStyleBackColor = true;
            this.ModButton.Click += new System.EventHandler(this.ModButton_Click);
            // 
            // OriginalLabel
            // 
            this.OriginalLabel.AutoSize = true;
            this.OriginalLabel.Location = new System.Drawing.Point(28, 29);
            this.OriginalLabel.Name = "OriginalLabel";
            this.OriginalLabel.Size = new System.Drawing.Size(60, 13);
            this.OriginalLabel.TabIndex = 2;
            this.OriginalLabel.Text = "1.1 loaded!";
            this.OriginalLabel.Visible = false;
            // 
            // OriginalButton
            // 
            this.OriginalButton.Location = new System.Drawing.Point(3, 3);
            this.OriginalButton.Name = "OriginalButton";
            this.OriginalButton.Size = new System.Drawing.Size(111, 23);
            this.OriginalButton.TabIndex = 1;
            this.OriginalButton.Text = "Load 1.1";
            this.OriginalButton.UseVisualStyleBackColor = true;
            this.OriginalButton.Click += new System.EventHandler(this.OriginalButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.versionTextBox);
            this.panel2.Controls.Add(this.versionLabel);
            this.panel2.Controls.Add(this.AuthorTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 77);
            this.panel2.TabIndex = 1;
            // 
            // versionTextBox
            // 
            this.versionTextBox.Location = new System.Drawing.Point(63, 50);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(225, 20);
            this.versionTextBox.TabIndex = 12;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(2, 53);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 13);
            this.versionLabel.TabIndex = 11;
            this.versionLabel.Text = "Version:";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(63, 28);
            this.AuthorTextBox.MaxLength = 30;
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(225, 20);
            this.AuthorTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Author:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(63, 6);
            this.NameTextBox.MaxLength = 30;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(225, 20);
            this.NameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mod name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.macLabel);
            this.panel3.Controls.Add(this.linuxLabel);
            this.panel3.Controls.Add(this.linuxButton);
            this.panel3.Controls.Add(this.macButton);
            this.panel3.Controls.Add(this.macCheckBox);
            this.panel3.Controls.Add(this.saveTextBox);
            this.panel3.Controls.Add(this.linuxCheckBox);
            this.panel3.Controls.Add(this.winSaveButton);
            this.panel3.Controls.Add(this.ApkLabel);
            this.panel3.Controls.Add(this.ApkButton);
            this.panel3.Controls.Add(this.AndroidCheckBox);
            this.panel3.Controls.Add(this.YYCCheckBox);
            this.panel3.Controls.Add(this.SaveCheckBox);
            this.panel3.Controls.Add(this.MusicCheckBox);
            this.panel3.Location = new System.Drawing.Point(309, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 225);
            this.panel3.TabIndex = 2;
            // 
            // linuxLabel
            // 
            this.linuxLabel.AutoSize = true;
            this.linuxLabel.Location = new System.Drawing.Point(147, 164);
            this.linuxLabel.Name = "linuxLabel";
            this.linuxLabel.Size = new System.Drawing.Size(141, 13);
            this.linuxLabel.TabIndex = 18;
            this.linuxLabel.Text = "Modded Linux game loaded!";
            this.linuxLabel.Visible = false;
            // 
            // linuxButton
            // 
            this.linuxButton.Enabled = false;
            this.linuxButton.Location = new System.Drawing.Point(3, 159);
            this.linuxButton.Name = "linuxButton";
            this.linuxButton.Size = new System.Drawing.Size(143, 23);
            this.linuxButton.TabIndex = 17;
            this.linuxButton.Text = "Load modded Linux .zip";
            this.linuxButton.UseVisualStyleBackColor = true;
            this.linuxButton.Click += new System.EventHandler(this.linuxButton_Click);
            // 
            // saveTextBox
            // 
            this.saveTextBox.Enabled = false;
            this.saveTextBox.Location = new System.Drawing.Point(4, 28);
            this.saveTextBox.Name = "saveTextBox";
            this.saveTextBox.Size = new System.Drawing.Size(283, 20);
            this.saveTextBox.TabIndex = 15;
            // 
            // linuxCheckBox
            // 
            this.linuxCheckBox.AutoSize = true;
            this.linuxCheckBox.Location = new System.Drawing.Point(4, 141);
            this.linuxCheckBox.Name = "linuxCheckBox";
            this.linuxCheckBox.Size = new System.Drawing.Size(96, 17);
            this.linuxCheckBox.TabIndex = 12;
            this.linuxCheckBox.Text = "Supports Linux";
            this.linuxCheckBox.UseVisualStyleBackColor = true;
            this.linuxCheckBox.CheckedChanged += new System.EventHandler(this.linuxCheckBox_CheckedChanged);
            // 
            // winSaveButton
            // 
            this.winSaveButton.Enabled = false;
            this.winSaveButton.Location = new System.Drawing.Point(177, 7);
            this.winSaveButton.Name = "winSaveButton";
            this.winSaveButton.Size = new System.Drawing.Size(111, 19);
            this.winSaveButton.TabIndex = 10;
            this.winSaveButton.Text = "Select folder";
            this.winSaveButton.UseVisualStyleBackColor = true;
            this.winSaveButton.Click += new System.EventHandler(this.CustomSaveDataButton_Click);
            // 
            // ApkLabel
            // 
            this.ApkLabel.AutoSize = true;
            this.ApkLabel.Location = new System.Drawing.Point(180, 120);
            this.ApkLabel.Name = "ApkLabel";
            this.ApkLabel.Size = new System.Drawing.Size(108, 13);
            this.ApkLabel.TabIndex = 7;
            this.ApkLabel.Text = "Modded APK loaded!";
            this.ApkLabel.Visible = false;
            // 
            // ApkButton
            // 
            this.ApkButton.Enabled = false;
            this.ApkButton.Location = new System.Drawing.Point(3, 115);
            this.ApkButton.Name = "ApkButton";
            this.ApkButton.Size = new System.Drawing.Size(143, 23);
            this.ApkButton.TabIndex = 6;
            this.ApkButton.Text = "Load modded Android APK";
            this.ApkButton.UseVisualStyleBackColor = true;
            this.ApkButton.Click += new System.EventHandler(this.ApkButton_Click);
            // 
            // AndroidCheckBox
            // 
            this.AndroidCheckBox.AutoSize = true;
            this.AndroidCheckBox.Location = new System.Drawing.Point(4, 95);
            this.AndroidCheckBox.Name = "AndroidCheckBox";
            this.AndroidCheckBox.Size = new System.Drawing.Size(107, 17);
            this.AndroidCheckBox.TabIndex = 5;
            this.AndroidCheckBox.Text = "Supports Android";
            this.AndroidCheckBox.UseVisualStyleBackColor = true;
            this.AndroidCheckBox.CheckedChanged += new System.EventHandler(this.AndroidCheckBox_CheckedChanged);
            // 
            // YYCCheckBox
            // 
            this.YYCCheckBox.AutoSize = true;
            this.YYCCheckBox.Location = new System.Drawing.Point(4, 74);
            this.YYCCheckBox.Name = "YYCCheckBox";
            this.YYCCheckBox.Size = new System.Drawing.Size(140, 17);
            this.YYCCheckBox.TabIndex = 4;
            this.YYCCheckBox.Text = "Uses the YoYo Compiler";
            this.YYCCheckBox.UseVisualStyleBackColor = true;
            this.YYCCheckBox.CheckedChanged += new System.EventHandler(this.YYCCheckBox_CheckedChanged);
            // 
            // SaveCheckBox
            // 
            this.SaveCheckBox.AutoSize = true;
            this.SaveCheckBox.Location = new System.Drawing.Point(4, 8);
            this.SaveCheckBox.Name = "SaveCheckBox";
            this.SaveCheckBox.Size = new System.Drawing.Size(156, 17);
            this.SaveCheckBox.TabIndex = 3;
            this.SaveCheckBox.Text = "Uses custom save directory";
            this.SaveCheckBox.UseVisualStyleBackColor = true;
            this.SaveCheckBox.CheckedChanged += new System.EventHandler(this.SaveCheckBox_CheckedChanged);
            // 
            // MusicCheckBox
            // 
            this.MusicCheckBox.AutoSize = true;
            this.MusicCheckBox.Location = new System.Drawing.Point(4, 52);
            this.MusicCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.MusicCheckBox.Name = "MusicCheckBox";
            this.MusicCheckBox.Size = new System.Drawing.Size(117, 17);
            this.MusicCheckBox.TabIndex = 2;
            this.MusicCheckBox.Text = "Uses custom music";
            this.MusicCheckBox.UseVisualStyleBackColor = true;
            // 
            // modNotesTextBox
            // 
            this.modNotesTextBox.Location = new System.Drawing.Point(3, 16);
            this.modNotesTextBox.Multiline = true;
            this.modNotesTextBox.Name = "modNotesTextBox";
            this.modNotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.modNotesTextBox.Size = new System.Drawing.Size(284, 221);
            this.modNotesTextBox.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.modNotesLabel);
            this.panel4.Controls.Add(this.modNotesTextBox);
            this.panel4.Location = new System.Drawing.Point(12, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 237);
            this.panel4.TabIndex = 4;
            // 
            // modNotesLabel
            // 
            this.modNotesLabel.AutoSize = true;
            this.modNotesLabel.Location = new System.Drawing.Point(2, 0);
            this.modNotesLabel.Name = "modNotesLabel";
            this.modNotesLabel.Size = new System.Drawing.Size(60, 13);
            this.modNotesLabel.TabIndex = 4;
            this.modNotesLabel.Text = "Mod notes:";
            // 
            // macLabel
            // 
            this.macLabel.AutoSize = true;
            this.macLabel.Location = new System.Drawing.Point(148, 207);
            this.macLabel.Name = "macLabel";
            this.macLabel.Size = new System.Drawing.Size(137, 13);
            this.macLabel.TabIndex = 21;
            this.macLabel.Text = "Modded Mac game loaded!";
            this.macLabel.Visible = false;
            // 
            // macButton
            // 
            this.macButton.Enabled = false;
            this.macButton.Location = new System.Drawing.Point(4, 202);
            this.macButton.Name = "macButton";
            this.macButton.Size = new System.Drawing.Size(143, 23);
            this.macButton.TabIndex = 20;
            this.macButton.Text = "Load modded Mac .zip";
            this.macButton.UseVisualStyleBackColor = true;
            this.macButton.Click += new System.EventHandler(this.macButton_Click);
            // 
            // macCheckBox
            // 
            this.macCheckBox.AutoSize = true;
            this.macCheckBox.Location = new System.Drawing.Point(5, 184);
            this.macCheckBox.Name = "macCheckBox";
            this.macCheckBox.Size = new System.Drawing.Size(92, 17);
            this.macCheckBox.TabIndex = 19;
            this.macCheckBox.Text = "Supports Mac";
            this.macCheckBox.UseVisualStyleBackColor = true;
            this.macCheckBox.CheckedChanged += new System.EventHandler(this.macCheckBox_CheckedChanged);
            // 
            // ModPacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 329);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(631, 368);
            this.MinimumSize = new System.Drawing.Size(631, 368);
            this.Name = "ModPacker";
            this.Text = "AM2R ModPacker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OriginalLabel;
        private System.Windows.Forms.Button OriginalButton;
        private System.Windows.Forms.Label ModLabel;
        private System.Windows.Forms.Button ModButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ApkButton;
        private System.Windows.Forms.CheckBox AndroidCheckBox;
        private System.Windows.Forms.CheckBox YYCCheckBox;
        private System.Windows.Forms.CheckBox SaveCheckBox;
        private System.Windows.Forms.CheckBox MusicCheckBox;
        private System.Windows.Forms.Label ApkLabel;
        private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.Button winSaveButton;
        private System.Windows.Forms.TextBox saveTextBox;
        private System.Windows.Forms.CheckBox linuxCheckBox;
        private System.Windows.Forms.Button linuxButton;
        private System.Windows.Forms.Label linuxLabel;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TextBox modNotesTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label modNotesLabel;
        private System.Windows.Forms.Label macLabel;
        private System.Windows.Forms.Button macButton;
        private System.Windows.Forms.CheckBox macCheckBox;
    }
}

