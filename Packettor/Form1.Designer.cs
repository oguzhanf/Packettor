namespace Packettor
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
            this.lblNumPacketsReceived = new System.Windows.Forms.Label();
            this.lblSizeSent = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblNumPacketsSent = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStartMon = new System.Windows.Forms.Button();
            this.btnStopMon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Received";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sent";
            // 
            // lblNumPacketsReceived
            // 
            this.lblNumPacketsReceived.AutoSize = true;
            this.lblNumPacketsReceived.Location = new System.Drawing.Point(193, 130);
            this.lblNumPacketsReceived.Name = "lblNumPacketsReceived";
            this.lblNumPacketsReceived.Size = new System.Drawing.Size(46, 17);
            this.lblNumPacketsReceived.TabIndex = 2;
            this.lblNumPacketsReceived.Text = "label3";
            // 
            // lblSizeSent
            // 
            this.lblSizeSent.AutoSize = true;
            this.lblSizeSent.Location = new System.Drawing.Point(327, 147);
            this.lblSizeSent.Name = "lblSizeSent";
            this.lblSizeSent.Size = new System.Drawing.Size(46, 17);
            this.lblSizeSent.TabIndex = 3;
            this.lblSizeSent.Text = "label4";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(193, 147);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(46, 17);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "label5";
            // 
            // lblNumPacketsSent
            // 
            this.lblNumPacketsSent.AutoSize = true;
            this.lblNumPacketsSent.Location = new System.Drawing.Point(327, 130);
            this.lblNumPacketsSent.Name = "lblNumPacketsSent";
            this.lblNumPacketsSent.Size = new System.Drawing.Size(46, 17);
            this.lblNumPacketsSent.TabIndex = 5;
            this.lblNumPacketsSent.Text = "label6";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(2128, 562);
            this.textBox1.TabIndex = 6;
            // 
            // btnStartMon
            // 
            this.btnStartMon.Location = new System.Drawing.Point(62, 22);
            this.btnStartMon.Name = "btnStartMon";
            this.btnStartMon.Size = new System.Drawing.Size(75, 23);
            this.btnStartMon.TabIndex = 7;
            this.btnStartMon.Text = "startMon";
            this.btnStartMon.UseVisualStyleBackColor = true;
            this.btnStartMon.Click += new System.EventHandler(this.btnStartMon_Click);
            // 
            // btnStopMon
            // 
            this.btnStopMon.Location = new System.Drawing.Point(144, 22);
            this.btnStopMon.Name = "btnStopMon";
            this.btnStopMon.Size = new System.Drawing.Size(75, 23);
            this.btnStopMon.TabIndex = 8;
            this.btnStopMon.Text = "stopMon";
            this.btnStopMon.UseVisualStyleBackColor = true;
            this.btnStopMon.Click += new System.EventHandler(this.btnStopMon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2627, 583);
            this.Controls.Add(this.btnStopMon);
            this.Controls.Add(this.btnStartMon);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNumPacketsSent);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblSizeSent);
            this.Controls.Add(this.lblNumPacketsReceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumPacketsReceived;
        private System.Windows.Forms.Label lblSizeSent;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblNumPacketsSent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStartMon;
        private System.Windows.Forms.Button btnStopMon;
    }
}

