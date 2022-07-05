
namespace Server
{
    partial class UDP_server
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.lsvMsg = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(88, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(125, 27);
            this.txtPort.TabIndex = 7;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(15, 12);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(35, 20);
            this.lbPort.TabIndex = 6;
            this.lbPort.Text = "Port";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(402, 12);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(94, 29);
            this.btnListen.TabIndex = 5;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // lsvMsg
            // 
            this.lsvMsg.HideSelection = false;
            this.lsvMsg.Location = new System.Drawing.Point(15, 69);
            this.lsvMsg.Name = "lsvMsg";
            this.lsvMsg.Size = new System.Drawing.Size(481, 207);
            this.lsvMsg.TabIndex = 8;
            this.lsvMsg.UseCompatibleStateImageBehavior = false;
            this.lsvMsg.View = System.Windows.Forms.View.List;
            this.lsvMsg.SelectedIndexChanged += new System.EventHandler(this.lsvMsg_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Received message ";
            // 
            // UDP_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvMsg);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.btnListen);
            this.Name = "UDP_server";
            this.Text = "UDP_server";
            this.Load += new System.EventHandler(this.UDP_server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvMsg;
    }
}