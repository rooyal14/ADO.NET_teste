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

namespace ControllerProject
{
    public class GerarRelatorioPDF
    {
        UserController userController = new UserController();
        /*
        static void GerarReltoriosPDF()
        {
            //https://www.youtube.com/watch?v=Gm2pJfCJyUw

            var pessoasSelecionadas = pessoas.Take(qtdePessoas).ToList();
            if (pessoasSelecionadas.Count > 0)
            {
                //calculo do total de páginas
                //1a página - 24 registros
                //2a em diante - 29 registros
                //100 registros -> -24 = 76 -> / 29 = 2.alguma coisa
                int totalPaginas = 1;
                if (pessoasSelecionadas.Count > 24)
                    totalPaginas += (int)Math.Ceiling(
                        (pessoasSelecionadas.Count - 24) / 29F);
            
                //configurar dados do PDF
                var pxPorMm = 72 / 25.2F;
                var pdf = new Document(PageSize.A4, 15 * pxPorMm, 15 * pxPorMm,
                    15 * pxPorMm, 20 * pxPorMm);
                var nomeArquivo = $"pessoas.{DateTime.Now.ToString("yyyy.MM.dd.hh.mm.ss")}.pdf";
                var arquivo = new FileStream(nomeArquivo, FileMode.Create);
                var writer = PdfWriter.GetInstance(pdf, arquivo);
                writer.PageEvent = new RodapeRelatorioPDF(totalPaginas);
                pdf.Open();

                var fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

                //adiciona um título
                var fonteParagrafo = new iTextSharp.text.Font(fonteBase, 32,
                    iTextSharp.text.Font.NORMAL, BaseColor.Black);
                var titulo = new Paragraph("Relatório de Pessoas\n\n", fonteParagrafo);
                titulo.Alignment = Element.ALIGN_LEFT;
                titulo.SpacingAfter = 4;
                pdf.Add(titulo);

                //adiciona um link                
                var fonteLink = new iTextSharp.text.Font(
                    fonteBase, 9.9f, Font.NORMAL, iTextSharp.text.BaseColor.Blue);
                var link = new Chunk("Canal do Prof. Ricardo Maroquio", fonteLink);
                var larguraTexto = fonteBase.GetWidthPoint(link.Content, fonteLink.Size);
                link.SetAnchor("https://www.youtube.com/maroquio");
                var caixaTexto = new ColumnText(writer.DirectContent);
                caixaTexto.AddElement(link);
                caixaTexto.SetSimpleColumn(
                    pdf.PageSize.Width - pdf.RightMargin - larguraTexto,
                    pdf.PageSize.Height - pdf.TopMargin - (30 * pxPorMm),
                    pdf.PageSize.Width - pdf.RightMargin,
                    pdf.PageSize.Height - pdf.TopMargin - (18 * pxPorMm));
                caixaTexto.Go();

                //adiciona uma imagem
                var caminhoImagem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "img\\youtube.png");
                if (File.Exists(caminhoImagem))
                {
                    iTextSharp.text.Image logo =
                        iTextSharp.text.Image.GetInstance(caminhoImagem);
                    float razaoLarguraAltura = logo.Width / logo.Height;
                    float alturaLogo = 32;
                    float larguraLogo = alturaLogo * razaoLarguraAltura;
                    logo.ScaleToFit(larguraLogo, alturaLogo);
                    var margemEsquerda = pdf.PageSize.Width - pdf.RightMargin - larguraLogo;
                    var margemTopo = pdf.PageSize.Height - pdf.TopMargin - 54;
                    logo.SetAbsolutePosition(margemEsquerda, margemTopo);
                    writer.DirectContent.AddImage(logo, false);
                }

                //adiciona uma tabela
                var tabela = new PdfPTable(5);
                float[] larguras = { 0.6f, 2f, 1.5f, 1f, 1f };
                tabela.SetWidths(larguras);
                tabela.DefaultCell.BorderWidth = 0;
                tabela.WidthPercentage = 100;

                //adiciona os títulos das colunas
                CriarCelulaTexto(tabela, "Código", PdfPCell.ALIGN_CENTER, true);
                CriarCelulaTexto(tabela, "Nome", PdfPCell.ALIGN_LEFT, true);
                CriarCelulaTexto(tabela, "Profissão", PdfPCell.ALIGN_CENTER, true);
                CriarCelulaTexto(tabela, "Salário", PdfPCell.ALIGN_CENTER, true);
                CriarCelulaTexto(tabela, "Empregada", PdfPCell.ALIGN_CENTER, true);

                foreach (var p in pessoasSelecionadas)
                {
                    CriarCelulaTexto(tabela, p.IdPessoa.ToString("D6"), PdfPCell.ALIGN_CENTER);
                    CriarCelulaTexto(tabela, p.Nome + " " + p.Sobrenome);
                    CriarCelulaTexto(tabela, p.Profissao.Nome, PdfPCell.ALIGN_CENTER);
                    CriarCelulaTexto(tabela, p.Salario.ToString("C2"), PdfPCell.ALIGN_RIGHT);
                    //CriarCelulaTexto(tabela, p.Empregado ? "Sim" : "Não", PdfPCell.ALIGN_CENTER);
                    var caminhoImagemCelula = p.Empregado ?
                        "img\\emoji_feliz.png" : "img\\emoji_triste.png";
                    caminhoImagemCelula = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                        caminhoImagemCelula);
                    criarCelulaImagem(tabela, caminhoImagemCelula, 20, 20);
                }



                pdf.Add(tabela);

                pdf.Close();
                arquivo.Close();

                var caminhoPDF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);
                if (File.Exists(caminhoPDF))
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        //Arguments = $"/c start firefox {caminhoPDF}",
                        Arguments = $"/c start {caminhoPDF}",
                        CreateNoWindow = true,
                        FileName = "cmd.exe"
                    });
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto foi retornado.");
            }
        }

        static void CriarCelulaTexto(PdfPTable tabela, string texto,
            int alinhamento = PdfPCell.ALIGN_LEFT,
            bool negrito = false, bool italico = false,
            int tamanhoFonte = 12, int alturaCelula = 25)
        {
            int estilo = iTextSharp.text.Font.NORMAL;
            if (negrito && italico)
            {
                estilo = iTextSharp.text.Font.BOLDITALIC;
            }
            else if (negrito)
            {
                estilo = iTextSharp.text.Font.BOLD;
            }
            else if (italico)
            {
                estilo = iTextSharp.text.Font.ITALIC;
            }

            BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            iTextSharp.text.Font fonte = new iTextSharp.text.Font(fonteBase, tamanhoFonte,
                estilo, iTextSharp.text.BaseColor.Black);

            //cor de fundo diferente para linhas pares e ímpares
            var bgColor = iTextSharp.text.BaseColor.White;
            if (tabela.Rows.Count % 2 == 1)
                bgColor = new BaseColor(0.95f, 0.95f, 0.95f);

            PdfPCell celula = new PdfPCell(new Phrase(texto, fonte));
            celula.HorizontalAlignment = alinhamento;
            celula.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            celula.Border = 0;
            celula.BorderWidthBottom = 1;
            celula.PaddingBottom = 5; //pra alinhar melhor verticalmente
            celula.FixedHeight = alturaCelula;
            celula.BackgroundColor = bgColor;
            tabela.AddCell(celula);
        }

        static void criarCelulaImagem(PdfPTable tabela, string caminhoImagem,
            int larguraImagem, int alturaImagem, int alturaCelula = 25)
        {
            //cor de fundo diferente para linhas pares e ímpares
            var bgColor = iTextSharp.text.BaseColor.White;
            if (tabela.Rows.Count % 2 == 1)
                bgColor = new BaseColor(0.95f, 0.95f, 0.95f);

            if (File.Exists(caminhoImagem))
            {
                iTextSharp.text.Image imagem =
                    iTextSharp.text.Image.GetInstance(caminhoImagem);
                imagem.ScaleToFit(larguraImagem, alturaImagem);
                PdfPCell celula = new PdfPCell(imagem);
                celula.HorizontalAlignment = PdfCell.ALIGN_CENTER;
                celula.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                celula.Border = 0;
                celula.BorderWidthBottom = 1;
                celula.FixedHeight = alturaCelula;
                celula.BackgroundColor = bgColor;
                tabela.AddCell(celula);
            }
            else
            {
                tabela.AddCell("ERRO");
            }
        }
        */
        public void geralRelatorioClientesCadastrados()
        {
            var pxPorMm = 72 / 25.2F;
            var pdf = new Document(PageSize.A4, 15 * pxPorMm, 15 * pxPorMm,
                15 * pxPorMm, 20 * pxPorMm);
            var nomeArquivo = "meuPdfTesteClientes.pdf";
            var arquivo = new FileStream(nomeArquivo, FileMode.Create);
            var writer = PdfWriter.GetInstance(pdf, arquivo);
            writer.PageEvent = new RodapeRelatorioPDF(1);
            pdf.Open();

            //adiciona um título
            var titulo = new Paragraph("Relatório de Pessoas\n\n");
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.SpacingAfter = 4;
            pdf.Add(titulo);

            //adiciona a tabela
            DataTable tbUsuarios = userController.getChangeableUsersFromDB();
            PdfPTable pdfTable = new PdfPTable(tbUsuarios.Columns.Count);
            foreach (DataColumn c in tbUsuarios.Columns)
            {

                pdfTable.AddCell(new Phrase(c.ColumnName));
            }

            foreach (DataRow r in tbUsuarios.Rows)
            {
                if (tbUsuarios.Rows.Count > 0)
                {
                    foreach(var content in r.ItemArray)
                    {
                        pdfTable.AddCell(new Phrase(content.ToString()));
                    }
                    /*
                    pdfTable.AddCell(new Phrase(r[0].ToString()));
                    pdfTable.AddCell(new Phrase(r[1].ToString()));
                    pdfTable.AddCell(new Phrase(r[2].ToString()));
                    pdfTable.AddCell(new Phrase(r[3].ToString()));
                    */
                }
            }
            pdf.Add(pdfTable);
            pdf.Close();
        }

    }
}
