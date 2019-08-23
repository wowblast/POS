using POS.Control;
using POS.Entity;
using POS.Singleton;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmPrincipal : Form
    {
        private int imageSize = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPurchaseAmount frmPurchaseAmount = new FrmPurchaseAmount();
            frmPurchaseAmount.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (User.GetInstance().usuario.Cargo == "ADMINISTRADOR")
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
            ListCategories();
            UpdateUserData();

            ProductoControl productoControl = new ProductoControl();
            ImagenProducto imagenProducto = new ImagenProducto();

            DataTable productList = productoControl.ListarProductos();
            
            if (productList.Rows.Count > 0)
            {
                const int COLUMNS = 6;

                imageSize = Convert.ToInt32((tableLayout.Size.Width * 0.95f) / COLUMNS);

                tableLayout.ColumnCount = COLUMNS;
                tableLayout.RowCount = Convert.ToInt32(Math.Ceiling((float)productList.Rows.Count / COLUMNS));
                
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
                                Text = (string)productList.Rows[index].ItemArray[2] + ", " + (double)productList.Rows[index].ItemArray[4] + " bs",
                                TextAlign = ContentAlignment.BottomCenter,
                                Font = new Font(Font.FontFamily, 10),
                                BackColor = Color.White,
                                BackgroundImageLayout = ImageLayout.Center,
                            };

                            Image image = ObjectToImage(imagenProducto.SelectImage((int)productList.Rows[index].ItemArray[0]));
                            
                            if (image != null)
                                button.BackgroundImage = ResizeImage(image, imageSize, imageSize - 40);

                            tableLayout.Controls.Add(button, j, i);
                        }
                    }
                }
            }
        }

        public static Image ObjectToImage(object image)
        {
            if (image == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, image);
            byte[] aux = (byte[])image;
            ImageConverter ic = new ImageConverter();
            Image img = (Image)ic.ConvertFrom(aux);

            return img;
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

        public void ListCategories()
        {
            CategoriaControl categoriaControl = new CategoriaControl();
            DataTable dataTable = categoriaControl.Listar();

            List<Categoria> listCategories = dataTable.AsEnumerable().Select(m => new Categoria()
            {
                IdCategoria = m.Field<int>("ID CATEGORIA"),
                Nombre = m.Field<string>("NOMBRE"),
                Descripcion = m.Field<string>("DESCRIPCION"),
                Subcategoria = m.Field<int>("CATEGORIA A LA QUE PERTENECE"),
            }).ToList();

            listBox.DataSource = listCategories;
            listBox.DisplayMember = "Nombre";
            listBox.ValueMember = "IdCategoria";
        }

        private void UpdateUserData()
        {
            label1.Text = User.GetInstance().usuario.Cargo;
            label2.Text = User.GetInstance().usuario.Nombre + " " + User.GetInstance().usuario.ApellidoPaterno;
        }

    }
}
