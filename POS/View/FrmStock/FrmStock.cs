using iTextSharp.text;
using iTextSharp.text.pdf;
using POS.Control;
using POS.Singleton;
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
        /* private Document documento;
        private FileStream archivo;
        private PdfWriter writer; */

        public FrmStock()
        {
            InitializeComponent();
            Stock();
            ActivarPrivilegios();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
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

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
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

        private void Stock()
        {
            InventarioControl inventarioControl = new InventarioControl();
            dataGridView.DataSource = inventarioControl.ConsultarProductosExistentes();
        }

        private void ActivarPrivilegios()
        {
            if (User.GetInstance().usuario.Cargo != "ADMINISTRADOR")
            {
                btnGuardarReporte.Visible = false;
            }
        }

        private void btnGuardarReporte_Click(object sender, EventArgs e)
        {
            Stock();
            /* PDF pdf = new PDF();
            pdf.SetCabecera("Empresa de electricidad /n Dueño: Mauricio");
            pdf.SetCuerpo("El inventario disponible es..."); */ 
            GenerarCabecera();
        }

        public void GenerarCabecera()
        {
            Document documento = new Document(PageSize.LETTER, 0, 0, 0, 0);
            FileStream archivo = new FileStream(@"C:\Users\Adriana Orellana\source\repos\POS\POS\prueba.pdf", FileMode.Create);
            PdfWriter writer = PdfWriter.GetInstance(documento, archivo);

            documento.Open();

            documento.Add(new Paragraph("Prueba"));

            PdfPTable table = new PdfPTable(dataGridView.Columns.Count);

            for (int j = 0; j < dataGridView.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dataGridView.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView.Columns.Count; k++)
                {
                    if (dataGridView[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView[k, i].Value.ToString()));
                    } 
                }
            }

            documento.Add(table);
            documento.Close();

            MessageBox.Show("Prueba!");
        }
    }
}
