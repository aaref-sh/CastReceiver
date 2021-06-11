
namespace CastReceiver
{
    partial class logger
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
            this.tbgroup = new System.Windows.Forms.TextBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.tbname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbgroup
            // 
            this.tbgroup.Location = new System.Drawing.Point(190, 85);
            this.tbgroup.Name = "tbgroup";
            this.tbgroup.Size = new System.Drawing.Size(100, 20);
            this.tbgroup.TabIndex = 0;
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(190, 111);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(100, 23);
            this.btnconnect.TabIndex = 1;
            this.btnconnect.Text = "connect";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(190, 59);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 2;
            // 
            // logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 281);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.tbgroup);
            this.Name = "logger";
            this.Text = "logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbgroup;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.TextBox tbname;
    }
}