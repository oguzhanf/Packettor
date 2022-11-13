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
            this.btnStartMon = new System.Windows.Forms.Button();
            this.btnStopMon = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Received";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sent";
            // 
            // lblNumPacketsReceived
            // 
            this.lblNumPacketsReceived.AutoSize = true;
            this.lblNumPacketsReceived.Location = new System.Drawing.Point(217, 162);
            this.lblNumPacketsReceived.Name = "lblNumPacketsReceived";
            this.lblNumPacketsReceived.Size = new System.Drawing.Size(51, 20);
            this.lblNumPacketsReceived.TabIndex = 2;
            this.lblNumPacketsReceived.Text = "label3";
            // 
            // lblSizeSent
            // 
            this.lblSizeSent.AutoSize = true;
            this.lblSizeSent.Location = new System.Drawing.Point(368, 184);
            this.lblSizeSent.Name = "lblSizeSent";
            this.lblSizeSent.Size = new System.Drawing.Size(51, 20);
            this.lblSizeSent.TabIndex = 3;
            this.lblSizeSent.Text = "label4";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(217, 184);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(51, 20);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "label5";
            // 
            // lblNumPacketsSent
            // 
            this.lblNumPacketsSent.AutoSize = true;
            this.lblNumPacketsSent.Location = new System.Drawing.Point(368, 162);
            this.lblNumPacketsSent.Name = "lblNumPacketsSent";
            this.lblNumPacketsSent.Size = new System.Drawing.Size(51, 20);
            this.lblNumPacketsSent.TabIndex = 5;
            this.lblNumPacketsSent.Text = "label6";
            // 
            // btnStartMon
            // 
            this.btnStartMon.Location = new System.Drawing.Point(70, 28);
            this.btnStartMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartMon.Name = "btnStartMon";
            this.btnStartMon.Size = new System.Drawing.Size(84, 29);
            this.btnStartMon.TabIndex = 7;
            this.btnStartMon.Text = "startMon";
            this.btnStartMon.UseVisualStyleBackColor = true;
            this.btnStartMon.Click += new System.EventHandler(this.btnStartMon_Click);
            // 
            // btnStopMon
            // 
            this.btnStopMon.Location = new System.Drawing.Point(162, 28);
            this.btnStopMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStopMon.Name = "btnStopMon";
            this.btnStopMon.Size = new System.Drawing.Size(84, 29);
            this.btnStopMon.TabIndex = 8;
            this.btnStopMon.Text = "stopMon";
            this.btnStopMon.UseVisualStyleBackColor = true;
            this.btnStopMon.Click += new System.EventHandler(this.btnStopMon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(462, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(2481, 705);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2955, 729);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStopMon);
            this.Controls.Add(this.btnStartMon);
            this.Controls.Add(this.lblNumPacketsSent);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblSizeSent);
            this.Controls.Add(this.lblNumPacketsReceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btnStartMon;
        private System.Windows.Forms.Button btnStopMon;
        private System.Windows.Forms.RichTextBox textBox1;
    }
}

