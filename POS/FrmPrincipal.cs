using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmPrincipal : Form
    {
        private int width;
        private int height;
        private int heightScroll;
        private int counter;

        public FrmPrincipal()
        {
            InitializeComponent();
            width = 0;
            counter = 0;

            // Get height scroll 
            heightScroll = 3 * tableLayoutPanel2.GetColumnWidths()[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPurchaseAmount frmPurchaseAmount = new FrmPurchaseAmount();
            frmPurchaseAmount.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult button = MessageBox.Show("¿Esta seguro que desea eliminar el producto seleccionado?","Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (button == DialogResult.OK)
                {
                    //Delete product
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "¡Error!");
            }
        }

        private void btnUpdateProductData_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                FrmUpdateProduct frmUpdateProduct = new FrmUpdateProduct();
                frmUpdateProduct.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "¡Error!");
            }
        }

        private void numBtn_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
           
            txtPrueba.Text = txtPrueba.Text + number.Text;
            if (txtPrueba.Text.Equals("0"))
            {
                txtPrueba.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrueba.Clear();
        }

        private void btnKeyBoard_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

		private void button13_Click(object sender, EventArgs e)
		{
			//metodo testeo
			AddProduct("1", "vino", "5", "5");
			UpdateCostTotal();

		}

		private void AddProduct(string id ,string name ,string price ,string quantity)
		{
			
			string[] row = {id, name, price,quantity };
			var listViewItem = new ListViewItem(row);
			listView1.Items.Add(listViewItem);
		}
		private void UpdateCostTotal()
		{
			int costTotal = 0;
		    foreach (ListViewItem row in listView1.Items)
			{
				costTotal += Int32.Parse(row.SubItems[2].Text )* Int32.Parse(row.SubItems[3].Text);
			}
			txtPrueba.Text = "Total Cost" +costTotal.ToString();
		}

		private void txtPrueba_TextChanged(object sender, EventArgs e)
		{

		}

        private void btnList_Click(object sender, EventArgs e)
        {
            counter++;

            // Get size with respect to the percentage            
            width = tableLayoutPanel2.GetColumnWidths()[0];
            height = width;

            if (counter > 5)
            {
                heightScroll += 2 * height;
                counter = 0;
            }

            // Add button in tablelayout 
            // Please change filename image
            Button button = CreateButton(height, width, "btn", "texto", @"C:\Users\Adriana Orellana\source\repos\POS\POS\Images\buy.png");
            tableLayoutPanel2.Controls.Add(button);

            tableLayoutPanel2.AutoScrollMinSize = new Size(tableLayoutPanel2.Width, heightScroll);
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
    }
}
