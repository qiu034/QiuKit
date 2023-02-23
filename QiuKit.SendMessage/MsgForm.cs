using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QiuKit.SendMessage
{
    public partial class MsgForm : Form
    {
        public MsgForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string tel = txtTel.Text;
            string txt = txtText.Text;
            HttpRequestHelper.Instance.GetApiUrl(tel, txt);
            string strRet = HttpRequestHelper.Instance.RequestApi();
            MessageBox.Show(strRet, "接口返回信息");
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            txtYZM.Text = rd.Next(1000, 9999).ToString().Trim();
        }

        private void txtYZM_TextChanged(object sender, EventArgs e)
        {
            txtText.Text = $"您的验证码是：{txtYZM.Text}。请不要把验证码泄露给其他人。";
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
