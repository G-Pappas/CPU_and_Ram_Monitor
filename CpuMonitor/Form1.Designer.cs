namespace CpuMonitor
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Windows.Forms.Label();
            this.RamAvailableByts = new System.Windows.Forms.Label();
            this.SystemUpTime = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available Memory:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "System Up Time:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CPU
            // 
            this.CPU.AutoSize = true;
            this.CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CPU.Location = new System.Drawing.Point(184, 24);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(21, 20);
            this.CPU.TabIndex = 3;
            this.CPU.Text = "...";
            // 
            // RamAvailableByts
            // 
            this.RamAvailableByts.AutoSize = true;
            this.RamAvailableByts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RamAvailableByts.Location = new System.Drawing.Point(184, 81);
            this.RamAvailableByts.Name = "RamAvailableByts";
            this.RamAvailableByts.Size = new System.Drawing.Size(21, 20);
            this.RamAvailableByts.TabIndex = 4;
            this.RamAvailableByts.Text = "...";
            // 
            // SystemUpTime
            // 
            this.SystemUpTime.AutoSize = true;
            this.SystemUpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SystemUpTime.Location = new System.Drawing.Point(184, 122);
            this.SystemUpTime.Name = "SystemUpTime";
            this.SystemUpTime.Size = new System.Drawing.Size(21, 20);
            this.SystemUpTime.TabIndex = 5;
            this.SystemUpTime.Text = "...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 47);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(413, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // info
            // 
            this.info.BackgroundImage = global::CpuMonitor.Properties.Resources.information;
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.info.Location = new System.Drawing.Point(473, 134);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(26, 26);
            this.info.TabIndex = 7;
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 161);
            this.Controls.Add(this.info);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SystemUpTime);
            this.Controls.Add(this.RamAvailableByts);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Monitor V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CPU;
        private System.Windows.Forms.Label RamAvailableByts;
        private System.Windows.Forms.Label SystemUpTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button info;
    }
}

