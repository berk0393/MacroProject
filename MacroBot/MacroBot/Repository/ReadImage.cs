using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace MacroBot.Repository
{
    public class ReadImage
    {
        TesseractEngine ocr = null;
        public ReadImage()
        {
            ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractOnly);
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
