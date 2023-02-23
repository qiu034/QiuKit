using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QiuKit.RgbColor
{
    public partial class RgbForm : Form
    {
        private int red = 0;
        private int green = 0;
        private int blue = 0;

        public RgbForm()
        {
            InitializeComponent();
            txtRed.TextChanged += ChangeColor;
            txtGreen.TextChanged += ChangeColor;
            txtBlue.TextChanged += ChangeColor;
        }
        private struct POINT
        {
            private int x;
            private int y;
        }
        static POINT point;
        [DllImport("user32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetDC(int hwnd);
        [DllImport("gdi32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetPixel(int hdc, int x, int y);
        [DllImport("user32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int ReleaseDC(int hwnd, int hdc);
        [DllImport("user32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int WindowFromPoint(int x, int y);
        [DllImport("user32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int ScreenToClient(int hwnd, ref POINT lppoint);

        //获取屏幕指定坐标点的颜色
        public static Color GetPixelColor(int x, int y)
        {
            int h = WindowFromPoint(x, y);
            int hdc = GetDC(h);

            ScreenToClient(h, ref point);
            int c = GetPixel(hdc, x, y);
            return Color.FromArgb(c);
        }

        private void txtRed_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtRed.Text))
                txtRed.Text = "0";
            if (int.Parse(txtRed.Text) > 255)
                txtRed.Text = "255";
            tkbRed.Value = int.Parse(txtRed.Text);
            this.red = int.Parse(txtRed.Text);
        }

        private void txtGreen_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGreen.Text))
                txtGreen.Text = "0";
            if (int.Parse(txtGreen.Text) > 255)
                txtGreen.Text = "255";
            tkbGreen.Value = int.Parse(txtGreen.Text);
            this.green = int.Parse(txtGreen.Text);
        }

        private void txtBlue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBlue.Text))
                txtBlue.Text = "0";
            if (int.Parse(txtBlue.Text) > 255)
                txtBlue.Text = "255";
            tkbBlue.Value = int.Parse(txtBlue.Text);
            this.blue = int.Parse(txtBlue.Text);
        }

        private void OnlyNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0')  && e.KeyChar !='\b')
                e.Handled=true;
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(red,green,blue);
            txtResult.Text = $"{red},{green},{blue}";
        }

        private void tkbRed_Scroll(object sender, EventArgs e)
        {
            txtRed.Text = tkbRed.Value.ToString();
        }

        private void tkbGreen_Scroll(object sender, EventArgs e)
        {
            txtGreen.Text = tkbGreen.Value.ToString();
        }

        private void tkbBlue_Scroll(object sender, EventArgs e)
        {
            txtBlue.Text = tkbBlue.Value.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtResult.Text);
            MessageBox.Show("已复制！");
        }
    }
}
