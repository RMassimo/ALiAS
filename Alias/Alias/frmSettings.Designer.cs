namespace Alias
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.nudGameLogoWidth = new System.Windows.Forms.NumericUpDown();
            this.nudGameLogoHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckResolution = new System.Windows.Forms.Button();
            this.rdbWidth = new System.Windows.Forms.RadioButton();
            this.rdbHeight = new System.Windows.Forms.RadioButton();
            this.gbxRound = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGameLogoWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGameLogoHeight)).BeginInit();
            this.gbxRound.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 362);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbxRound);
            this.tabPage1.Controls.Add(this.btnCheckResolution);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudGameLogoHeight);
            this.tabPage1.Controls.Add(this.nudGameLogoWidth);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Folders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the size of the game\'s logo";
            // 
            // nudGameLogoWidth
            // 
            this.nudGameLogoWidth.Location = new System.Drawing.Point(11, 35);
            this.nudGameLogoWidth.Maximum = new decimal(new int[] {
            460,
            0,
            0,
            0});
            this.nudGameLogoWidth.Minimum = new decimal(new int[] {
            115,
            0,
            0,
            0});
            this.nudGameLogoWidth.Name = "nudGameLogoWidth";
            this.nudGameLogoWidth.Size = new System.Drawing.Size(42, 20);
            this.nudGameLogoWidth.TabIndex = 1;
            this.nudGameLogoWidth.Value = new decimal(new int[] {
            230,
            0,
            0,
            0});
            // 
            // nudGameLogoHeight
            // 
            this.nudGameLogoHeight.Location = new System.Drawing.Point(77, 35);
            this.nudGameLogoHeight.Maximum = new decimal(new int[] {
            214,
            0,
            0,
            0});
            this.nudGameLogoHeight.Minimum = new decimal(new int[] {
            53,
            0,
            0,
            0});
            this.nudGameLogoHeight.Name = "nudGameLogoHeight";
            this.nudGameLogoHeight.Size = new System.Drawing.Size(42, 20);
            this.nudGameLogoHeight.TabIndex = 2;
            this.nudGameLogoHeight.Value = new decimal(new int[] {
            107,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            // 
            // btnCheckResolution
            // 
            this.btnCheckResolution.Location = new System.Drawing.Point(297, 35);
            this.btnCheckResolution.Name = "btnCheckResolution";
            this.btnCheckResolution.Size = new System.Drawing.Size(105, 23);
            this.btnCheckResolution.TabIndex = 4;
            this.btnCheckResolution.Text = "Check resolution";
            this.btnCheckResolution.UseVisualStyleBackColor = true;
            this.btnCheckResolution.Click += new System.EventHandler(this.btnCheckResolution_Click);
            // 
            // rdbWidth
            // 
            this.rdbWidth.AutoSize = true;
            this.rdbWidth.Checked = true;
            this.rdbWidth.Location = new System.Drawing.Point(6, 19);
            this.rdbWidth.Name = "rdbWidth";
            this.rdbWidth.Size = new System.Drawing.Size(53, 17);
            this.rdbWidth.TabIndex = 5;
            this.rdbWidth.TabStop = true;
            this.rdbWidth.Text = "Width";
            this.rdbWidth.UseVisualStyleBackColor = true;
            // 
            // rdbHeight
            // 
            this.rdbHeight.AutoSize = true;
            this.rdbHeight.Location = new System.Drawing.Point(65, 19);
            this.rdbHeight.Name = "rdbHeight";
            this.rdbHeight.Size = new System.Drawing.Size(56, 17);
            this.rdbHeight.TabIndex = 6;
            this.rdbHeight.Text = "Height";
            this.rdbHeight.UseVisualStyleBackColor = true;
            // 
            // gbxRound
            // 
            this.gbxRound.Controls.Add(this.rdbWidth);
            this.gbxRound.Controls.Add(this.rdbHeight);
            this.gbxRound.Location = new System.Drawing.Point(408, 25);
            this.gbxRound.Name = "gbxRound";
            this.gbxRound.Size = new System.Drawing.Size(124, 43);
            this.gbxRound.TabIndex = 7;
            this.gbxRound.TabStop = false;
            this.gbxRound.Text = "Round through";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 362);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "ALiAS Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGameLogoWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGameLogoHeight)).EndInit();
            this.gbxRound.ResumeLayout(false);
            this.gbxRound.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nudGameLogoWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudGameLogoHeight;
        private System.Windows.Forms.GroupBox gbxRound;
        private System.Windows.Forms.RadioButton rdbWidth;
        private System.Windows.Forms.RadioButton rdbHeight;
        private System.Windows.Forms.Button btnCheckResolution;
    }
}