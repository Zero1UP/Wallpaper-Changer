namespace wallPaperChanger
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_FolderBrowser = new System.Windows.Forms.Button();
            this.txt_WallPaperLocation = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.tmr_RotateImages = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMasked_Seconds = new System.Windows.Forms.MaskedTextBox();
            this.txtMasked_Minute = new System.Windows.Forms.MaskedTextBox();
            this.txtMasked_Hour = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttp_ControlToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_FolderBrowser);
            this.groupBox1.Controls.Add(this.txt_WallPaperLocation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wall Paper Folder";
            // 
            // btn_FolderBrowser
            // 
            this.btn_FolderBrowser.Location = new System.Drawing.Point(157, 20);
            this.btn_FolderBrowser.Name = "btn_FolderBrowser";
            this.btn_FolderBrowser.Size = new System.Drawing.Size(49, 23);
            this.btn_FolderBrowser.TabIndex = 1;
            this.btn_FolderBrowser.Text = "...";
            this.ttp_ControlToolTip.SetToolTip(this.btn_FolderBrowser, "Browse to a folder that has the wallpapers you want to cycle through.");
            this.btn_FolderBrowser.UseVisualStyleBackColor = true;
            this.btn_FolderBrowser.Click += new System.EventHandler(this.btn_FolderBrowser_Click);
            // 
            // txt_WallPaperLocation
            // 
            this.txt_WallPaperLocation.Location = new System.Drawing.Point(7, 20);
            this.txt_WallPaperLocation.Name = "txt_WallPaperLocation";
            this.txt_WallPaperLocation.ReadOnly = true;
            this.txt_WallPaperLocation.Size = new System.Drawing.Size(144, 20);
            this.txt_WallPaperLocation.TabIndex = 0;
            this.ttp_ControlToolTip.SetToolTip(this.txt_WallPaperLocation, "Current location of wallpapers that are going to be cycled through.");
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(19, 146);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tmr_RotateImages
            // 
            this.tmr_RotateImages.Interval = 1000;
            this.tmr_RotateImages.Tick += new System.EventHandler(this.tmr_RotateImages_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMasked_Seconds);
            this.groupBox2.Controls.Add(this.txtMasked_Minute);
            this.groupBox2.Controls.Add(this.txtMasked_Hour);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 69);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interval";
            // 
            // txtMasked_Seconds
            // 
            this.txtMasked_Seconds.Location = new System.Drawing.Point(114, 36);
            this.txtMasked_Seconds.Mask = "00";
            this.txtMasked_Seconds.Name = "txtMasked_Seconds";
            this.txtMasked_Seconds.Size = new System.Drawing.Size(46, 20);
            this.txtMasked_Seconds.TabIndex = 4;
            this.txtMasked_Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttp_ControlToolTip.SetToolTip(this.txtMasked_Seconds, "Enter in how many seconds  you would like the wall papers to cycle.\r\n");
            this.txtMasked_Seconds.TextChanged += new System.EventHandler(this.txtMasked_Seconds_TextChanged);
            // 
            // txtMasked_Minute
            // 
            this.txtMasked_Minute.Location = new System.Drawing.Point(62, 36);
            this.txtMasked_Minute.Mask = "00";
            this.txtMasked_Minute.Name = "txtMasked_Minute";
            this.txtMasked_Minute.Size = new System.Drawing.Size(41, 20);
            this.txtMasked_Minute.TabIndex = 3;
            this.txtMasked_Minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttp_ControlToolTip.SetToolTip(this.txtMasked_Minute, "Enter in how many minutes you would like the wall papers to cycle.");
            this.txtMasked_Minute.TextChanged += new System.EventHandler(this.txtMasked_Minute_TextChanged);
            // 
            // txtMasked_Hour
            // 
            this.txtMasked_Hour.Location = new System.Drawing.Point(6, 36);
            this.txtMasked_Hour.Mask = "00";
            this.txtMasked_Hour.Name = "txtMasked_Hour";
            this.txtMasked_Hour.Size = new System.Drawing.Size(36, 20);
            this.txtMasked_Hour.TabIndex = 2;
            this.txtMasked_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttp_ControlToolTip.SetToolTip(this.txtMasked_Hour, "Enter in how many hours you would like the wall papers to cycle.");
            this.txtMasked_Hour.TextChanged += new System.EventHandler(this.txtMasked_Hour_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 183);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Wall Paper Changer";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_FolderBrowser;
        private System.Windows.Forms.TextBox txt_WallPaperLocation;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Timer tmr_RotateImages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtMasked_Seconds;
        private System.Windows.Forms.MaskedTextBox txtMasked_Minute;
        private System.Windows.Forms.MaskedTextBox txtMasked_Hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttp_ControlToolTip;
    }
}

