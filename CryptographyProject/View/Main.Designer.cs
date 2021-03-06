﻿namespace CryptographyProject.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chSaveLocation = new System.Windows.Forms.CheckBox();
            this.btnChangeOutputFolder = new System.Windows.Forms.Button();
            this.btnChangeInputFolder = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.txtInputFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logView = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberThreads = new System.Windows.Forms.TextBox();
            this.threadsNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioDec = new System.Windows.Forms.RadioButton();
            this.radioEnc = new System.Windows.Forms.RadioButton();
            this.listAlgorithms = new System.Windows.Forms.CheckedListBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.dialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.txtNumberAciveThreads = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsNumber)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chSaveLocation);
            this.groupBox1.Controls.Add(this.btnChangeOutputFolder);
            this.groupBox1.Controls.Add(this.btnChangeInputFolder);
            this.groupBox1.Controls.Add(this.txtOutputFolder);
            this.groupBox1.Controls.Add(this.txtInputFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folders";
            // 
            // chSaveLocation
            // 
            this.chSaveLocation.AutoSize = true;
            this.chSaveLocation.Location = new System.Drawing.Point(12, 95);
            this.chSaveLocation.Name = "chSaveLocation";
            this.chSaveLocation.Size = new System.Drawing.Size(109, 17);
            this.chSaveLocation.TabIndex = 5;
            this.chSaveLocation.Text = "Save the location";
            this.chSaveLocation.UseVisualStyleBackColor = true;
            this.chSaveLocation.CheckedChanged += new System.EventHandler(this.chSaveLocation_CheckedChanged);
            // 
            // btnChangeOutputFolder
            // 
            this.btnChangeOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeOutputFolder.Image = global::CryptographyProject.Properties.Resources.folder;
            this.btnChangeOutputFolder.Location = new System.Drawing.Point(456, 67);
            this.btnChangeOutputFolder.Name = "btnChangeOutputFolder";
            this.btnChangeOutputFolder.Size = new System.Drawing.Size(51, 20);
            this.btnChangeOutputFolder.TabIndex = 4;
            this.btnChangeOutputFolder.UseVisualStyleBackColor = true;
            this.btnChangeOutputFolder.Click += new System.EventHandler(this.btnChangeOutputFolder_Click);
            // 
            // btnChangeInputFolder
            // 
            this.btnChangeInputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeInputFolder.Image = global::CryptographyProject.Properties.Resources.folder;
            this.btnChangeInputFolder.Location = new System.Drawing.Point(456, 29);
            this.btnChangeInputFolder.Name = "btnChangeInputFolder";
            this.btnChangeInputFolder.Size = new System.Drawing.Size(51, 20);
            this.btnChangeInputFolder.TabIndex = 1;
            this.btnChangeInputFolder.UseVisualStyleBackColor = true;
            this.btnChangeInputFolder.Click += new System.EventHandler(this.btnChangeInputFolder_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(88, 68);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.Size = new System.Drawing.Size(362, 20);
            this.txtOutputFolder.TabIndex = 3;
            this.txtOutputFolder.Click += new System.EventHandler(this.btnChangeOutputFolder_Click);
            // 
            // txtInputFolder
            // 
            this.txtInputFolder.Location = new System.Drawing.Point(88, 29);
            this.txtInputFolder.Name = "txtInputFolder";
            this.txtInputFolder.ReadOnly = true;
            this.txtInputFolder.Size = new System.Drawing.Size(362, 20);
            this.txtInputFolder.TabIndex = 2;
            this.txtInputFolder.Click += new System.EventHandler(this.btnChangeInputFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input folder:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logView);
            this.groupBox2.Location = new System.Drawing.Point(531, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // logView
            // 
            this.logView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logView.FormattingEnabled = true;
            this.logView.HorizontalScrollbar = true;
            this.logView.Location = new System.Drawing.Point(3, 16);
            this.logView.Name = "logView";
            this.logView.ScrollAlwaysVisible = true;
            this.logView.Size = new System.Drawing.Size(313, 227);
            this.logView.TabIndex = 0;
            this.logView.SelectedIndexChanged += new System.EventHandler(this.logView_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.listAlgorithms);
            this.groupBox3.Location = new System.Drawing.Point(12, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encryption algorithm";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtNumberThreads);
            this.groupBox5.Controls.Add(this.threadsNumber);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(371, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 97);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Threads";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Threads numbers:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNumberThreads
            // 
            this.txtNumberThreads.Location = new System.Drawing.Point(15, 35);
            this.txtNumberThreads.Name = "txtNumberThreads";
            this.txtNumberThreads.Size = new System.Drawing.Size(109, 20);
            this.txtNumberThreads.TabIndex = 6;
            this.txtNumberThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // threadsNumber
            // 
            this.threadsNumber.Location = new System.Drawing.Point(15, 74);
            this.threadsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadsNumber.Name = "threadsNumber";
            this.threadsNumber.Size = new System.Drawing.Size(109, 20);
            this.threadsNumber.TabIndex = 3;
            this.threadsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.threadsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadsNumber.ValueChanged += new System.EventHandler(this.threadsNumber_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number threads on this PC:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioDec);
            this.groupBox4.Controls.Add(this.radioEnc);
            this.groupBox4.Location = new System.Drawing.Point(252, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(112, 97);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Option";
            // 
            // radioDec
            // 
            this.radioDec.AutoSize = true;
            this.radioDec.Location = new System.Drawing.Point(20, 58);
            this.radioDec.Name = "radioDec";
            this.radioDec.Size = new System.Drawing.Size(76, 17);
            this.radioDec.TabIndex = 1;
            this.radioDec.Text = "Decryption";
            this.radioDec.UseVisualStyleBackColor = true;
            this.radioDec.Click += new System.EventHandler(this.radioDec_Click);
            // 
            // radioEnc
            // 
            this.radioEnc.AutoSize = true;
            this.radioEnc.Checked = true;
            this.radioEnc.Location = new System.Drawing.Point(20, 29);
            this.radioEnc.Name = "radioEnc";
            this.radioEnc.Size = new System.Drawing.Size(75, 17);
            this.radioEnc.TabIndex = 0;
            this.radioEnc.TabStop = true;
            this.radioEnc.Text = "Encryption";
            this.radioEnc.UseVisualStyleBackColor = true;
            this.radioEnc.Click += new System.EventHandler(this.radioEnc_Click);
            // 
            // listAlgorithms
            // 
            this.listAlgorithms.CheckOnClick = true;
            this.listAlgorithms.FormattingEnabled = true;
            this.listAlgorithms.Items.AddRange(new object[] {
            "Simple substitution",
            "RC4",
            "TEA",
            "XTEA",
            "TEA_BMP",
            "XTEA_BMP",
            "Knapsack"});
            this.listAlgorithms.Location = new System.Drawing.Point(6, 22);
            this.listAlgorithms.Name = "listAlgorithms";
            this.listAlgorithms.Size = new System.Drawing.Size(240, 94);
            this.listAlgorithms.TabIndex = 1;
            this.listAlgorithms.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listAlgorithms_ItemCheck);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.Green;
            this.btnMain.Location = new System.Drawing.Point(264, 267);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(261, 44);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "S T A R T";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnHistory);
            this.groupBox6.Location = new System.Drawing.Point(12, 267);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(246, 44);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "History";
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(46, 15);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(133, 23);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.Text = "History Flush";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // txtNumberAciveThreads
            // 
            this.txtNumberAciveThreads.Location = new System.Drawing.Point(665, 264);
            this.txtNumberAciveThreads.Name = "txtNumberAciveThreads";
            this.txtNumberAciveThreads.Size = new System.Drawing.Size(182, 20);
            this.txtNumberAciveThreads.TabIndex = 8;
            this.txtNumberAciveThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of active threads:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(665, 295);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(182, 20);
            this.txtTime.TabIndex = 10;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Time finished:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 323);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumberAciveThreads);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography - Dragiša Mitrović , Petar Kovač";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsNumber)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.TextBox txtInputFolder;
        private System.Windows.Forms.Button btnChangeOutputFolder;
        private System.Windows.Forms.Button btnChangeInputFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox logView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.CheckedListBox listAlgorithms;
        private System.Windows.Forms.FolderBrowserDialog dialogFolder;
        private System.Windows.Forms.CheckBox chSaveLocation;
        private System.Windows.Forms.NumericUpDown threadsNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioDec;
        private System.Windows.Forms.RadioButton radioEnc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberThreads;
        private System.Windows.Forms.TextBox txtNumberAciveThreads;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label6;
    }
}