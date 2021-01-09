namespace MapsQuest_API_Helper
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
            this.tbxExcelFilePath = new System.Windows.Forms.TextBox();
            this.lblExcelFile = new System.Windows.Forms.Label();
            this.tbxColTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.tbxColCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnGetExcelFilePath = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxAPIkey = new System.Windows.Forms.TextBox();
            this.lblAPIKey = new System.Windows.Forms.Label();
            this.tbxLatitudeCol = new System.Windows.Forms.TextBox();
            this.tbxLongitudeCol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxExcelFilePath
            // 
            this.tbxExcelFilePath.Location = new System.Drawing.Point(9, 49);
            this.tbxExcelFilePath.Name = "tbxExcelFilePath";
            this.tbxExcelFilePath.Size = new System.Drawing.Size(440, 20);
            this.tbxExcelFilePath.TabIndex = 0;
            // 
            // lblExcelFile
            // 
            this.lblExcelFile.AutoSize = true;
            this.lblExcelFile.Location = new System.Drawing.Point(12, 33);
            this.lblExcelFile.Name = "lblExcelFile";
            this.lblExcelFile.Size = new System.Drawing.Size(89, 13);
            this.lblExcelFile.TabIndex = 1;
            this.lblExcelFile.Text = "Path to Excel File";
            // 
            // tbxColTown
            // 
            this.tbxColTown.Location = new System.Drawing.Point(10, 51);
            this.tbxColTown.Name = "tbxColTown";
            this.tbxColTown.Size = new System.Drawing.Size(27, 20);
            this.tbxColTown.TabIndex = 0;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(9, 35);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(167, 13);
            this.lblTown.TabIndex = 1;
            this.lblTown.Text = "Column 1: Town/Street/Postcode";
            // 
            // tbxColCountry
            // 
            this.tbxColCountry.Location = new System.Drawing.Point(8, 96);
            this.tbxColCountry.Name = "tbxColCountry";
            this.tbxColCountry.Size = new System.Drawing.Size(27, 20);
            this.tbxColCountry.TabIndex = 0;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(7, 76);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(93, 13);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Column 2: Country";
            // 
            // btnGetExcelFilePath
            // 
            this.btnGetExcelFilePath.Location = new System.Drawing.Point(464, 49);
            this.btnGetExcelFilePath.Name = "btnGetExcelFilePath";
            this.btnGetExcelFilePath.Size = new System.Drawing.Size(66, 19);
            this.btnGetExcelFilePath.TabIndex = 2;
            this.btnGetExcelFilePath.Text = "Open";
            this.btnGetExcelFilePath.UseVisualStyleBackColor = true;
            this.btnGetExcelFilePath.Click += new System.EventHandler(this.btnGetExcelFilePath_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxAPIkey
            // 
            this.tbxAPIkey.Location = new System.Drawing.Point(146, 388);
            this.tbxAPIkey.Name = "tbxAPIkey";
            this.tbxAPIkey.Size = new System.Drawing.Size(170, 20);
            this.tbxAPIkey.TabIndex = 4;
            // 
            // lblAPIKey
            // 
            this.lblAPIKey.AutoSize = true;
            this.lblAPIKey.Location = new System.Drawing.Point(95, 395);
            this.lblAPIKey.Name = "lblAPIKey";
            this.lblAPIKey.Size = new System.Drawing.Size(45, 13);
            this.lblAPIKey.TabIndex = 1;
            this.lblAPIKey.Text = "API Key";
            // 
            // tbxLatitudeCol
            // 
            this.tbxLatitudeCol.Location = new System.Drawing.Point(10, 144);
            this.tbxLatitudeCol.Name = "tbxLatitudeCol";
            this.tbxLatitudeCol.Size = new System.Drawing.Size(27, 20);
            this.tbxLatitudeCol.TabIndex = 0;
            // 
            // tbxLongitudeCol
            // 
            this.tbxLongitudeCol.Location = new System.Drawing.Point(10, 198);
            this.tbxLongitudeCol.Name = "tbxLongitudeCol";
            this.tbxLongitudeCol.Size = new System.Drawing.Size(27, 20);
            this.tbxLongitudeCol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Column 3: Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Column 4: Longitude";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetExcelFilePath);
            this.groupBox1.Controls.Add(this.lblExcelFile);
            this.groupBox1.Controls.Add(this.tbxExcelFilePath);
            this.groupBox1.Location = new System.Drawing.Point(94, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel File - Only 1 Sheet in a workbook";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCountry);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblTown);
            this.groupBox2.Controls.Add(this.tbxLongitudeCol);
            this.groupBox2.Controls.Add(this.tbxLatitudeCol);
            this.groupBox2.Controls.Add(this.tbxColCountry);
            this.groupBox2.Controls.Add(this.tbxColTown);
            this.groupBox2.Location = new System.Drawing.Point(95, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 224);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Column Mapping - Leave Blank for Dynamic Mapping, See Help for More.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Custom Column Mapping: Column A = 1 / Column Z = 26";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(443, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "This is free software but any donations are appreciated - paypal: jackjsmith88@ho" +
    "tmail.co.uk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxAPIkey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAPIKey);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MapQuest GeoCoder for Excel - Jack Smith 2021 - FreeWare";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxExcelFilePath;
        private System.Windows.Forms.Label lblExcelFile;
        private System.Windows.Forms.TextBox tbxColTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox tbxColCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnGetExcelFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxAPIkey;
        private System.Windows.Forms.Label lblAPIKey;
        private System.Windows.Forms.TextBox tbxLatitudeCol;
        private System.Windows.Forms.TextBox tbxLongitudeCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

