using System.IO;

namespace MacroBot.Helper
{
    public class MacroHelper
    {   
        public static void removeFiles(string ImagesFolder)
        {

            DirectoryInfo di = new DirectoryInfo(ImagesFolder);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }
    }
}
