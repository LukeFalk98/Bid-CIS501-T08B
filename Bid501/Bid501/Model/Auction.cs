using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bid501
{
    public class Auction
    {
        private string user = null;
        private List<Item> itemList = new List<Item>();
        public List<Item> ItemList
        {
            get => itemList
        }
    }
}
