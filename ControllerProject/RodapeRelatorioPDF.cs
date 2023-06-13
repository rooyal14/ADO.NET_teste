﻿using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    class RodapeRelatorioPDF : PdfPageEventHelper
    {
        BaseFont familiaFonteRodape;
        iTextSharp.text.Font fonteRodape;
        int totalPaginas = 0;

        PdfContentByte cb;
        PdfTemplate template;

        public RodapeRelatorioPDF(int totalPaginas)
        {
            familiaFonteRodape = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            fonteRodape = new iTextSharp.text.Font(familiaFonteRodape, 8f,
                Font.NORMAL, iTextSharp.text.BaseColor.Black);
            this.totalPaginas = totalPaginas;
        }

        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            //retorna um objeto que permite escrever direto na página de forma absoluta
            cb = writer.DirectContent;
            //um template pode estar em todas as páginas e ser atualizado somente 
            //no fim da geração do documento, atualizando automaticamente as demais
            //páginas que possuem o template.
            //template = cb.CreateTemplate(25, 50);
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            AdicionarMomentoDaGeracao(writer, document);
            AdicionarNumeroPaginaAtual(writer, document);
            //se for adicionar figura em todas as páginas
            //AdicionarLogoNoCabecalho(writer, document);
        }

        private void AdicionarMomentoDaGeracao(PdfWriter writer, Document document)
        {
            String textoDataGeracao = $"Gerado em {DateTime.Now.ToShortDateString()} às " +
                $"{DateTime.Now.ToShortTimeString()}";

            writer.DirectContent.BeginText();
            writer.DirectContent.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);
            writer.DirectContent.SetTextMatrix(document.LeftMargin,
                document.BottomMargin * 0.75f);
            writer.DirectContent.ShowText(textoDataGeracao);
            writer.DirectContent.EndText();
        }

        private void AdicionarNumeroPaginaAtual(PdfWriter writer, Document document)
        {
            int paginaAtual = writer.PageNumber;
            String textoPaginaAtual = "Página " + paginaAtual.ToString() + " de " + totalPaginas.ToString();

            //se for margem esquerda, é preciso calcular a largura do texto pra deixar 
            //esse espaço antes de preencher o template do total de páginas
            float larguraTextoPaginaAtual =
                //fonteRodape.BaseFont.GetWidthPoint(textoPaginaAtual + totalPaginas.ToString(), fonteRodape.Size);
                fonteRodape.BaseFont.GetWidthPoint(textoPaginaAtual, fonteRodape.Size);

            //float larguraTextoPaginaFinal =
            //    fonteRodape.BaseFont.GetWidthPoint(totalPaginas.ToString(), fonteRodape.Size);

            iTextSharp.text.Rectangle tamanhoPagina = document.PageSize;

            //altera a cor do texto a ser escrito
            //cb.SetRgbColorFill(100, 100, 100);

            writer.DirectContent.BeginText();
            writer.DirectContent.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);
            writer.DirectContent.SetTextMatrix(tamanhoPagina.Width -
                (document.RightMargin + larguraTextoPaginaAtual),
                document.BottomMargin * 0.75f);
            writer.DirectContent.ShowText(textoPaginaAtual);
            writer.DirectContent.EndText();

            //cb.AddTemplate(template, tamanhoPagina.Width -
            //    (document.RightMargin + larguraTextoPaginaFinal),
            //    document.BottomMargin * 0.75f);
        }
    }
}
