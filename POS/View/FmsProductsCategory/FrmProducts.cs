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
        private bool imageAdded = false;
        private byte[] binaryImage;

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

		private void FrmProducts_Load(object sender, EventArgs e)
		{
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
			try{
				if (imageAdded)
				{
					ProductoControl productoControl = new ProductoControl();
					string idProducto = productoControl.InsertarProducto(Convert.ToInt32(comboBox2.SelectedValue), textBox8.Text, textBox7.Text, Convert.ToDouble(textBox2.Text), Convert.ToInt32(textBox1.Text));
					ImagenProducto image = new ImagenProducto();
					image.InsertarImagen(Convert.ToInt32(idProducto), binaryImage);
					textBox7.Text = "";
					textBox8.Text = "";
					textBox2.Text = "";
					textBox1.Text = "";

					imageAdded = false;
				}
				else
				{
					MessageBox.Show("seleccione imagen");
				}
			}catch(Exception)
			{
				MessageBox.Show("datos incorrectos");
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
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
    }
}
