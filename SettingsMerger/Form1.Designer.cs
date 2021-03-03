namespace SettingsMerger
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldSettings = new System.Windows.Forms.TextBox();
            this.txtNewSettings = new System.Windows.Forms.TextBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenOldSettings = new System.Windows.Forms.Button();
            this.btnOpenNewSettings = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.360001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read two settings and merge them...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old settings file -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "New settings file -";
            // 
            // txtOldSettings
            // 
            this.txtOldSettings.Location = new System.Drawing.Point(134, 40);
            this.txtOldSettings.Name = "txtOldSettings";
            this.txtOldSettings.Size = new System.Drawing.Size(261, 25);
            this.txtOldSettings.TabIndex = 3;
            // 
            // txtNewSettings
            // 
            this.txtNewSettings.Location = new System.Drawing.Point(134, 77);
            this.txtNewSettings.Name = "txtNewSettings";
            this.txtNewSettings.Size = new System.Drawing.Size(261, 25);
            this.txtNewSettings.TabIndex = 4;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(320, 108);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 5;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 136);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(487, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(31, 19);
            this.lblStatus.Text = "Idle";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Settings";
            this.openFileDialog.Filter = "Config files (*.config)|*.config|All files (*.*)|*.*";
            this.openFileDialog.Title = "Open Settings config file";
            // 
            // btnOpenOldSettings
            // 
            this.btnOpenOldSettings.Location = new System.Drawing.Point(401, 41);
            this.btnOpenOldSettings.Name = "btnOpenOldSettings";
            this.btnOpenOldSettings.Size = new System.Drawing.Size(75, 23);
            this.btnOpenOldSettings.TabIndex = 7;
            this.btnOpenOldSettings.Text = "Browse...";
            this.btnOpenOldSettings.UseVisualStyleBackColor = true;
            this.btnOpenOldSettings.Click += new System.EventHandler(this.btnOpenOldSettings_Click);
            // 
            // btnOpenNewSettings
            // 
            this.btnOpenNewSettings.Location = new System.Drawing.Point(400, 78);
            this.btnOpenNewSettings.Name = "btnOpenNewSettings";
            this.btnOpenNewSettings.Size = new System.Drawing.Size(75, 23);
            this.btnOpenNewSettings.TabIndex = 8;
            this.btnOpenNewSettings.Text = "Browse...";
            this.btnOpenNewSettings.UseVisualStyleBackColor = true;
            this.btnOpenNewSettings.Click += new System.EventHandler(this.btnOpenNewSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 160);
            this.Controls.Add(this.btnOpenNewSettings);
            this.Controls.Add(this.btnOpenOldSettings);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.txtNewSettings);
            this.Controls.Add(this.txtOldSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.360001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings Merger";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldSettings;
        private System.Windows.Forms.TextBox txtNewSettings;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnOpenOldSettings;
        private System.Windows.Forms.Button btnOpenNewSettings;
    }
}

