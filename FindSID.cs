using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Security.Principal;

namespace FindSID
{
    public partial class frmFindSID : Form
    {
        public frmFindSID()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                NTAccount ntuser = new NTAccount(txtSearchString.Text);
                SecurityIdentifier sID = (SecurityIdentifier)ntuser.Translate(typeof(SecurityIdentifier));
                txtResult.Text = sID.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            } 
        }

    }
}
