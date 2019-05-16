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
	public partial class FrmCategoryMainMenu : Form
	{
		public FrmCategoryMainMenu()
		{
			InitializeComponent();
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			FrmAddCategory frmaddCategory = new FrmAddCategory();
				frmaddCategory.Show();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				int idCategoria = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
				string nombre = dataGridView1.SelectedCells[1].Value.ToString();
				string descripcion = dataGridView1.SelectedCells[2].Value.ToString();
				

				FrmUpdateCategory frmupdatecategory = new FrmUpdateCategory();
				frmupdatecategory.Show();
				frmupdatecategory.RellenarDatos(idCategoria, nombre, descripcion);
			}
			else
			{
				MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
			}
			
		}

		private void FrmCategoryMainMenu_Load(object sender, EventArgs e)
		{
			ListarCategoria();
		}
		public void ListarCategoria()
		{
			CategoriaControl categoria = new CategoriaControl();
			dataGridView1.DataSource = categoria.ListarCateogorias();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar la categoria?", "Importante", MessageBoxButtons.YesNo);

				if (result == DialogResult.Yes)
				{
					int idcategoria = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
					CategoriaControl categoriactrl = new CategoriaControl();
					categoriactrl.EliminarCategoria(idcategoria);
					ListarCategoria();
				}
			}
			else
			{
				MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
			}
		}
	}
}
