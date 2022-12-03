using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroBot.Repository
{
    public class MacroHelper
    {
        public static bool checkWords(List<string> worldList, string readedData)
        {
            var _readedData = readedData.Split(null).ToList();

            foreach (string item in worldList)
            {
                if (_readedData.Any(a => a.ToLower() == item.ToLower()))
                    return true;
            }

            return false;
        }
    }
}
