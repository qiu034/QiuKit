
namespace QiuKit.RgbColor
{
    partial class RgbForm
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
            this.tkbRed = new System.Windows.Forms.TrackBar();
            this.tkbGreen = new System.Windows.Forms.TrackBar();
            this.tkbBlue = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCopy = new QiuKit.ControlLibrary.BlueButton();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // tkbRed
            // 
            this.tkbRed.Location = new System.Drawing.Point(95, 56);
            this.tkbRed.Maximum = 255;
            this.tkbRed.Name = "tkbRed";
            this.tkbRed.Size = new System.Drawing.Size(177, 45);
            this.tkbRed.TabIndex = 0;
            this.tkbRed.Scroll += new System.EventHandler(this.tkbRed_Scroll);
            // 
            // tkbGreen
            // 
            this.tkbGreen.Location = new System.Drawing.Point(95, 126);
            this.tkbGreen.Maximum = 255;
            this.tkbGreen.Name = "tkbGreen";
            this.tkbGreen.Size = new System.Drawing.Size(177, 45);
            this.tkbGreen.TabIndex = 1;
            this.tkbGreen.Scroll += new System.EventHandler(this.tkbGreen_Scroll);
            // 
            // tkbBlue
            // 
            this.tkbBlue.Location = new System.Drawing.Point(95, 196);
            this.tkbBlue.Maximum = 255;
            this.tkbBlue.Name = "tkbBlue";
            this.tkbBlue.Size = new System.Drawing.Size(177, 45);
            this.tkbBlue.TabIndex = 2;
            this.tkbBlue.Scroll += new System.EventHandler(this.tkbBlue_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(30, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Red";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(30, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(30, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Blue";
            // 
            // txtRed
            // 
            this.txtRed.BackColor = System.Drawing.Color.White;
            this.txtRed.Font = new System.Drawing.Font("华文琥珀", 14.25F);
            this.txtRed.ForeColor = System.Drawing.Color.Tomato;
            this.txtRed.Location = new System.Drawing.Point(278, 56);
            this.txtRed.MaxLength = 3;
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(66, 27);
            this.txtRed.TabIndex = 8;
            this.txtRed.Text = "0";
            this.txtRed.TextChanged += new System.EventHandler(this.txtRed_TextChanged);
            this.txtRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumberKeyPress);
            // 
            // txtGreen
            // 
            this.txtGreen.BackColor = System.Drawing.Color.White;
            this.txtGreen.Font = new System.Drawing.Font("华文琥珀", 14.25F);
            this.txtGreen.ForeColor = System.Drawing.Color.OliveDrab;
            this.txtGreen.Location = new System.Drawing.Point(278, 123);
            this.txtGreen.MaxLength = 3;
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(66, 27);
            this.txtGreen.TabIndex = 9;
            this.txtGreen.Text = "0";
            this.txtGreen.TextChanged += new System.EventHandler(this.txtGreen_TextChanged);
            this.txtGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumberKeyPress);
            // 
            // txtBlue
            // 
            this.txtBlue.BackColor = System.Drawing.Color.White;
            this.txtBlue.Font = new System.Drawing.Font("华文琥珀", 14.25F);
            this.txtBlue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBlue.Location = new System.Drawing.Point(278, 193);
            this.txtBlue.MaxLength = 3;
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(66, 27);
            this.txtBlue.TabIndex = 10;
            this.txtBlue.Text = "0";
            this.txtBlue.TextChanged += new System.EventHandler(this.txtBlue_TextChanged);
            this.txtBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumberKeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(391, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 234);
            this.panel1.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("华文琥珀", 14.25F);
            this.txtResult.ForeColor = System.Drawing.Color.Black;
            this.txtResult.Location = new System.Drawing.Point(95, 262);
            this.txtResult.MaxLength = 3;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(124, 27);
            this.txtResult.TabIndex = 12;
            this.txtResult.Text = "0,0,0";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("华文琥珀", 14.25F);
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(30, 265);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(47, 19);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "结果";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("方正粗黑宋简体", 11F);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(235, 262);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 27);
            this.btnCopy.TabIndex = 14;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // RgbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 373);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tkbBlue);
            this.Controls.Add(this.tkbGreen);
            this.Controls.Add(this.tkbRed);
            this.Name = "RgbForm";
            this.Text = "RGB取色器";
            ((System.ComponentModel.ISupportInitialize)(this.tkbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tkbRed;
        private System.Windows.Forms.TrackBar tkbGreen;
        private System.Windows.Forms.TrackBar tkbBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private ControlLibrary.BlueButton btnCopy;
    }
}