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
    public partial class ServerForm : Form, ServerObserver
    {
        public ServerHandler handler { private get; set; }

        public ServerForm()
        {
            InitializeComponent();
        }

        public void updateServer()
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            handler.HandleServer("addItem/");
        }
    }
}
