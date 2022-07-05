
namespace Lab04
{
    partial class Bai3
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
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.Location = new System.Drawing.Point(15, 109);
            this.rtxtInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.Size = new System.Drawing.Size(580, 445);
            this.rtxtInfo.TabIndex = 10;
            this.rtxtInfo.Text = "";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(15, 61);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLink.Multiline = true;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(580, 39);
            this.txtLink.TabIndex = 9;
            this.txtLink.Text = "C:\\Users\\19521\\Desktop\\MCB\\New folder\\bai3.html";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(479, 6);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(118, 34);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(15, 6);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(455, 31);
            this.txtURL.TabIndex = 7;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 562);
            this.Controls.Add(this.rtxtInfo);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtURL);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtURL;
    }
}