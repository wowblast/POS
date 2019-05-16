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
	public partial class FrmAddCategory : Form
	{
		public FrmAddCategory()
		{
			InitializeComponent();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtNombre.Text != cbcategoria.SelectedText)
				{
					CategoriaControl categoriaControl = new CategoriaControl();
					categoriaControl.AñadirCategoria(txtNombre.Text, txtDescripcion.Text, Convert.ToInt32(cbcategoria.SelectedValue));
					MessageBox.Show("Se ha registrado al proveedor exitosamente", "Registro exitoso");
				} else
				{
					MessageBox.Show("La subategoria no puede ser la misma que la categoria ");
				}

			}
			catch (Exception )
			{
				MessageBox.Show("Ocurrion un error al registrar");
			}		

		}
		public void CargasCategorias()
		{
			CategoriaControl categoriaControl = new CategoriaControl();
			DataTable subcategorias = categoriaControl.ListarCateogorias();
			cbcategoria.DataSource = subcategorias;
			cbcategoria.ValueMember = "ID CATEGORIA";
			cbcategoria.DisplayMember = "NOMBRE CATEGORIA";
		}

		private void FrmAddCategory_Load(object sender, EventArgs e)
		{
			CargasCategorias();
		}
	}
}
