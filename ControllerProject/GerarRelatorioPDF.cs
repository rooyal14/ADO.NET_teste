using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelProject;

namespace ControllerProject
{
    public class GerarRelatorioPDF
    {
        UserController userController = new UserController();
       
        public DataTable gerarDataTableClientesCadastrados()
        {
            var command = DBCon.Conn().CreateCommand();
            command.CommandText = "EXEC RelatorioClientesCadastrados";
            DataTable dt = DBCon.queryDataTable(command);
            return dt;
        }

        public DataTable gerarDataTableEstoqueLivros()
        {
            var command = DBCon.Conn().CreateCommand();
            command.CommandText = "EXEC RelatorioEstoqueLivros";
            DataTable dt = DBCon.queryDataTable(command);
            return dt;
        }

        public DataTable gerarDataTableFechamentoDeCaixa()
        {
            var command = DBCon.Conn().CreateCommand();
            command.CommandText = "EXEC RelatorioFechamentoDeCaixa";
            DataTable dt = DBCon.queryDataTable(command);
            return dt;
        }

        public DataTable gerarDataTableLivrosMaisVendidos()
        {
            var command = DBCon.Conn().CreateCommand();
            command.CommandText = "EXEC RelatorioLivrosMaisVendidos";
            DataTable dt = DBCon.queryDataTable(command);
            return dt;
        }

        public DataTable gerarDataTablePedidosRealizados()
        {
            var command = DBCon.Conn().CreateCommand();
            command.CommandText = "EXEC RelatorioPedidosRealizados";
            DataTable dt = DBCon.queryDataTable(command);
            return dt;
        }


        public void geralRelatorios(DataTable dt, string path, string tituloRelatorio)
        {
            var pxPorMm = 72 / 25.2F;
            var pdf = new Document(PageSize.A4, 15 * pxPorMm, 15 * pxPorMm,
                15 * pxPorMm, 20 * pxPorMm);
            var nomeArquivo = path;
            var arquivo = new FileStream(nomeArquivo, FileMode.Create);
            var writer = PdfWriter.GetInstance(pdf, arquivo);
            writer.PageEvent = new RodapeRelatorioPDF(1);
            pdf.Open();

            //adiciona um título
            var titulo = new Paragraph(tituloRelatorio+"\n\n");
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.SpacingAfter = 4;
            pdf.Add(titulo);

            //adiciona a tabela
            PdfPTable pdfTable = new PdfPTable(dt.Columns.Count);
            foreach (DataColumn c in dt.Columns)
            {

                pdfTable.AddCell(new Phrase(c.ColumnName));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach(var content in r.ItemArray)
                    {
                        pdfTable.AddCell(new Phrase(content.ToString()));
                    }

                }
            }
            pdf.Add(pdfTable);
            pdf.Close();
            arquivo.Close();
        }

    }
}
