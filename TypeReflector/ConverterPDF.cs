using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace TypeReflector
{
    class ConverterPDF
    {
        public static async Task ExtractTextFromPdf()
        {
            StringBuilder text = null;
            try
            {
                    using (PdfReader reader = new PdfReader(Data.strGetPdfFile))
                    {
                        text = new StringBuilder();
                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            text.Append(PdfTextExtractor.GetTextFromPage(reader, i));                            
                        }
                    await Task.WhenAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Data.strPutTxtFile = text.ToString();
            }
        }
     }
}

