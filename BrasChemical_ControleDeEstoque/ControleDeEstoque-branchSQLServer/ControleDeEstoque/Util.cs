using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeEstoque
{
    public class Util
    {
        public static bool VerificarNumerico(char letra)
        {
            bool handled;

            if (Char.IsNumber(letra) || Char.IsControl(letra))
            {
                handled = false;
            }
            else
            {
                handled = true;
            }

            return handled;
        }



    }
}
