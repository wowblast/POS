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
	public partial class FrmInicioSesion : Form
	{
		public FrmInicioSesion()
		{
			InitializeComponent();
		}

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            //Close();
            
        }
    }
}
