using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MacroBot.Repository.ScreenDraw
{
    public class DrawRepository
    {
        [DllImport("User32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        private static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

        [DllImport("user32.dll")]
        static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

        public void drawPointInScreen(int x, int y)
        {
            IntPtr desktopPtr = GetDC(IntPtr.Zero);
            Graphics g = Graphics.FromHdc(desktopPtr);

            SolidBrush b = new SolidBrush(Color.Red);

            g.FillRectangle(b, new Rectangle(x, y, 10, 10));

            g.Dispose();
            ReleaseDC(IntPtr.Zero, desktopPtr);
        }

        public void drawRectangleInScreen(int x, int y, int width, int height)
        {
            IntPtr desktopPtr = GetDC(IntPtr.Zero);
            Graphics g = Graphics.FromHdc(desktopPtr);
            //SolidBrush b = new SolidBrush(Color.Red);

            Pen _pen = new Pen(Color.Red);
            g.DrawRectangle(_pen, x, y, width, height);

            //g.FillRectangle(b, new Rectangle(x, y, width, height));

            g.Dispose();
            ReleaseDC(IntPtr.Zero, desktopPtr);

            //Pen _pen = new Pen(Color.Red);

            //g.DrawRectangle(_pen, x, y, 10, 10);
        }

        public void cleandraw()
        {
            InvalidateRect(IntPtr.Zero, IntPtr.Zero, true);
        }
    }
}
