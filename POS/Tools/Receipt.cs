using iTextSharp.text;
using iTextSharp.text.pdf;
using POS.Entity;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace POS.Tools
{
    public class Receipt
    {
        public static void GenerateReceipt(Recibo recibo)
        {
            try
            {
                Document document;
                FileStream fileStream;
                string path = "files\\";
                const int STRING_LENGTH = 5;

                string date = DateTime.Now.ToString().Replace("/", "-").Replace(" ", String.Empty).Replace(":", ".");
                string nameDocument = recibo.Numero + "." + date + ".pdf";
                path += nameDocument;
                document = new Document(PageSize.A6);
                document.SetMargins(5, 5, 10, 3);

                //Añadimos logo
                Image header = Image.GetInstance("images\\header.jpg");
                header.ScaleAbsolute(150, 50);

                //Colocamos la ruta donde se guardara el archivo
                fileStream = new FileStream(path, FileMode.Create);

                // Indicamos donde vamos a guardar el documento
                PdfWriter writer = PdfWriter.GetInstance(document, fileStream);

                //Abrimos el documento
                document.Open();

                //Añadimos fuentes
                Font f1 = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f);
                f1.SetColor(67, 105, 182);
                Font f2 = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                f2.SetColor(227, 34, 34);
                Font f3 = FontFactory.GetFont(FontFactory.HELVETICA, 9.5f);
                f3.SetColor(0, 0, 0);
                Font fontTitle = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11f);
                f1.SetColor(67, 105, 182);
                Font companyDataFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9.5f);
                companyDataFont.SetColor(0, 0, 0);

                //Creamos la tabla
                PdfPTable table = new PdfPTable(3);

                PdfPCell cell = new PdfPCell(header);
                cell.BorderWidth = 0;
                cell.Colspan = 3;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                Phrase owner = new Phrase("NOMBRE PROPIETARIO", companyDataFont);
                cell = new PdfPCell(owner);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                Phrase phone = new Phrase("Contacto: CELULAR - TELEFONO", companyDataFont);
                cell = new PdfPCell(phone);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                Phrase separator = new Phrase("----------------------------------------------------------------", f1);
                cell = new PdfPCell(separator);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                Phrase receipt = new Phrase("RECIBO", fontTitle);
                cell = new PdfPCell(receipt);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                cell = new PdfPCell();
                Paragraph p1 = new Paragraph("Nº " + ConvertNumberToFormat.ConvertNumberToReceiptFormat(recibo.Numero, STRING_LENGTH), f2);
                p1.Alignment = Element.ALIGN_RIGHT;
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.AddElement(p1);
                table.AddCell(cell);

                Chunk c1 = new Chunk("RECIBÍ DE: ", f1);
                Phrase phrase = new Phrase();
                phrase.Add(c1);
                cell = new PdfPCell(phrase);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 0;
                table.AddCell(cell);

                Chunk c2 = new Chunk(recibo.NombreQuienPaga, f3);
                phrase = new Phrase();
                phrase.Add(c2);
                cell = new PdfPCell(phrase);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 0;
                table.AddCell(cell);

                c1 = new Chunk("\nLA SUMA DE: ", f1);
                ConvertNumberToWords convertNumberToWords = new ConvertNumberToWords();
                convertNumberToWords.LetraCapital = true;
                convertNumberToWords.SeparadorDecimalSalida = "bolivianos";
                phrase = new Phrase();
                phrase.Add(c1);
                cell = new PdfPCell(phrase);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 0;
                table.AddCell(cell);

                c2 = new Chunk(convertNumberToWords.ToCustomCardinal(recibo.MontoTotal), f3);
                phrase = new Phrase();
                phrase.Add(c2);
                cell = new PdfPCell(phrase);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 0;
                table.AddCell(cell);

                c1 = new Chunk("\nPOR CONCEPTO DE: ", f1);
                c2 = new Chunk(recibo.Concepto, f3);
                phrase = new Phrase();
                phrase.Add(c1);
                phrase.Add(c2);
                cell = new PdfPCell(phrase);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 0;
                table.AddCell(cell);

                c1 = new Chunk("\nMONTO TOTAL: ", f1);
                c2 = new Chunk((recibo.MontoTotal).ToString(), f3);
                Chunk c3 = new Chunk(" BS.", f1);
                phrase = new Phrase();
                phrase.Add(c1);
                phrase.Add(c2);
                phrase.Add(c3);
                cell = new PdfPCell(phrase);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 0;
                table.AddCell(cell);

                Chunk enter = new Chunk("\n");
                Phrase final = new Phrase();
                for (int i = 0; i < 3; i++)
                {
                    final.Add(enter);
                }
                cell = new PdfPCell(final);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                c1 = new Chunk("Cochabamba, ", f1);
                c2 = new Chunk(recibo.Fecha.Day.ToString(), f3);
                c3 = new Chunk(" de ", f1);
                Chunk c4 = new Chunk(DateUtils.MonthName(recibo.Fecha.Month), f3);
                Chunk c5 = new Chunk(recibo.Fecha.Year.ToString(), f3);
                phrase = new Phrase();
                phrase.Add(c1);
                phrase.Add(c2);
                phrase.Add(c3);
                phrase.Add(c4);
                phrase.Add(c3);
                phrase.Add(c5);
                cell = new PdfPCell(phrase);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                Chunk thanks = new Chunk("¡Muchas gracias!", companyDataFont);
                Phrase footer = new Phrase();
                footer.Add(thanks);
                footer.Add(enter);
                cell = new PdfPCell(footer);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                cell = new PdfPCell(separator);
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                //Añadimos la tabla
                document.Add(table);

                //Cerramos el documento
                document.Close();
                writer.Close();

                //Abrimos el documento
                Process.Start(path);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción: " + e.Message);
            }
        }
    }
}
