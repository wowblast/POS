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
		bool imageAdded = false;
		byte[] binaryImage;
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
			//dataGridView1.DataSource = productoControl.ListarProductos();
			//dataGridView2.DataSource = productoControl.ListarProductos();
		}

		private void RegistrarProducto_Click(object sender, EventArgs e)
		{
			if (imageAdded)
			{


				ProductoControl productoControl = new ProductoControl();
				/*string idProducto = productoControl.InsertarProducto(1, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
				ImagenProducto image = new ImagenProducto();
				image.InsertarImagen(Convert.ToInt32(idProducto), binaryImage);
				textBox3.Text = "";
				textBox4.Text = "";
				textBox5.Text = "";
				textBox6.Text = "";
				Listar();
				imageAdded = false;*/
			}
			else
			{
				MessageBox.Show("seleccione imagen");
			}



		}

		private void EliminarProducto_Click(object sender, EventArgs e)
		{
			/*if (dataGridView2.SelectedRows.Count == 1)
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
			}*/
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{
			Listar();
		}

		private void FrmProducts_Load(object sender, EventArgs e)
		{
			Listar();
			TiendaControl tienda = new TiendaControl();
			DataTable estantes = tienda.ListarEstantes();
			comboBox2.DataSource = estantes;
			comboBox2.ValueMember = "ID ESTANTE";
			comboBox2.DisplayMember = "ESTANTE";
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}		

		private void button3_Click(object sender, EventArgs e)
		{
			if (imageAdded)
			{
				ProductoControl productoControl = new ProductoControl();
				string idProducto = productoControl.InsertarProducto(Convert.ToInt32(comboBox2.SelectedValue), textBox8.Text, textBox7.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text));
				ImagenProducto image = new ImagenProducto();
				image.InsertarImagen(Convert.ToInt32(idProducto), binaryImage);
				textBox7.Text = "";
				textBox8.Text = "";
				textBox2.Text = "";
				textBox1.Text = "";
				Listar();
				imageAdded = false;
			}
			else
			{
				MessageBox.Show("seleccione imagen");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					string imagen = openFileDialog1.FileName;
					pictureBox1.Image = Image.FromFile(imagen);

					binaryImage = ImageToByteArray(Image.FromFile(imagen));

					imageAdded = true;
					//image.InsertarImagen(te)
					
					
					MessageBox.Show("imagen cargada");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
			}
		}
		public byte[] ImageToByteArray(System.Drawing.Image imageIn)
		{
			using (var ms = new MemoryStream())
			{
				imageIn.Save(ms, imageIn.RawFormat);
				return ms.ToArray();
			}
		}
	}
}
