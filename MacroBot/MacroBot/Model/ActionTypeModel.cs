using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroBot.Model
{
    public class ActionTypeModel
    {
        public int typeID { get; set; }

        public string typeName { get; set; }

        public bool visibleMouseEvent { get; set; } = true;
    }
}
