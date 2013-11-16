using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BroachingAnalysis
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if the password in the box matches the preset password then return the result
            if (txtPassword.Text == "Centrax")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If key is enter then call the login action
            if (e.KeyChar == (char)13)
            {
                // Then Enter key was pressed
                btnLogin_Click(sender, e);
            }
        }
    }
}
