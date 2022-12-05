using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroBot.Repository
{
    public class Screenshot
    {
        private const string screenShotPngName = "scrnsht.png";

        private const string chatImage = "chatImage.png";

        private const string chatImageZoom = "chatImageZoom.png";

        private int _x = 0;

        private int _y = 0;

        private int _width = 0;

        private int _height = 0;

        private string filePath = string.Empty;

        private string rootPath = Application.StartupPath;

        private string imageFolderPath = @"\\Resources\\img\\screenshot\\";

        public static Guid fileGuid = Guid.Empty;

        public string getImagesFilePath()
        {
            return Directory.GetParent(Directory.GetParent(rootPath).ToString()) + imageFolderPath;
        }

        private string getScreenShotPngName()
        {
            return fileGuid.ToString() + screenShotPngName;
        }

        private string getchatImage()
        {
            return fileGuid.ToString() + chatImage;
        }

        private string getchatImageZoom()
        {
            return fileGuid.ToString() + chatImageZoom;
        }

        public Screenshot()
        {
            string rootPath = Application.StartupPath;
            filePath = getImagesFilePath();
        }

        public void takeScreenShot(int x, int y, int width, int height)
        {
            try
            {
                _x = x;
                _y = y;
                _width = width;
                _height = height;

                fileGuid = Guid.NewGuid();

                saveFile(filePath + getScreenShotPngName(), ScreenShotFunction());
                CropChat();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Bitmap getCropedImage(bool getZoomImage = false)
        {
            string cropedImageFullName = filePath + (getZoomImage ? getchatImageZoom() : getchatImage());
            Bitmap bp = null;

            if (File.Exists(cropedImageFullName))
                bp = new Bitmap(cropedImageFullName);

            return bp;

        }

        private Bitmap ScreenShotFunction() // Bitmap türünde olşuturuyoruz  fonksiyonumuzu. 
        {
            Bitmap Screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics GFX = Graphics.FromImage(Screenshot);
            GFX.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            return Screenshot;
        }

        private void CropChat()
        {
            Bitmap source = new Bitmap(filePath + getScreenShotPngName());

            Point p = new Point(_x, _y);
            Size s = new Size(_width, _height);

            Rectangle section = new Rectangle(p, s);
            Bitmap CroppedImage = CropImage(source, section);
            saveFile(filePath + getchatImage(), CroppedImage);

            zoomData();
        }

        private Bitmap CropImage(Bitmap source, Rectangle section)
        {
            var bitmap = new Bitmap(section.Width, section.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
                return bitmap;
            }
        }

        private void saveFile(string path, Bitmap bp)
        {
            bp.Save(path);
            bp.Dispose();

            closeFile(path);
        }

        private void zoomData()
        {
            Bitmap data = getCropedImage();

            Size newSize = new Size((int)(data.Width * 10), (int)(data.Height * 10));

            Bitmap newZoomImage = new Bitmap(data, newSize);

            saveFile(filePath + getchatImageZoom(), newZoomImage);
        }

        private void closeFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);

            fs.Flush();
            fs.Close();
        }
    }
}
