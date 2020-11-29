using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bid501
{
    public partial class AddProductForm : Form, ProductObserver
    {
        public ProductHandler handler { private get; set; }

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedItem != null)
            {
                Item i = (Item)ItemList.SelectedItem;
                handler.HandleProduct("addProduct/" + i.ToString() + ',' 
                                                    + i.Time.ToString() + ',' 
                                                    + i.MinBid.ToString() + ',' 
                                                    + i.NumBids.ToString() + ',' 
                                                    + i.Status.ToString());
            }
        }

        public void updateProduct()
        {

        }
    }
}
