namespace _16Lab2 {
    partial class frmTextAnalyzerGUI {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblAnalysis = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Words = new System.Windows.Forms.ColumnHeader();
            this.Count = new System.Windows.Forms.ColumnHeader();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.panel.SuspendLayout();
            this.grpBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnalysis
            // 
            this.lblAnalysis.BackColor = System.Drawing.Color.White;
            this.lblAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnalysis.Location = new System.Drawing.Point(16, 364);
            this.lblAnalysis.Name = "lblAnalysis";
            this.lblAnalysis.Size = new System.Drawing.Size(466, 113);
            this.lblAnalysis.TabIndex = 1;
            this.lblAnalysis.Text = "Result";
            this.lblAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(278, 72);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(611, 359);
            this.textBox1.TabIndex = 4;
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(197, 9);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(0, 21);
            this.lblPurpose.TabIndex = 5;
            this.lblPurpose.Click += new System.EventHandler(this.lblPurpose_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Turquoise;
            this.panel.Controls.Add(this.grpBox2);
            this.panel.Controls.Add(this.lblAnalysis);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(639, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(494, 486);
            this.panel.TabIndex = 6;
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.listView1);
            this.grpBox2.Location = new System.Drawing.Point(3, 37);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Size = new System.Drawing.Size(488, 312);
            this.grpBox2.TabIndex = 4;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Dictionary";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Words,
            this.Count});
            this.listView1.Location = new System.Drawing.Point(13, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(466, 278);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Words
            // 
            this.Words.Text = "Words";
            this.Words.Width = 230;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 230;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(345, 411);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(278, 72);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "&Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // grpBox
            // 
            this.grpBox.BackColor = System.Drawing.Color.Transparent;
            this.grpBox.Location = new System.Drawing.Point(2, 12);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(631, 393);
            this.grpBox.TabIndex = 7;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Text Input";
            // 
            // frmTextAnalyzerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1133, 486);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAnalyze);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTextAnalyzerGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analyzer";
            this.Load += new System.EventHandler(this.frmTextAnalyzerGUI_Load);
            this.panel.ResumeLayout(false);
            this.grpBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblAnalysis;
        private Button btnExit;
        private TextBox textBox1;
        private Label lblPurpose;
        private Panel panel;
        private Button btnAnalyze;
        private GroupBox grpBox;
        private GroupBox grpBox2;
        private ListView listView1;
        private ColumnHeader Words;
        private ColumnHeader Count;
    }
}