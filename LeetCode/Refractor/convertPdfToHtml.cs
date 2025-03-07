using iText.Html2pdf;
using iText.Html2pdf.Resolver.Font;
using System.IO;
using System.Text;

namespace LeetCode
{
    public class convertPdfToHtml
    {
        public static void Main()
        {
            byte[] bytes;
           
            using (var memoryStream = new MemoryStream())
            {
                string stringHtml = $@"D:/WORKING-PROJECTS/single-point-be-v2/api/Documents/HTML-Templates/Modules/FATCA/Sequence-1-Main-Form.html";
                StreamReader srBody = new StreamReader(stringHtml);
                string Body = srBody.ReadToEnd();

                ConverterProperties properties = new ConverterProperties();
                properties.SetFontProvider(new DefaultFontProvider(true, true, true));

                HtmlConverter.ConvertToPdf(Body, memoryStream, properties);
                bytes = memoryStream.ToArray();                

                srBody.Close();
                srBody.Dispose();
            }
            // writing PDF output to file for testing
            File.WriteAllBytes($"D://new-fatcaPdf.pdf", bytes); 
        }
    }
}
