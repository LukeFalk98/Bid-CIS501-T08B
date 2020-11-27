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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PasswordBox.Enabled = false;
            LoginButton.Enabled = false;
        }

        /// <summary>
        /// This handler controls the event of someone entering their username
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnUsernameChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                if (tb.TextLength > 0)
                {
                    PasswordBox.Enabled = true;
                    if (PasswordBox.TextLength > 0)
                    {
                        LoginButton.Enabled = true;
                    }
                }
                else
                {
                    PasswordBox.Enabled = false;
                    LoginButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// This handles the user entering their password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnPasswordChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                if (tb.TextLength > 0)
                {
                    LoginButton.Enabled = true;
                }
                else
                {
                    LoginButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// This handles the user clicking the "login" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
