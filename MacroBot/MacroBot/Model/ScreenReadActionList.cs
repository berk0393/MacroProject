﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroBot.Model
{
    public class ScreenReadActionList
    {
        public int recordID { get; set; }

        public List<string> ekListesi { get; set; }

        public int xCoordinate { get; set; }

        public int yCoordinate { get; set; }

        public int width { get; set; }

        public int height { get; set; }
    }
}
