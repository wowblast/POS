using POS.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.FmsProductsCategory
{
	public partial class FrmUpdateProduct : Form
	{
		int idProducto;		
		string descripcion;
		string nombre;
		float precio;
		int cantidad;
		byte[] binaryImage;
		bool imageAdded;

		public FrmUpdateProduct(int idProducto, string descripcion, string nombre, float precio, int cantidad)
		{
			InitializeComponent();
			this.idProducto = idProducto;
			this.descripcion = descripcion;
			this.nombre = nombre;
			this.precio = precio;
			this.cantidad = cantidad;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			FrmProductCategoryMainMenu main = new FrmProductCategoryMainMenu();
			main.Show();
			this.Close();
		}

		private void FrmUpdateProduct_Load(object sender, EventArgs e)
		{
			ImagenProducto imagen = new ImagenProducto();
			object actual_image = imagen.SelectImage(idProducto);
			BinaryFormatter bf = new BinaryFormatter();
			MemoryStream ms = new MemoryStream();
			bf.Serialize(ms, actual_image);
			byte[] aux = (byte[])actual_image;
			//MemoryStream memstr = new MemoryStream(ms.ToArray());
			ImageConverter ic = new ImageConverter();
			Image img = (Image)ic.ConvertFrom(aux);			
			pictureBox1.Image = img;
			textBox8.Text = nombre;
			textBox7.Text = descripcion;
			textBox2.Text = precio.ToString();
			textBox1.Text = cantidad.ToString();

			TiendaControl tienda = new TiendaControl();
			DataTable estantes = tienda.ListarEstantes();
			comboBox2.DataSource = estantes;
			comboBox2.ValueMember = "ID ESTANTE";
			comboBox2.DisplayMember = "ESTANTE";
		}

		private void btnActualizarDatos_Click(object sender, EventArgs e)
		{
			if (textBox8.Text != "" && textBox2.Text != "" && textBox1.Text != "")
			{
				ImagenProducto newimagen = new ImagenProducto();
				ProductoControl newproducto = new ProductoControl();
				newimagen.UpdateImage(idProducto, binaryImage);
				newproducto.ActualizarProducto(idProducto, Convert.ToInt32(comboBox2.SelectedValue), textBox8.Text, textBox7.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text));
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
