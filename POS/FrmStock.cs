using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
            Stock();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void Stock()
        {
            InventarioControl inventarioControl = new InventarioControl();
            dataGridView.DataSource = inventarioControl.ConsultarProductosExistentes();
        }

        private void btnGuardarReporte_Click(object sender, EventArgs e)
        {
            Stock();
            GenerarPDF(); 
        }

        private void GenerarPDF()
        {
            Document doc = new Document(PageSize.LETTER,0,0,0,0);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"C:\Users\Adriana Orellana\source\repos\POS\POS\prueba.pdf", FileMode.Create));

            doc.Open();
            doc.Add(new Paragraph("Prueba"));
            doc.Close();

            MessageBox.Show("¡Archivo de inventario generado correctamente!");
        }
    }
}
