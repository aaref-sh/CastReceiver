
namespace CastReceiver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb = new System.Windows.Forms.PictureBox();
            this.messagetb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.messagesrtb = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbmic = new System.Windows.Forms.PictureBox();
            this.pbspeaker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspeaker)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(619, 402);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // messagetb
            // 
            this.messagetb.Location = new System.Drawing.Point(66, 3);
            this.messagetb.Name = "messagetb";
            this.messagetb.Size = new System.Drawing.Size(135, 20);
            this.messagetb.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // messagesrtb
            // 
            this.messagesrtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesrtb.Location = new System.Drawing.Point(0, 0);
            this.messagesrtb.Name = "messagesrtb";
            this.messagesrtb.Size = new System.Drawing.Size(239, 376);
            this.messagesrtb.TabIndex = 3;
            this.messagesrtb.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.messagesrtb);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(619, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 402);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbmic);
            this.panel2.Controls.Add(this.pbspeaker);
            this.panel2.Controls.Add(this.messagetb);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 26);
            this.panel2.TabIndex = 4;
            // 
            // pbmic
            // 
            this.pbmic.Image = global::CastReceiver.Properties.Resources.um;
            this.pbmic.Location = new System.Drawing.Point(3, 0);
            this.pbmic.Name = "pbmic";
            this.pbmic.Size = new System.Drawing.Size(31, 26);
            this.pbmic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbmic.TabIndex = 3;
            this.pbmic.TabStop = false;
            this.pbmic.Click += new System.EventHandler(this.pbmic_Click);
            // 
            // pbspeaker
            // 
            this.pbspeaker.Image = global::CastReceiver.Properties.Resources.su;
            this.pbspeaker.Location = new System.Drawing.Point(34, 0);
            this.pbspeaker.Name = "pbspeaker";
            this.pbspeaker.Size = new System.Drawing.Size(31, 26);
            this.pbspeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbspeaker.TabIndex = 3;
            this.pbspeaker.TabStop = false;
            this.pbspeaker.Click += new System.EventHandler(this.pbspeaker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 402);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspeaker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.TextBox messagetb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox messagesrtb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbspeaker;
        private System.Windows.Forms.PictureBox pbmic;
    }
}

