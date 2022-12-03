using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroBot.Repository
{
    public class MacroResult
    {
        public bool continueStatus { get; set; } = true;

        public bool findSearchedWord { get; set; } = false;

        public List<string> readedDataList { get; set; }
    }
}
