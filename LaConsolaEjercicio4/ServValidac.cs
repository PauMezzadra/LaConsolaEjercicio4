using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsolaEjercicio4
{
    static class ServValidac
    {
        public static string PedirStringNoVacio (string mensaje)
        {
            string valor = "";
            do
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine().ToUpper();
                if (valor == "")
                {
                    Console.WriteLine("No puede ser vacío");
                }
            } while (valor == "");
            
            return valor;
        }
    }
}
