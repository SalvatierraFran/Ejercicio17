using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            Cuenta Cuenta1 = new Cuenta("Franco", 123456, 577.50, Enumerados.ETipoInteres.TIN);

            Console.Write("Nombre: " + Cuenta1.getNombre());
            Console.Write("\nNumero de cuenta: " + Cuenta1.getNroCuenta());
            Console.Write("\nSaldo: " + Cuenta1.getSaldo());
            Console.Write("\nTipo de interes: " + Cuenta1.getTipoInteres());

            Console.ReadKey();
        }
    }
}
