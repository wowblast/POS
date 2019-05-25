using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Tools
{
    class PDF
    {
        private Document documento;
        private FileStream archivo;
        private PdfWriter writer;
        private string cabecera;
        private string cuerpo;
        private string final;

        public PDF()
        {
            documento = new Document(PageSize.LETTER, 0, 0, 0, 0);
            archivo = new FileStream(@"C:\Users\Adriana Orellana\source\repos\POS\POS\prueba.pdf", FileMode.Create);
            writer = PdfWriter.GetInstance(documento, archivo);

            cabecera = "";
            cuerpo = "";
            final = "";
        }

        public void GenerarDocumento()
        {
            documento.Open();

            GenerarCabecera();

            documento.Add(new Paragraph(cabecera));
            documento.Add(new Paragraph(cuerpo));
            documento.Add(new Paragraph(final));

            documento.Close();

            MessageBox.Show("¡Archivo de inventario generado correctamente!");
        }

        public void GenerarCabecera()
        {
            /* PdfPTable table = new PdfPTable();

            for (int i = 0; i < Phrase())
            {

            }

            */
        }

        public void SetCabecera(string cabecera)
        {
            this.cabecera = cabecera;
        }

        public void SetCuerpo(string cuerpo)
        {
            this.cuerpo = cuerpo;
        }

        public void SetFinal(string final)
        {
            this.final = final;
        }
    }
}
