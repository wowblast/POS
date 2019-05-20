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

		}

		private void btnActualizarDatos_Click(object sender, EventArgs e)
		{

		}
	}
}
