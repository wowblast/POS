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
			try
			{
				if (dataGridView1.SelectedRows.Count == 1)
				{
					int idProducto = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
					string nombre = dataGridView1.SelectedCells[2].Value.ToString();
					string descripcion = dataGridView1.SelectedCells[3].Value.ToString();
					float precio = Convert.ToSingle(dataGridView1.SelectedCells[4].Value.ToString());
					int cantidad = Convert.ToInt32(dataGridView1.SelectedCells[5].Value.ToString());

					FrmUpdateProduct updateproduct = new FrmUpdateProduct(idProducto, descripcion, nombre, precio, cantidad);
					updateproduct.Show();
					this.Close();
				}
				else
				{
					MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
				}
			}catch(Exception)
			{
				MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
			}

		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			FrmProducts product = new FrmProducts();
			product.Show();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el producto?", "Importante", MessageBoxButtons.YesNo);

				if (result == DialogResult.Yes)
				{
					int idProducto = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
					ProductoControl producto = new ProductoControl();
					producto.EliminarProducto(idProducto);
					ImagenProducto imagen = new ImagenProducto();
					imagen.BorrarImagen(idProducto);
					Listar();
				}
			}
			else
			{
				MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
			}
		}

		private void btnMenuPrincipal_Click(object sender, EventArgs e)
		{
			FrmMainMenu frmMainMenu = new FrmMainMenu();
			frmMainMenu.Show();
			Close();
		}
	}
}
