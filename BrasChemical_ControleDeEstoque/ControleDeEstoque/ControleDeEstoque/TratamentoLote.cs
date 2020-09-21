using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeEstoque.DataSet1TableAdapters;
using System.Data;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public static class TratamentoLote
    {
        //public static void Atualizar()
        //{
        //    LoteAtualTableAdapter taLoteAtual = new LoteAtualTableAdapter();

        //    taLoteAtual.UpdateNumero();
        //}

        //public static string getLote()
        //{

        //    int ano = getAno();
        //    int numero = getNumero();

        //    return numero.ToString("0000") + @"/" + ano;
        //}

        //public static string getProximoLote()
        //{

        //    int ano = getAno();
        //    int numero = getNumero() + 1;

        //    return numero.ToString("0000") + @"/" + ano;
        //}



        //private static int getAno()
        //{
        //    LoteAtualTableAdapter taLoteAtual = new LoteAtualTableAdapter();

        //    int ano = taLoteAtual.GetData()[0].Ano;

        //    if (!ano.ToString().Equals(DateTime.Now.Year.ToString().Substring(2)))
        //    {
        //        AtualizarAno();
        //        ano = getAno();
        //    }

        //    return ano;
        //}

        //private static void AtualizarAno()
        //{
        //    LoteAtualTableAdapter taLoteAtual = new LoteAtualTableAdapter();

        //    taLoteAtual.UpdateAno(Convert.ToInt32(DateTime.Now.Year.ToString().Substring(2)));
        //}

        //private static int getNumero()
        //{
        //    LoteAtualTableAdapter taLoteAtual = new LoteAtualTableAdapter();

        //    int numero = taLoteAtual.GetData()[0].Numero;

        //    return numero;
        //}



        public static string getProximoLote(int CodigoPreProduto)
        {
            PreProdutosTableAdapter taPreProdutos = new PreProdutosTableAdapter();
            taPreProdutos.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

            DataSet1.PreProdutosRow preProduto = taPreProdutos.SelecionarPreProduto(CodigoPreProduto)[0];
           
            Lote lote = new Lote();
            lote.Sigla = preProduto.Sigla;


            if (!preProduto.UltimoAno.ToString().Equals(DateTime.Now.Year.ToString().Substring(2)))
            {
                lote.Ano = Convert.ToInt32(DateTime.Now.Year.ToString().Substring(2));
                lote.Numero = 1;

                taPreProdutos.AtualizarAno(lote.Ano, CodigoPreProduto);
            }
            else
            {
                lote.Ano = preProduto.UltimoAno;
                lote.Numero = preProduto.UltimoLote + 1;
            }
           


            return lote.ToString();
        }


        public static void IncrementarNumeroDeLote(int CodigoPreProduto)
        {
            PreProdutosTableAdapter taPreProdutos = new PreProdutosTableAdapter();
            taPreProdutos.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

            taPreProdutos.IncrementarNumeroLote(CodigoPreProduto);
        }
    }

    public class Lote
    {
        public string Sigla { get; set; }
        public int Ano { get; set; }
        public int Numero { get; set; }

        public Lote()
        {
            Sigla = string.Empty;
            Ano = 0;
            Numero = 0;
        }

        public override string ToString()
        {
            return Sigla + @"/" + Ano.ToString("00") + "-" + Numero.ToString("000");
        }
    }
}
