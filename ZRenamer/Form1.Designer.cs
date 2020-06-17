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
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.tbRegex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFilterTXT = new System.Windows.Forms.CheckBox();
            this.cbFilterMKV = new System.Windows.Forms.CheckBox();
            this.lvFound = new System.Windows.Forms.ListView();
            this.tbRegexTest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 89);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(299, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 202);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(299, 20);
            this.tbOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input name(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output name(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Found files in same dir";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 462);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(576, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(104, 60);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 7;
            this.btnChooseFile.Text = "Choose file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(209, 415);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(189, 41);
            this.btnRename.TabIndex = 8;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // tbRegex
            // 
            this.tbRegex.Location = new System.Drawing.Point(12, 308);
            this.tbRegex.Name = "tbRegex";
            this.tbRegex.Size = new System.Drawing.Size(358, 20);
            this.tbRegex.TabIndex = 9;
            this.tbRegex.TextChanged += new System.EventHandler(this.tbRegex_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Regex";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFilterTXT);
            this.groupBox1.Controls.Add(this.cbFilterMKV);
            this.groupBox1.Location = new System.Drawing.Point(404, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 147);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbFilterTXT
            // 
            this.cbFilterTXT.AutoSize = true;
            this.cbFilterTXT.Location = new System.Drawing.Point(6, 42);
            this.cbFilterTXT.Name = "cbFilterTXT";
            this.cbFilterTXT.Size = new System.Drawing.Size(47, 17);
            this.cbFilterTXT.TabIndex = 1;
            this.cbFilterTXT.Text = "TXT";
            this.cbFilterTXT.UseVisualStyleBackColor = true;
            this.cbFilterTXT.CheckedChanged += new System.EventHandler(this.cbFilterTXT_CheckedChanged);
            // 
            // cbFilterMKV
            // 
            this.cbFilterMKV.AutoSize = true;
            this.cbFilterMKV.Location = new System.Drawing.Point(6, 19);
            this.cbFilterMKV.Name = "cbFilterMKV";
            this.cbFilterMKV.Size = new System.Drawing.Size(49, 17);
            this.cbFilterMKV.TabIndex = 0;
            this.cbFilterMKV.Text = "MKV";
            this.cbFilterMKV.UseVisualStyleBackColor = true;
            this.cbFilterMKV.CheckedChanged += new System.EventHandler(this.cbFilterMKV_CheckedChanged);
            // 
            // lvFound
            // 
            this.lvFound.GridLines = true;
            this.lvFound.HideSelection = false;
            this.lvFound.Location = new System.Drawing.Point(327, 73);
            this.lvFound.Name = "lvFound";
            this.lvFound.ShowGroups = false;
            this.lvFound.Size = new System.Drawing.Size(261, 220);
            this.lvFound.TabIndex = 13;
            this.lvFound.UseCompatibleStateImageBehavior = false;
            this.lvFound.View = System.Windows.Forms.View.List;
            // 
            // tbRegexTest
            // 
            this.tbRegexTest.Enabled = false;
            this.tbRegexTest.Location = new System.Drawing.Point(12, 334);
            this.tbRegexTest.Name = "tbRegexTest";
            this.tbRegexTest.Size = new System.Drawing.Size(86, 20);
            this.tbRegexTest.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Should see only the episode number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRegexTest);
            this.Controls.Add(this.lvFound);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRegex);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox tbRegex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbFilterTXT;
        private System.Windows.Forms.CheckBox cbFilterMKV;
        private System.Windows.Forms.ListView lvFound;
        private System.Windows.Forms.TextBox tbRegexTest;
        private System.Windows.Forms.Label label5;
    }
}

