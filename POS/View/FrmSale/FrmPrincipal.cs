using POS.Control;
using POS.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmPrincipal : Form
    {
        private int imageSize = 0;
		private List<string[]> compras = new List<string[]>();

		public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPurchaseAmount frmPurchaseAmount = new FrmPurchaseAmount();
            frmPurchaseAmount.Show();
        }

        public Button CreateButton(int height, int width, string name, string text, string filename)
        {
            Button button = new Button();
            button.Height = height;
            button.Width = width;
            button.Name = name;
            button.Text = text;
            button.BackgroundImage = Image.FromFile(filename);
            button.BackgroundImageLayout = ImageLayout.Center;

            return button;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (CuentaActual.Cargo == "ADMINISTRADOR")
            {
                FrmMainMenu frmMainMenu = new FrmMainMenu();
                frmMainMenu.Show();
                Close();
            }
            else
            {
                FrmMainMenuEmployee frmMainMenuEmployee = new FrmMainMenuEmployee();
                frmMainMenuEmployee.Show();
                Close();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ProductoControl productoControl = new ProductoControl();
            ImagenProducto imagenProducto = new ImagenProducto();

            DataTable productList = productoControl.ListarProductos();
            
            
            if (productList.Rows.Count > 0)
            {
                const int COLUMNS = 5;

                imageSize = tableLayout.Size.Width / COLUMNS;

                tableLayout.ColumnCount = COLUMNS;
                tableLayout.RowCount = Convert.ToInt32((float)productList.Rows.Count / COLUMNS) + 1;

                for (int i = 0; i < tableLayout.RowCount; i++)
                {
                    for (int j = 0; j < tableLayout.ColumnCount; j++)
                    {
                        int index = i * COLUMNS + j;

                        if (index < productList.Rows.Count)
                        {
                            Button button = new Button
                            {
                                Size = new Size(imageSize, imageSize),
                            };

                            object image = imagenProducto.SelectImage((int)productList.Rows[index].ItemArray[0]);
                            BinaryFormatter bf = new BinaryFormatter();
                            MemoryStream ms = new MemoryStream();
                            bf.Serialize(ms, image);
                            byte[] aux = (byte[])image;
                            ImageConverter ic = new ImageConverter();
                            Image img = (Image)ic.ConvertFrom(aux);
                            
                            button.BackgroundImage = ResizeImage(img, imageSize, imageSize);

                            tableLayout.Controls.Add(button, j, i);
                        }
                    }
                }
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

		private void Button2_Click(object sender, EventArgs e)
		{
			int id = 10;
			string name = "rustbold";
			double price = 7.77;
			int quantity = 20;
			string[] row = { id.ToString(), name, price.ToString(),quantity.ToString()};
			//List <string[] > compras = new List<string []>();
			//compras.Add(row);
			//compras.Add(row);
			var listViewItem = new ListViewItem(row);
			//dataGridView1.Rows.Add(row);
			//listView1.itemso(testc);
			addItem(id.ToString(), name, price.ToString(), quantity.ToString());
		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void addItem(string id,string name , string price, string quantoty)
		{
			string[] row = { id, name, price, quantoty };
			actualizar_compras(row);
			dataGridView1.Rows.Clear();
			dataGridView1.Refresh();
			for(int x = 0; x < compras.Count; x++)
			{
				dataGridView1.Rows.Add(compras.ElementAt(x));
			}			
		}
		private void actualizar_compras(string[] row)
		{
			bool newImtem = true;
			for(int x = 0; x < compras.Count; x++)
			{
				if (compras.ElementAt(x)[0] == row[0])
				{
					double newQuantity = Convert.ToDouble(compras.ElementAt(x)[3]) + Convert.ToDouble(row[3]);
					compras.ElementAt(x)[3] = newQuantity.ToString();
					newImtem = false;
					break;
				}
			}
			if (newImtem)
			{
				compras.Add(row);				
			}

		}
	}
}
