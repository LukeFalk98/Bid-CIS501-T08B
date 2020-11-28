using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bid501
{
    public class Item: IItem
    {
        private string name = null;
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        private DateTime time = new DateTime();
        public DateTime Time
        {
            get => time;
            set
            {
                time = value;
            }
        }

        private double minBid = 0.0;
        public double MinBid
        {
            get => minBid;
            set { minBid = value; }
        }

        private int numBids = 0;
        public int NumBids
        {
            get => numBids;
            set { numBids = value; }
        }

        private bool status = false;
        public bool Status
        {
            get => status;
            set { status = value; }
        }
    }
}
