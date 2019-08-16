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
	public partial class FrmProductMainmenu : Form
	{
		public FrmProductMainmenu()
		{
			InitializeComponent();
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			FrmAddCategoryProducts product =new FrmAddCategoryProducts();
			product.Show();
		    
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				FrmUpdateCategoryProduct frmupdate = new FrmUpdateCategoryProduct(Convert.ToInt32(dataGridView1.SelectedCells[0].Value),dataGridView1.SelectedCells[3].Value.ToString());
				frmupdate.Show();
			}
			else
			{
				MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
			}
			
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void FrmProductMainmenu_Load(object sender, EventArgs e)
		{
			Listar();
		}
		private void Listar()
		{
			ProductoCategoriaControl producto = new ProductoCategoriaControl();
			dataGridView1.DataSource = producto.ListarProductosCategoria();

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar la categoria de producto?", "Importante", MessageBoxButtons.YesNo);

				if (result == DialogResult.Yes)
				{
					int idProductoCategoria = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
					ProductoCategoriaControl producto = new ProductoCategoriaControl();
					producto.EliminarProductoCategoria(idProductoCategoria);
					
					Listar();
				}
			}
			else
			{
				MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
			}
		}
	}
}
