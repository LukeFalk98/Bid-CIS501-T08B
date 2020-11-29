using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bid501
{
    public interface IItem
    {
        string Name { get; set; }
        DateTime Time { get; set; }
        double MinBid { get; set; }
        int NumBids { get; set; }
        bool Status { get; set; }
    }
}
