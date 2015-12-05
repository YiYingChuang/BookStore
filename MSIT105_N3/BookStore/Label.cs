using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 員工權限
{
    public partial class Label : Control
    {
        public Label()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.DrawString(Text, Font, new LinearGradientBrush(new Point(0, 0), new Point(Width, Height), Startcolor, Endcolor), 0, 0);
            base.OnPaint(pe);
        }

        public Color Startcolor { get; set; }

        public Color Endcolor { get; set; }
    }
}
