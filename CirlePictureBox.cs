using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class CirlePictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath gp = new();
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new Region(gp);
            base.OnPaint(pe);
        }
    }
}
