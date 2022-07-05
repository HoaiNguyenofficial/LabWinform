
namespace Lab04
{
    partial class MainDashboard
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
            this.btn1 = new System.Windows.Forms.Button();
            this.bnt2 = new System.Windows.Forms.Button();
            this.bnt3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(65, 40);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(118, 34);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "Bài 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // bnt2
            // 
            this.bnt2.Location = new System.Drawing.Point(65, 146);
            this.bnt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt2.Name = "bnt2";
            this.bnt2.Size = new System.Drawing.Size(118, 34);
            this.bnt2.TabIndex = 6;
            this.bnt2.Text = "Bài 2";
            this.bnt2.UseVisualStyleBackColor = true;
            this.bnt2.Click += new System.EventHandler(this.bnt2_Click);
            // 
            // bnt3
            // 
            this.bnt3.Location = new System.Drawing.Point(285, 40);
            this.bnt3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt3.Name = "bnt3";
            this.bnt3.Size = new System.Drawing.Size(118, 34);
            this.bnt3.TabIndex = 7;
            this.bnt3.Text = "Bài 3";
            this.bnt3.UseVisualStyleBackColor = true;
            this.bnt3.Click += new System.EventHandler(this.bnt3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(285, 146);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(118, 34);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "Bài 4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 210);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.bnt3);
            this.Controls.Add(this.bnt2);
            this.Controls.Add(this.btn1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button bnt2;
        private System.Windows.Forms.Button bnt3;
        private System.Windows.Forms.Button btn4;
    }
}