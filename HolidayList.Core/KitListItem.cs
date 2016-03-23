using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayList.Core
{
    public class KitListItem
    {
        public string Name { get; private set; }
        public Who Who { get; private set; }
        public string Category { get; private set; }

        public KitListItem(string name, Who who, string category)
        {
            Name = name;
            Who = who;
            Category = category;
        }
    }
}
