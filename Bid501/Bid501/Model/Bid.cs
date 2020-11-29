using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bid501
{
    public class Bid
    {
        public string User { get; set; }
        public IItem Article { get; set; }
        public double Amount { get; set; }
    }
}
