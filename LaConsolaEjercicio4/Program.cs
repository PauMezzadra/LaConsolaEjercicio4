using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsolaEjercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "";
            do
            {
                valor = ServValidac.PedirStringNoVacio("Ingrese cualquier frase, para finalizar ingrese ´FIN´");
                Console.WriteLine("Usted ingresó la frase: " + valor);

            } while (valor != "FIN");
        }
    }
}
