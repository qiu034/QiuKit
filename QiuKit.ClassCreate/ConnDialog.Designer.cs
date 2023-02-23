
namespace QiuKit.ClassCreate
{
    partial class ConnDialog
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
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConn = new QiuKit.ControlLibrary.BlueButton();
            this.btnClose = new QiuKit.ControlLibrary.BlueButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(171, 160);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(157, 25);
            this.txtPwd.TabIndex = 11;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("方正粗黑宋简体", 11F);
            this.label3.Location = new System.Drawing.Point(55, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "密码：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(171, 97);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(157, 25);
            this.txtUser.TabIndex = 9;
            this.txtUser.Text = "sa";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("方正粗黑宋简体", 11F);
            this.label2.Location = new System.Drawing.Point(55, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "登录名：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(171, 38);
            this.txtHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(157, 25);
            this.txtHost.TabIndex = 7;
            this.txtHost.Text = ".";
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正粗黑宋简体", 11F);
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "服务器地址：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConn
            // 
            this.btnConn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConn.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnConn.ForeColor = System.Drawing.Color.White;
            this.btnConn.Location = new System.Drawing.Point(216, 225);
            this.btnConn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(112, 43);
            this.btnConn.TabIndex = 12;
            this.btnConn.Text = "测试并连接";
            this.btnConn.UseVisualStyleBackColor = false;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(58, 225);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 43);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "返回";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Controls.Add(this.btnConn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 302);
            this.panel1.TabIndex = 14;
            // 
            // ConnTemplateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 302);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("方正粗黑宋简体", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConnTemplateDialog";
            this.Text = "连接数据库";
            this.Load += new System.EventHandler(this.ConnTemplateDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private ControlLibrary.BlueButton btnConn;
        private ControlLibrary.BlueButton btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}