using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.FmsProductsCategory
{
	public partial class FrmProductMainmenu : Form
	{
		public FrmProductMainmenu()
		{
			InitializeComponent();
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			FrmProducts product =new  FrmProducts();
			product.Show();
		    
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			FrmUpdateCategoryProduct frmupdate = new FrmUpdateCategoryProduct();
			frmupdate.Show();
		}
	}
}
