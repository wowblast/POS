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

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void btnVerproductocategoria_Click(object sender, EventArgs e)
		{
			FrmProductMainmenu productocategoryMainMenu = new FrmProductMainmenu();
			productocategoryMainMenu.Show();
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			FrmUpdateProduct updateproduct = new FrmUpdateProduct();
			updateproduct.Show();
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			FrmProducts product = new FrmProducts();
			product.Show();
		}
	}
}
