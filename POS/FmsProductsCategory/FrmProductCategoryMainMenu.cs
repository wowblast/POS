using POS.Control;
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
	public partial class FrmProductCategoryMainMenu : Form
	{
		public FrmProductCategoryMainMenu()
		{
			InitializeComponent();
		}

		private void FrmProductCategoryMainMenu_Load(object sender, EventArgs e)
		{
			Listar();
		}
		public void Listar()
		{
			ProductoControl productoControl = new ProductoControl();
			dataGridView1.DataSource = productoControl.ListarProductos();			
		}
	}
}
