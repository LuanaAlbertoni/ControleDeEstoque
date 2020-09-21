using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Helpers
{
    public class Helper
    {
        public static String GetFirstLote()
        {
            return String.Concat("BC", DateTime.Now.Year.ToString().Substring(2,2), "-0001") ;
        }
        public static String GetNextLote(string lote)
        {
            int year = 2000 + Convert.ToInt32(lote.Substring(2,2));
            int counter = Convert.ToInt32(lote.Split('-')[1]);

            if (year == DateTime.Now.Year)
            {
                counter += 1;
            }
            else
            {
                year = DateTime.Now.Year ;
                counter = 1;
            }

            return String.Concat("BC", year.ToString().Substring(2,2), '-', counter.ToString("0000")) ;
        }
    }
}