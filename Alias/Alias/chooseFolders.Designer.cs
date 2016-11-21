namespace Alias
{
    partial class chooseFolders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chooseFolders));
            this.bgxSteam = new System.Windows.Forms.GroupBox();
            this.btnFolder1 = new System.Windows.Forms.Button();
            this.btnFolder2 = new System.Windows.Forms.Button();
            this.btnFolder3 = new System.Windows.Forms.Button();
            this.lblFolder1 = new System.Windows.Forms.Label();
            this.lblFolder2 = new System.Windows.Forms.Label();
            this.lblFolder3 = new System.Windows.Forms.Label();
            this.folder1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folder2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folder3 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDone = new System.Windows.Forms.Button();
            this.bgxSteam.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgxSteam
            // 
            this.bgxSteam.Controls.Add(this.lblFolder3);
            this.bgxSteam.Controls.Add(this.lblFolder2);
            this.bgxSteam.Controls.Add(this.lblFolder1);
            this.bgxSteam.Controls.Add(this.btnFolder3);
            this.bgxSteam.Controls.Add(this.btnFolder2);
            this.bgxSteam.Controls.Add(this.btnFolder1);
            this.bgxSteam.Location = new System.Drawing.Point(12, 12);
            this.bgxSteam.Name = "bgxSteam";
            this.bgxSteam.Size = new System.Drawing.Size(409, 231);
            this.bgxSteam.TabIndex = 0;
            this.bgxSteam.TabStop = false;
            this.bgxSteam.Text = "Steam";
            // 
            // btnFolder1
            // 
            this.btnFolder1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFolder1.BackgroundImage")));
            this.btnFolder1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFolder1.Location = new System.Drawing.Point(6, 19);
            this.btnFolder1.Name = "btnFolder1";
            this.btnFolder1.Size = new System.Drawing.Size(64, 64);
            this.btnFolder1.TabIndex = 0;
            this.btnFolder1.UseVisualStyleBackColor = true;
            this.btnFolder1.Click += new System.EventHandler(this.btnFolder1_Click);
            // 
            // btnFolder2
            // 
            this.btnFolder2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFolder2.BackgroundImage")));
            this.btnFolder2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFolder2.Enabled = false;
            this.btnFolder2.Location = new System.Drawing.Point(6, 89);
            this.btnFolder2.Name = "btnFolder2";
            this.btnFolder2.Size = new System.Drawing.Size(64, 64);
            this.btnFolder2.TabIndex = 1;
            this.btnFolder2.UseVisualStyleBackColor = true;
            this.btnFolder2.Click += new System.EventHandler(this.btnFolder2_Click);
            // 
            // btnFolder3
            // 
            this.btnFolder3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFolder3.BackgroundImage")));
            this.btnFolder3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFolder3.Enabled = false;
            this.btnFolder3.Location = new System.Drawing.Point(6, 159);
            this.btnFolder3.Name = "btnFolder3";
            this.btnFolder3.Size = new System.Drawing.Size(64, 64);
            this.btnFolder3.TabIndex = 2;
            this.btnFolder3.UseVisualStyleBackColor = true;
            this.btnFolder3.Click += new System.EventHandler(this.btnFolder3_Click);
            // 
            // lblFolder1
            // 
            this.lblFolder1.AutoSize = true;
            this.lblFolder1.Location = new System.Drawing.Point(76, 45);
            this.lblFolder1.Name = "lblFolder1";
            this.lblFolder1.Size = new System.Drawing.Size(0, 13);
            this.lblFolder1.TabIndex = 3;
            // 
            // lblFolder2
            // 
            this.lblFolder2.AutoSize = true;
            this.lblFolder2.Location = new System.Drawing.Point(76, 115);
            this.lblFolder2.Name = "lblFolder2";
            this.lblFolder2.Size = new System.Drawing.Size(0, 13);
            this.lblFolder2.TabIndex = 4;
            // 
            // lblFolder3
            // 
            this.lblFolder3.AutoSize = true;
            this.lblFolder3.Location = new System.Drawing.Point(76, 185);
            this.lblFolder3.Name = "lblFolder3";
            this.lblFolder3.Size = new System.Drawing.Size(0, 13);
            this.lblFolder3.TabIndex = 5;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(376, 249);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(45, 23);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // chooseFolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 286);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.bgxSteam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "chooseFolders";
            this.Text = "Choose Folder";
            this.bgxSteam.ResumeLayout(false);
            this.bgxSteam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bgxSteam;
        private System.Windows.Forms.Button btnFolder2;
        private System.Windows.Forms.Button btnFolder1;
        private System.Windows.Forms.Label lblFolder1;
        private System.Windows.Forms.Button btnFolder3;
        private System.Windows.Forms.Label lblFolder3;
        private System.Windows.Forms.Label lblFolder2;
        private System.Windows.Forms.FolderBrowserDialog folder1;
        private System.Windows.Forms.FolderBrowserDialog folder2;
        private System.Windows.Forms.FolderBrowserDialog folder3;
        private System.Windows.Forms.Button btnDone;
    }
}