using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroBot.Model
{
    public class BotActionList
    {

        public int actionID { get; set; }
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public int screenReadID { get; set; } = 0;
        public int actionQueue { get; set; }
        public int waitingSecond { get; set; }
    }
}
