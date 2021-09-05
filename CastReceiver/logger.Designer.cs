
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
            this.bnrefresh = new System.Windows.Forms.Button();
            this.session_list = new System.Windows.Forms.ListBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbname.Location = new System.Drawing.Point(301, 13);
            this.tbname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(131, 19);
            this.tbname.TabIndex = 2;
            // 
            // bnrefresh
            // 
            this.bnrefresh.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnrefresh.Location = new System.Drawing.Point(229, 12);
            this.bnrefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bnrefresh.Name = "bnrefresh";
            this.bnrefresh.Size = new System.Drawing.Size(61, 26);
            this.bnrefresh.TabIndex = 4;
            this.bnrefresh.Text = "تحديث";
            this.bnrefresh.UseVisualStyleBackColor = true;
            this.bnrefresh.Click += new System.EventHandler(this.bnrefresh_Click);
            // 
            // session_list
            // 
            this.session_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.session_list.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.session_list.FormattingEnabled = true;
            this.session_list.ItemHeight = 23;
            this.session_list.Location = new System.Drawing.Point(13, 13);
            this.session_list.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.session_list.Name = "session_list";
            this.session_list.Size = new System.Drawing.Size(277, 207);
            this.session_list.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Location = new System.Drawing.Point(301, 41);
            this.login_btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(131, 27);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "دخول";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 233);
            this.Controls.Add(this.bnrefresh);
            this.Controls.Add(this.session_list);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.login_btn);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "logger";
            this.RightToLeftLayout = true;
            this.Text = "logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.ListBox session_list;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button bnrefresh;
    }
}