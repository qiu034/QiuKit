
namespace QiuKit.ClassCreate
{
    partial class ClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassForm));
            this.btnConn = new QiuKit.ControlLibrary.BlueButton();
            this.ListBoxDb = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new QiuKit.ControlLibrary.BlueButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConn
            // 
            this.btnConn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConn.Font = new System.Drawing.Font("方正粗黑宋简体", 10F);
            this.btnConn.ForeColor = System.Drawing.Color.White;
            this.btnConn.Location = new System.Drawing.Point(41, 20);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(99, 41);
            this.btnConn.TabIndex = 0;
            this.btnConn.Text = "数据库连接";
            this.btnConn.UseVisualStyleBackColor = false;
            this.btnConn.Click += new System.EventHandler(this.blueButton1_Click);
            // 
            // ListBoxDb
            // 
            this.ListBoxDb.Font = new System.Drawing.Font("方正粗黑宋简体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListBoxDb.FormattingEnabled = true;
            this.ListBoxDb.ItemHeight = 15;
            this.ListBoxDb.Location = new System.Drawing.Point(29, 66);
            this.ListBoxDb.Margin = new System.Windows.Forms.Padding(2);
            this.ListBoxDb.Name = "ListBoxDb";
            this.ListBoxDb.Size = new System.Drawing.Size(139, 274);
            this.ListBoxDb.TabIndex = 6;
            this.ListBoxDb.SelectedIndexChanged += new System.EventHandler(this.ListBoxDb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBoxDb);
            this.groupBox1.Controls.Add(this.btnConn);
            this.groupBox1.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(23, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 349);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1、选择数据库";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 40F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(229, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = ">>>";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtTD);
            this.groupBox2.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(322, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 349);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2、选择数据表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(264, 278);
            this.dataGridView1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtTD
            // 
            this.txtTD.Location = new System.Drawing.Point(64, 26);
            this.txtTD.Margin = new System.Windows.Forms.Padding(2);
            this.txtTD.Name = "txtTD";
            this.txtTD.Size = new System.Drawing.Size(183, 27);
            this.txtTD.TabIndex = 13;
            this.txtTD.TextChanged += new System.EventHandler(this.txtTD_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 40F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(598, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 54);
            this.label2.TabIndex = 10;
            this.label2.Text = ">>>";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("方正粗黑宋简体", 10F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(692, 152);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 37);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "生成";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 373);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClassForm";
            this.Text = "C#类生成工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlLibrary.BlueButton btnConn;
        private System.Windows.Forms.ListBox ListBoxDb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTD;
        private System.Windows.Forms.Label label2;
        private ControlLibrary.BlueButton btnCreate;
    }
}