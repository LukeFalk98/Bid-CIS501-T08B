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

        private bool status = true;
        public bool Status
        {
            get => status;
            set { status = value; }
        }

        public void UpdateStatus()
        {
            if (DateTime.Now.Day == time.Day)
            {
                if (DateTime.Now.Hour == time.Hour)
                {
                    if (DateTime.Now.Minute == time.Minute)
                    {
                        status = false;
                        return;
                    }
                }
            }
            status = true;
            return;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
