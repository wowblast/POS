using POS.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
	public partial class FrmProducts : Form
	{
		public FrmProducts()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			FrmMainMenu frmMainMenu = new FrmMainMenu();
			frmMainMenu.Show();
			Close();
		}

		private void btnBack_Click_1(object sender, EventArgs e)
		{
			FrmMainMenu frmMainMenu = new FrmMainMenu();
			frmMainMenu.Show();
			Close();
		}

		private void btnUpdateProduct_Click(object sender, EventArgs e)
		{
			FrmUpdateProduct frmUpdateProduct = new FrmUpdateProduct();
			frmUpdateProduct.Show();
		}


		public void Listar()
		{
			ProductoControl productoControl = new ProductoControl();
			dataGridView1.DataSource = productoControl.ListarProductos();
			dataGridView2.DataSource = productoControl.ListarProductos();
		}

		private void RegistrarProducto_Click(object sender, EventArgs e)
		{
			ProductoControl productoControl = new ProductoControl();
			productoControl.InsertarProducto(1, textBox3.Text,textBox4.Text,Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			Listar();


		}

		private void EliminarProducto_Click(object sender, EventArgs e)
		{
			if (dataGridView2.SelectedRows.Count == 1)
			{
				DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el producto?", "Importante", MessageBoxButtons.YesNo);

				if (result == DialogResult.Yes)
				{
					int idProducto = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);
					ProductoControl producto = new ProductoControl();
					producto.EliminarProducto(idProducto);
					Listar();
				}
			}
			else
			{
				MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
			}
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{
			Listar();
		}

		private void FrmProducts_Load(object sender, EventArgs e)
		{
			Listar();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					string imagen = openFileDialog1.FileName;
					pictureBox1.Image = Image.FromFile(imagen);
					FileStream fS = new FileStream(imagen, FileMode.Open, FileAccess.Read);
					byte[] b = new byte[fS.Length];
					fS.Read(b, 0, (int)fS.Length);
					fS.Close();
					MessageBox.Show("imagen cargada");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
			}
		}
	}
}
