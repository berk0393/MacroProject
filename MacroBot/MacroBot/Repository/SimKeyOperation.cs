using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace MacroBot.Repository
{
    public class SimKeyOperation
    {
        private InputSimulator sm = null;
        public SimKeyOperation()
        {
            sm = new InputSimulator();
        }
        public void mouseLeftClickFunction()
        {
            sm.Mouse.LeftButtonClick();
        }
        public void mouseLeftDoubleClickFunction()
        {
            sm.Mouse.LeftButtonDoubleClick();
        }

        public void mouseRightClickFunction()
        {
            sm.Mouse.RightButtonClick();
        }
        public void mouseRighttDoubleClickFunction()
        {
            sm.Mouse.RightButtonDoubleClick();
        }

        public void mouseCursor(int x, int y)
        {
            Cursor.Position = new Point(x, y);
        }
    }
}
