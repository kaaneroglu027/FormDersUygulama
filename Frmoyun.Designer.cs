namespace FormDersUygulama
{
    partial class Frmoyun
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
            this.tmrbutton = new System.Windows.Forms.Timer(this.components);
            this.pnlgosterge = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblsure = new System.Windows.Forms.Label();
            this.lblskor = new System.Windows.Forms.Label();
            this.tmrsure = new System.Windows.Forms.Timer(this.components);
            this.pnlgosterge.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrbutton
            // 
            this.tmrbutton.Interval = 1000;
            this.tmrbutton.Tick += new System.EventHandler(this.tmrbutton_Tick);
            // 
            // pnlgosterge
            // 
            this.pnlgosterge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlgosterge.Controls.Add(this.button1);
            this.pnlgosterge.Controls.Add(this.lblsure);
            this.pnlgosterge.Controls.Add(this.lblskor);
            this.pnlgosterge.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlgosterge.Location = new System.Drawing.Point(674, 0);
            this.pnlgosterge.Name = "pnlgosterge";
            this.pnlgosterge.Size = new System.Drawing.Size(126, 450);
            this.pnlgosterge.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Location = new System.Drawing.Point(33, 22);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(29, 13);
            this.lblsure.TabIndex = 1;
            this.lblsure.Text = "Sure";
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Location = new System.Drawing.Point(42, 86);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(29, 13);
            this.lblskor.TabIndex = 0;
            this.lblskor.Text = "Skor";
            // 
            // tmrsure
            // 
            this.tmrsure.Interval = 1000;
            this.tmrsure.Tick += new System.EventHandler(this.tmrsure_Tick);
            // 
            // Frmoyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlgosterge);
            this.Name = "Frmoyun";
            this.Text = "Frmoyun";
            this.Load += new System.EventHandler(this.Frmoyun_Load);
            this.pnlgosterge.ResumeLayout(false);
            this.pnlgosterge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrbutton;
        private System.Windows.Forms.Panel pnlgosterge;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Timer tmrsure;
        private System.Windows.Forms.Button button1;
    }
}