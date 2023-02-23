using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QiuKit.ControlLibrary
{
    public partial class BlueButton : Button
    {
        public BlueButton()
        {
            InitializeComponent();
            this.BackColor = Color.DodgerBlue;
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("方正粗黑宋简体",10);
            this.Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            System.Drawing.Pen pen = new Pen(Color.White, 2);
            pe.Graphics.DrawRectangle(pen, 0, 0, this.Width, this.Height);
            pen.Dispose();

            //Graphics g = pe.Graphics;
            //Color FColor = Color.White;
            //Color TColor = Color.Transparent;
            //Brush b = new LinearGradientBrush(pe.ClipRectangle, FColor, TColor, LinearGradientMode.ForwardDiagonal);
            //g.FillRectangle(b,pe.ClipRectangle);
        }
    }
}
