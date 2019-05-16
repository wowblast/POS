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

namespace POS.FrmsCategoria
{
	public partial class FrmUpdateCategory : Form
	{
		private int idCategoria;
		public FrmUpdateCategory()
		{
			InitializeComponent();
			idCategoria = 0;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void FrmUpdateCategory_Load(object sender, EventArgs e)
		{
			CategoriaControl categoriacontrol = new CategoriaControl();
			DataTable categorias = categoriacontrol.ListarCateogorias();
			cbCategoria.DataSource = categorias;
			cbCategoria.ValueMember = "ID CATEGORIA";
			cbCategoria.DisplayMember = "NOMBRE CATEGORIA";
		}

		private void btnActualizarDatos_Click(object sender, EventArgs e)
		{
			if (txtNombre.Text != cbCategoria.Text)
			{
				CategoriaControl categoria = new CategoriaControl();
				categoria.ModificarCategoria(idCategoria, txtNombre.Text, txtNombre.Text, Convert.ToInt32(cbCategoria.SelectedValue));
			}else
			{
				MessageBox.Show("La subcategoria no puede ser la misma que");
			}
		}

		public void RellenarDatos(int idCategoria,string nombre,string descripcion)
		{
			this.idCategoria = idCategoria;
			txtNombre.Text = nombre;
			txtDescripcion.Text = descripcion;
		}
	}
}
