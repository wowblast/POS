using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmProvider : Form
    {
        public FrmProvider()
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnRegisterProvider_Click(object sender, EventArgs e)
        {
            /*ProviderController providerController = new ProviderController();
            providerController.InsertProvider(txtNameProvider.Text, txtUbicationProvider.Text);
            txtNameProvider.Text = "";
            txtUbicationProvider.Text = "";*/
        }
    }
}
