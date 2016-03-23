using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayList.Core
{
    public class KitList
    {
        private IList<KitListItem> _items = new List<KitListItem>();
        public IEnumerable<KitListItem> Items { get { return _items; } }

        public void Add(KitListItem item)
        {
            _items.Add(item);
        }
    }
}
