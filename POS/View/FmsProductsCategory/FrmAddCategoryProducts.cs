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
	public partial class FrmAddCategoryProducts : Form
	{
		int idProducto =0;
		public FrmAddCategoryProducts()
		{
			InitializeComponent();
		}

		private void brnregistro_Click(object sender, EventArgs e)
		{
			if (label5.Text != "")
			{
				ProductoCategoriaControl producto = new ProductoCategoriaControl();
				producto.InsertarProductoCategoria(idProducto, Convert.ToInt32(cbCategoria.SelectedValue));
				MessageBox.Show("registro correcto");
			}
			else
			{
				MessageBox.Show("Datos incompletos");
			}
		}

		private void FrmAddCategoryProducts_Load(object sender, EventArgs e)
		{
			Listar();
		}
		public void Listar()
		{
			ProductoControl productoControl = new ProductoControl();
			dataGridView1.DataSource = productoControl.ListarProductos();
			CategoriaControl categorias = new CategoriaControl();
			DataTable categoria = categorias.Listar();
			cbCategoria.DataSource = categoria;
			cbCategoria.ValueMember = "ID CATEGORIA";
			cbCategoria.DisplayMember = "NOMBRE CATEGORIA";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				label5.Text = dataGridView1.SelectedCells[2].Value.ToString();
			    idProducto = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
					
				
			}
			else
			{
				MessageBox.Show("¡Debe seleccionar a un producti!", "Error");
			}
		}
	}
}
