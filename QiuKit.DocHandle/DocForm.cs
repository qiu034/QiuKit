using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QiuKit.DocHandle
{
    public partial class DocForm : Form
    {
        public DocForm()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string beforeText = txtBefore.Text;
            if (string.IsNullOrEmpty(beforeText)) 
                return;
            string afterText = txtAfter.Text;
            rtxtAfter.Text = rtxtBefore.Text.Replace(beforeText, afterText);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(rtxtAfter.Text);
            MessageBox.Show("已复制！");
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            rtxtBefore.Text = rtxtAfter.Text;
        }
    }
}
