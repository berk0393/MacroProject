using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroBot
{
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            InitializeComponent();

            //setForm();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void setForm()
        {
            //Point p = new Point(0, 10);

            //this.Location = p;
            //this.DesktopLocation = p;

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.SizeGripStyle = SizeGripStyle.Hide;
            //this.StartPosition = FormStartPosition.Manual;
            //this.MaximizeBox = false;
            //this.MinimizeBox = true;
            //this.ShowInTaskbar = false;
            //this.BackColor = Color.Red;
            //this.TransparencyKey = Color.Magenta;
            ////this.Opacity = 0.5f;
        }
    }
}
