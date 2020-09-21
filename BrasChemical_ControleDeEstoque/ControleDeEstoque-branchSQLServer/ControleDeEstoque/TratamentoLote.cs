using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeEstoque.DataSet1TableAdapters;
using System.Data;
using System.Windows.Forms;
using ControleDeEstoque.Repositorios;
using ControleDeEstoque.Model;

namespace ControleDeEstoque
{
    public static class TratamentoLote
    {
       
        public static string getProximoLote(PreProduto preProduto)
        {
            Lote lote = new Lote();
            lote.Sigla = preProduto.Sigla;

            if (!preProduto.UltimoAno.ToString().Equals(DateTime.Now.Year.ToString().Substring(2)))
            {
                lote.Ano = Convert.ToInt32(DateTime.Now.Year.ToString().Substring(2));
                lote.Numero = 1;

            }
            else
            {
                lote.Ano = preProduto.UltimoAno;
                lote.Numero = preProduto.UltimoLote + 1;
            }

            return lote.ToString();
        }

        public static string getProximoLote(int CodigoPreProduto)
        {
            PreProdutosRepositorio repositorio = new PreProdutosRepositorio();

            var preProduto = repositorio.Find(CodigoPreProduto);

            return getProximoLote(preProduto);
        }


        public static void IncrementarNumeroDeLote(int CodigoPreProduto)
        {
            PreProdutosRepositorio repositorio = new PreProdutosRepositorio();

            var preProduto = repositorio.Find(CodigoPreProduto);
            preProduto.UltimoLote++;

            repositorio.Update(preProduto);
            repositorio.Save();
        }
    }


}
