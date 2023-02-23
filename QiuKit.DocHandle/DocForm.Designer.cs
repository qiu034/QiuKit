
namespace QiuKit.DocHandle
{
    partial class DocForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtBefore = new System.Windows.Forms.RichTextBox();
            this.rtxtAfter = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnGoTo = new QiuKit.ControlLibrary.BlueButton();
            this.btnCopy = new QiuKit.ControlLibrary.BlueButton();
            this.btnChange = new QiuKit.ControlLibrary.BlueButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 102);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.txtBefore);
            this.groupBox1.Controls.Add(this.txtAfter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(389, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文字转换";
            // 
            // txtBefore
            // 
            this.txtBefore.Font = new System.Drawing.Font("宋体", 9F);
            this.txtBefore.Location = new System.Drawing.Point(30, 29);
            this.txtBefore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(100, 21);
            this.txtBefore.TabIndex = 1;
            // 
            // txtAfter
            // 
            this.txtAfter.Font = new System.Drawing.Font("宋体", 9F);
            this.txtAfter.Location = new System.Drawing.Point(171, 29);
            this.txtAfter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(100, 21);
            this.txtAfter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正粗黑宋简体", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(138, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = ">>>";
            // 
            // rtxtBefore
            // 
            this.rtxtBefore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtBefore.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxtBefore.Location = new System.Drawing.Point(0, 0);
            this.rtxtBefore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtBefore.Name = "rtxtBefore";
            this.rtxtBefore.Size = new System.Drawing.Size(322, 252);
            this.rtxtBefore.TabIndex = 0;
            this.rtxtBefore.Text = "";
            // 
            // rtxtAfter
            // 
            this.rtxtAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtAfter.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxtAfter.Location = new System.Drawing.Point(0, 0);
            this.rtxtAfter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtAfter.Name = "rtxtAfter";
            this.rtxtAfter.ReadOnly = true;
            this.rtxtAfter.Size = new System.Drawing.Size(322, 217);
            this.rtxtAfter.TabIndex = 0;
            this.rtxtAfter.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 30F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(746, 164);
            this.label2.TabIndex = 4;
            this.label2.Text = ">>>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGoTo);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 102);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 271);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rtxtAfter);
            this.panel3.Controls.Add(this.btnCopy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(437, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 254);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rtxtBefore);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(15, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 254);
            this.panel2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(15, 254);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(746, 17);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 271);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(761, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(15, 271);
            this.panel7.TabIndex = 9;
            // 
            // btnGoTo
            // 
            this.btnGoTo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGoTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTo.Font = new System.Drawing.Font("宋体", 30F);
            this.btnGoTo.ForeColor = System.Drawing.Color.White;
            this.btnGoTo.Location = new System.Drawing.Point(344, 129);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(87, 51);
            this.btnGoTo.TabIndex = 10;
            this.btnGoTo.Text = "<<<";
            this.btnGoTo.UseVisualStyleBackColor = false;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("方正粗黑宋简体", 15F);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(0, 217);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(322, 35);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(291, 24);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(80, 35);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "转换";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 373);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("方正粗黑宋简体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DocForm";
            this.Text = "文档处理工具";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxtBefore;
        private System.Windows.Forms.RichTextBox rtxtAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private ControlLibrary.BlueButton btnChange;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private ControlLibrary.BlueButton btnCopy;
        private ControlLibrary.BlueButton btnGoTo;
    }
}