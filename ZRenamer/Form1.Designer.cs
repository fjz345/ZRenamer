namespace ZRenamer
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFound = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.tbRegex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbExtensions = new System.Windows.Forms.GroupBox();
            this.cbEnableASS = new System.Windows.Forms.CheckBox();
            this.cbEnableMP4 = new System.Windows.Forms.CheckBox();
            this.cbEnableMKV = new System.Windows.Forms.CheckBox();
            this.lvFound = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbRegexTest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIgnoreExtension = new System.Windows.Forms.CheckBox();
            this.gbExtensions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 40);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(299, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 89);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(299, 20);
            this.tbOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output name(s)";
            // 
            // lbFound
            // 
            this.lbFound.AutoSize = true;
            this.lbFound.Location = new System.Drawing.Point(324, 24);
            this.lbFound.Name = "lbFound";
            this.lbFound.Size = new System.Drawing.Size(58, 13);
            this.lbFound.TabIndex = 5;
            this.lbFound.Text = "Files found";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(12, 462);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(753, 23);
            this.pbProgress.TabIndex = 6;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(104, 11);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 7;
            this.btnChooseFile.Text = "Choose dir";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(291, 415);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(189, 41);
            this.btnRename.TabIndex = 8;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // tbRegex
            // 
            this.tbRegex.Location = new System.Drawing.Point(12, 309);
            this.tbRegex.Name = "tbRegex";
            this.tbRegex.Size = new System.Drawing.Size(358, 20);
            this.tbRegex.TabIndex = 9;
            this.tbRegex.TextChanged += new System.EventHandler(this.tbRegex_TextChanged);
            this.tbRegex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRegex_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Regex";
            // 
            // gbExtensions
            // 
            this.gbExtensions.Controls.Add(this.cbEnableASS);
            this.gbExtensions.Controls.Add(this.cbEnableMP4);
            this.gbExtensions.Controls.Add(this.cbEnableMKV);
            this.gbExtensions.Location = new System.Drawing.Point(655, 332);
            this.gbExtensions.Name = "gbExtensions";
            this.gbExtensions.Size = new System.Drawing.Size(110, 124);
            this.gbExtensions.TabIndex = 12;
            this.gbExtensions.TabStop = false;
            this.gbExtensions.Text = "Extensions";
            // 
            // cbEnableASS
            // 
            this.cbEnableASS.AutoSize = true;
            this.cbEnableASS.Checked = true;
            this.cbEnableASS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnableASS.Location = new System.Drawing.Point(61, 19);
            this.cbEnableASS.Name = "cbEnableASS";
            this.cbEnableASS.Size = new System.Drawing.Size(47, 17);
            this.cbEnableASS.TabIndex = 5;
            this.cbEnableASS.Text = "ASS";
            this.cbEnableASS.UseVisualStyleBackColor = true;
            this.cbEnableASS.CheckedChanged += new System.EventHandler(this.cbEnableASS_CheckedChanged);
            // 
            // cbEnableMP4
            // 
            this.cbEnableMP4.AutoSize = true;
            this.cbEnableMP4.Checked = true;
            this.cbEnableMP4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnableMP4.Location = new System.Drawing.Point(6, 42);
            this.cbEnableMP4.Name = "cbEnableMP4";
            this.cbEnableMP4.Size = new System.Drawing.Size(48, 17);
            this.cbEnableMP4.TabIndex = 1;
            this.cbEnableMP4.Text = "MP4";
            this.cbEnableMP4.UseVisualStyleBackColor = true;
            this.cbEnableMP4.CheckedChanged += new System.EventHandler(this.cbEnableMP4_CheckedChanged);
            // 
            // cbEnableMKV
            // 
            this.cbEnableMKV.AutoSize = true;
            this.cbEnableMKV.Checked = true;
            this.cbEnableMKV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnableMKV.Location = new System.Drawing.Point(6, 19);
            this.cbEnableMKV.Name = "cbEnableMKV";
            this.cbEnableMKV.Size = new System.Drawing.Size(49, 17);
            this.cbEnableMKV.TabIndex = 0;
            this.cbEnableMKV.Text = "MKV";
            this.cbEnableMKV.UseVisualStyleBackColor = true;
            this.cbEnableMKV.CheckedChanged += new System.EventHandler(this.cbEnableMKV_CheckedChanged);
            // 
            // lvFound
            // 
            this.lvFound.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvFound.FullRowSelect = true;
            this.lvFound.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFound.HideSelection = false;
            this.lvFound.Location = new System.Drawing.Point(327, 40);
            this.lvFound.Name = "lvFound";
            this.lvFound.ShowGroups = false;
            this.lvFound.Size = new System.Drawing.Size(438, 254);
            this.lvFound.TabIndex = 13;
            this.lvFound.UseCompatibleStateImageBehavior = false;
            this.lvFound.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 257;
            // 
            // tbRegexTest
            // 
            this.tbRegexTest.Enabled = false;
            this.tbRegexTest.Location = new System.Drawing.Point(12, 335);
            this.tbRegexTest.Name = "tbRegexTest";
            this.tbRegexTest.Size = new System.Drawing.Size(86, 20);
            this.tbRegexTest.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Should see only the episode number";
            // 
            // cbIgnoreExtension
            // 
            this.cbIgnoreExtension.AutoSize = true;
            this.cbIgnoreExtension.Location = new System.Drawing.Point(660, 309);
            this.cbIgnoreExtension.Name = "cbIgnoreExtension";
            this.cbIgnoreExtension.Size = new System.Drawing.Size(105, 17);
            this.cbIgnoreExtension.TabIndex = 6;
            this.cbIgnoreExtension.Text = "Ignore Extension";
            this.cbIgnoreExtension.UseVisualStyleBackColor = true;
            this.cbIgnoreExtension.CheckedChanged += new System.EventHandler(this.cbIgnoreExtension_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 498);
            this.Controls.Add(this.cbIgnoreExtension);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRegexTest);
            this.Controls.Add(this.lvFound);
            this.Controls.Add(this.gbExtensions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRegex);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lbFound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "ZRenamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbExtensions.ResumeLayout(false);
            this.gbExtensions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFound;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox tbRegex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbExtensions;
        private System.Windows.Forms.CheckBox cbEnableMP4;
        private System.Windows.Forms.CheckBox cbEnableMKV;
        private System.Windows.Forms.ListView lvFound;
        private System.Windows.Forms.TextBox tbRegexTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbEnableASS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.CheckBox cbIgnoreExtension;
    }
}

