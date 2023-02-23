
namespace QiuKit.SendMessage
{
    partial class MsgForm
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
            this.txtYZM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnRandom = new QiuKit.ControlLibrary.BlueButton();
            this.btnSend = new QiuKit.ControlLibrary.BlueButton();
            this.SuspendLayout();
            // 
            // txtYZM
            // 
            this.txtYZM.Location = new System.Drawing.Point(491, 59);
            this.txtYZM.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtYZM.Name = "txtYZM";
            this.txtYZM.Size = new System.Drawing.Size(182, 32);
            this.txtYZM.TabIndex = 14;
            this.txtYZM.Text = "1234";
            this.txtYZM.TextChanged += new System.EventHandler(this.txtYZM_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(399, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "验证码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(72, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "内容：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(67, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "电话：";
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtText.Location = new System.Drawing.Point(144, 148);
            this.txtText.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(518, 32);
            this.txtText.TabIndex = 9;
            this.txtText.Text = "您的验证码是：1234。请不要把验证码泄露给其他人。";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(142, 59);
            this.txtTel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(182, 32);
            this.txtTel.TabIndex = 8;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("方正粗黑宋简体", 10F);
            this.btnRandom.ForeColor = System.Drawing.Color.White;
            this.btnRandom.Location = new System.Drawing.Point(119, 237);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(205, 60);
            this.btnRandom.TabIndex = 16;
            this.btnRandom.Text = "随机生成一个验证码";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("方正粗黑宋简体", 10F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(455, 237);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(205, 60);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "发送短信";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 373);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtYZM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtTel);
            this.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MsgForm";
            this.Text = "发送短信";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtYZM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtTel;
        private ControlLibrary.BlueButton btnRandom;
        private ControlLibrary.BlueButton btnSend;
    }
}