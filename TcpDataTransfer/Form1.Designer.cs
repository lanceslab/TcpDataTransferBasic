namespace TcpDataTransfer
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
            this.btn_start_server = new System.Windows.Forms.Button();
            this.tx_recv_data = new System.Windows.Forms.TextBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.tx_data_send = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start_server
            // 
            this.btn_start_server.Location = new System.Drawing.Point(12, 12);
            this.btn_start_server.Name = "btn_start_server";
            this.btn_start_server.Size = new System.Drawing.Size(157, 23);
            this.btn_start_server.TabIndex = 0;
            this.btn_start_server.Text = "Start Server";
            this.btn_start_server.UseVisualStyleBackColor = true;
            this.btn_start_server.Click += new System.EventHandler(this.btn_start_server_Click);
            // 
            // tx_recv_data
            // 
            this.tx_recv_data.Location = new System.Drawing.Point(37, 82);
            this.tx_recv_data.Multiline = true;
            this.tx_recv_data.Name = "tx_recv_data";
            this.tx_recv_data.Size = new System.Drawing.Size(607, 22);
            this.tx_recv_data.TabIndex = 1;
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(523, 402);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(121, 23);
            this.bt_send.TabIndex = 2;
            this.bt_send.Text = "Send Data";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // tx_data_send
            // 
            this.tx_data_send.Location = new System.Drawing.Point(37, 184);
            this.tx_data_send.Name = "tx_data_send";
            this.tx_data_send.Size = new System.Drawing.Size(607, 22);
            this.tx_data_send.TabIndex = 3;
            this.tx_data_send.Text = "Poop Is the starting phrase.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data to send.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_data_send);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.tx_recv_data);
            this.Controls.Add(this.btn_start_server);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start_server;
        private System.Windows.Forms.TextBox tx_recv_data;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.TextBox tx_data_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

