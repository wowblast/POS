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
	public partial class FrmUpdateCategoryProduct : Form
	{
		int idproductoCategoria;
		string name;		

		public FrmUpdateCategoryProduct(int productoCategoria, string name)
		{
			InitializeComponent();

			idproductoCategoria = productoCategoria;
			this.name = name;
		}

		private void FrmUpdateCategoryProduct_Load(object sender, EventArgs e)
		{
			Listar();
		}
		public void Listar()
		{ 
			CategoriaControl categorias = new CategoriaControl();
			DataTable categoria = categorias.ListarCateogorias();
			cbCategoria.DataSource = categoria;
			cbCategoria.ValueMember = "ID CATEGORIA";
			cbCategoria.DisplayMember = "NOMBRE CATEGORIA";
			label5.Text = name;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnActualizarDatos_Click(object sender, EventArgs e)
		{
			ProductoCategoriaControl producto = new ProductoCategoriaControl();
			producto.ActualizarProductoCategoria(idproductoCategoria, Convert.ToInt32(cbCategoria.SelectedValue));
		}
	}
}
