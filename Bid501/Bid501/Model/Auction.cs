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
            get => itemList;
            set
            {
                itemList = value;
            }
        }

        public Bid PlaceBid(double amount, Item item)
        {
            item.UpdateStatus();
            if (item.MinBid >= amount && item.Status)
            {
                item.NumBids++;
                item.MinBid = amount;
                Bid b = new Bid();
                b.Amount = amount;
                b.Article = item;
                b.User = user;
                return b;
            }
            else return null;
        }
    }
}
