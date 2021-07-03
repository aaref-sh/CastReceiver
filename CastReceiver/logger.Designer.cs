
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logger));
            this.tbname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnrefresh = new System.Windows.Forms.Button();
            this.session_list = new System.Windows.Forms.ListBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(117, 266);
            this.tbname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(444, 30);
            this.tbname.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bnrefresh);
            this.groupBox2.Controls.Add(this.session_list);
            this.groupBox2.Controls.Add(this.tbname);
            this.groupBox2.Controls.Add(this.login_btn);
            this.groupBox2.Location = new System.Drawing.Point(22, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(570, 312);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الدخول لمحاضرة";
            // 
            // bnrefresh
            // 
            this.bnrefresh.Location = new System.Drawing.Point(486, 17);
            this.bnrefresh.Name = "bnrefresh";
            this.bnrefresh.Size = new System.Drawing.Size(75, 27);
            this.bnrefresh.TabIndex = 4;
            this.bnrefresh.Text = "تحديث";
            this.bnrefresh.UseVisualStyleBackColor = true;
            this.bnrefresh.Click += new System.EventHandler(this.bnrefresh_Click);
            // 
            // session_list
            // 
            this.session_list.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.session_list.FormattingEnabled = true;
            this.session_list.ItemHeight = 23;
            this.session_list.Location = new System.Drawing.Point(13, 44);
            this.session_list.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.session_list.Name = "session_list";
            this.session_list.Size = new System.Drawing.Size(548, 211);
            this.session_list.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(13, 265);
            this.login_btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(91, 31);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "دخول";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 350);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "logger";
            this.RightToLeftLayout = true;
            this.Text = "logger";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox session_list;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button bnrefresh;
    }
}