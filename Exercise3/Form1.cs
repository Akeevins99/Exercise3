using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtConnectionName_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            if (string.IsNullOrEmpty(txtConnectionName.Text))
            {
                e.Cancel = true;
                txtConnectionName.Focus();
                errorProvider.SetError(txtConnectionName, "Connection name is required");
            }
            else if (ConfigurationManager.ConnectionStrings[txtConnectionName.Text] == null)
            {
                e.Cancel = true;
                txtConnectionName.Focus();
                errorProvider.SetError(txtConnectionName, "Connection name does not exist in App.config. Check App.config file.");
            }
        }
    }
}
