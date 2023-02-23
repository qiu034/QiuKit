using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QiuKit.ProgramHelper;

namespace QiuKit.ClassCreate
{
    public partial class ConnDialog : Form
    {
        public delegate void SetValue(string host, string user, string pwd, bool state);
        public event SetValue SetData;
        public ConnDialog()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text.Trim();
            if (string.IsNullOrEmpty(host))
            {
                MessageBox.Show(label1.Text + "不能为空！");
                return;
            }

            string user = txtUser.Text.Trim();
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show(label2.Text + "不能为空！");
                return;
            }

            string pwd = txtPwd.Text.Trim();
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show(label3.Text + "不能为空！");
                return;
            }
            try
            {
                if (SqlHelper.Instance.ConnTest(host,user,pwd))
                {
                    SetData(host,user, pwd, true);
                    this.Close();
                }
                else
                {
                    SetData(host,user,pwd, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnTemplateDialog_Load(object sender, EventArgs e)
        {

        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
