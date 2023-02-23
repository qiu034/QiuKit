using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QiuKit
{
    public partial class Main : Form
    {
        private const int CLOSE_SIZE = 10;
        public Main()
        {
            InitializeComponent();
            InitialFormsWithMenu();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_CAPTION = 0xC00000;
                const int WS_BORDER = 0x800000;
                CreateParams CP = base.CreateParams;
                CP.Style &= ~WS_CAPTION | WS_BORDER;
                return CP;
            }
        }
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void picbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbtnState_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 鼠标经过时改变背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeBackColor(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(230, 230, 230);
            PictureBox picbtn = sender as PictureBox;
            if (picbtn == picbtnExit)
            {
                picExitL.BackColor = color;
                picExitR.BackColor = color;
            }
            if (picbtn == picbtnState)
            {
                picStateL.BackColor = color;
                picStateR.BackColor = color;
            }
            picbtn.BackColor = color;
        }

        /// <summary>
        /// 鼠标移开时还原颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestoreBackColor(object sender, EventArgs e)
        {
            Color color = Color.White;
            PictureBox picbtn = sender as PictureBox;
            if (picbtn == picbtnExit)
            {
                picExitL.BackColor = color;
                picExitR.BackColor = color;
            }
            if (picbtn == picbtnState)
            {
                picStateL.BackColor = color;
                picStateR.BackColor = color;
            }
            picbtn.BackColor = color;
        }

        /// <summary>
        /// 点击时显示菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowMenu(object sender, EventArgs e)
        {
            Point p = this.Location;
            p.X += picbtnMenu.Location.X;
            p.Y += picbtnMenu.Location.Y + picbtnMenu.Height;
            picbtnMenu.BackColor = Color.FromArgb(220, 220, 220);
            contextMenuStrip1.Show(p);
        }
        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            picbtnMenu.BackColor = Color.White;
        }

        /// <summary>
        /// 选择菜单选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuClick(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = sender as ToolStripMenuItem;
            Form form = null;
            QiuForms.Instance.CreateNewForm(ref form, (QiuForms.Name)btn.Tag);
            ShowForm(form);
        }


        /// <summary>
        /// 显示窗体并展示到页签
        /// </summary>
        /// <param name="form"></param>
        private void ShowForm(Form form)
        {
            //if (this.Now !=null) this.Now.Close();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.BackColor = Color.White;

            TabPage tabPage = new TabPage();
            tbcForm.TabPages.Add(tabPage);
            tabPage.Controls.Add(form);
            tabPage.Tag = form;
            tabPage.Text = form.Text;
            tabPage.Width += 5;
            tabPage.UseVisualStyleBackColor = true;
            form.Parent = tabPage;
            form.Show();
            tbcForm.SelectedTab = tabPage;
        }

        /// <summary>
        /// 初始化绑定窗体和菜单选项
        /// </summary>
        private void InitialFormsWithMenu()
        {
            文档处理工具ToolStripMenuItem.Tag = QiuForms.Name.DocForm;
            中英文翻译工具ToolStripMenuItem.Tag = QiuForms.Name.TranslateForm;
            短信验证码发送ToolStripMenuItem.Tag = QiuForms.Name.MsgForm;
            c类生成工具ToolStripMenuItem.Tag = QiuForms.Name.ClassForm;
            rGB颜色取色器ToolStripMenuItem.Tag = QiuForms.Name.RgbForm;

        }

        /// <summary>
        /// 绘制tab样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbcForm_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl myTabControl = sender as TabControl;

            //重绘工作区
            Rectangle rec01 = myTabControl.ClientRectangle;
            e.Graphics.FillRectangle(new SolidBrush(Color.White), rec01);
          
            //重绘TabPage
            for (int i = 0; i < myTabControl.TabPages.Count; i++)
            {
                SolidBrush back = new SolidBrush(Color.White);
                Brush FontColor = SystemBrushes.ControlText;
                Color penColor = Color.Black;
                //bool isSelected = false;

                if (i == myTabControl.SelectedIndex)
                {
                    penColor = Color.White;
                    back= new SolidBrush(Color.DodgerBlue);
                    FontColor = new SolidBrush(Color.White);
                    //isSelected = true;
                }

                Rectangle myTabRect = myTabControl.GetTabRect(i);

                //画TabPage的背景色
                e.Graphics.FillRectangle(back, myTabRect);

                //画字符串
                e.Graphics.DrawString(myTabControl.TabPages[i].Text, new Font("方正粗黑宋简体", 9), FontColor, myTabRect.X + 2, myTabRect.Y + 2);

                //画TabPage边线
                using (Pen pen = new Pen(Color.Black))
                {
                    e.Graphics.DrawLine(pen, myTabRect.X, myTabRect.Y, myTabRect.X + myTabRect.Width, myTabRect.Y); //上边线
                    e.Graphics.DrawLine(pen, myTabRect.X, myTabRect.Y, myTabRect.X, myTabRect.Y + myTabRect.Height); //左边线
                    e.Graphics.DrawLine(pen, myTabRect.X + myTabRect.Width, myTabRect.Y, myTabRect.X + myTabRect.Width, myTabRect.Y + myTabRect.Height); //右边线
                    //if(!isSelected)
                        e.Graphics.DrawLine(pen, myTabRect.X , myTabRect.Y + myTabRect.Height, myTabRect.X + myTabRect.Width, myTabRect.Y + myTabRect.Height); //下边线
                }

                //确定关闭符号的矩形框
                using (Pen p = new Pen(penColor))
                {
                    myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 4), 3);
                    myTabRect.Width = CLOSE_SIZE;
                    myTabRect.Height = CLOSE_SIZE;
                    e.Graphics.DrawRectangle(p, myTabRect);
                }

                //画关闭符号
                using (Pen objpen = new Pen(penColor))
                {
                    //"/"线
                    Point p1 = new Point(myTabRect.X + 3, myTabRect.Y + 3);
                    Point p2 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + myTabRect.Height - 3);
                    e.Graphics.DrawLine(objpen, p1, p2);

                    //"\"线
                    Point p3 = new Point(myTabRect.X + 3, myTabRect.Y + myTabRect.Height - 3);
                    Point p4 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + 3);
                    e.Graphics.DrawLine(objpen, p3, p4);
                }
            }
            e.Graphics.Dispose();
        }

        /// <summary>
        /// 点击关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbcForm_MouseDown(object sender, MouseEventArgs e)
        {
            TabControl myTabControl = sender as TabControl;
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                Rectangle myTabRect = myTabControl.GetTabRect(myTabControl.SelectedIndex);
                myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 4), 3);
                myTabRect.Width = CLOSE_SIZE;
                myTabRect.Height = CLOSE_SIZE;

                bool isClose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;

                if(isClose)
                {
                    Form form = myTabControl.SelectedTab.Tag as Form;
                    form.Dispose();
                    myTabControl.TabPages.Remove(myTabControl.SelectedTab);
                }
            }
        }

        private void tbcForm_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    return;
            //}
            //TabControl myTabControl = sender as TabControl;
            //int x = e.X, y = e.Y;
            //Rectangle myTabRect = myTabControl.GetTabRect(myTabControl.SelectedIndex);
            //myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 4), 3);
            //myTabRect.Width = CLOSE_SIZE;
            //myTabRect.Height = CLOSE_SIZE;

            //bool isClose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;
            //if (isClose)
            //{
            //    Cursor.Current = Cursors.Hand;
            //}
        }

    }
}
