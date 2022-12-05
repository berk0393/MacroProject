using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace MacroBot.Repository
{
    public class ReadImage
    {
        private string rootPath = Application.StartupPath;

        private string FolderPath = @"\\Resources\\tessdata\\";

        public static Guid fileGuid = Guid.Empty;

        public string getTesseractFile()
        {
            return Directory.GetParent(Directory.GetParent(rootPath).ToString()) + FolderPath;
        }

        TesseractEngine ocr = null;
        public ReadImage()
        {
            ocr = new TesseractEngine(getTesseractFile(), "eng", EngineMode.TesseractOnly);
        }
        public string readData(Bitmap img)
        {
            using (Page sonuc = ocr.Process(img, PageSegMode.Auto))
            {
                return sonuc.GetText();
            };
        }
    }
}
