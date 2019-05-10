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
				CategoriaControl categoriaControl = new CategoriaControl();
				categoriaControl.AñadirEstantería(txtNombre.Text, txtDescripcion.Text, txtSubcategoria.Text);
				MessageBox.Show("Se ha registrado al proveedor exitosamente", "Registro exitoso");

			}
			catch (Exception )
			{
				MessageBox.Show("Ocurrion un error al registrar");
			}		

		}
	}
}
