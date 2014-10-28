using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Cs_cuentaBancaria
{
    public class CuentaAhorro:Cuenta
    {
        public bool Retirar { get; set; }
        public double Comision { get; set; }

        public CuentaAhorro(String titular, double saldo, bool retirar, double comision)
        :base(titular,saldo)
        {
            Retirar = retirar;
            Comision = comision;
        }

        public override void Detalles()
        {
            Console.WriteLine("Titular: {0} Saldo: {1} Tarjeta de credito: {2} Límite: {3}",
                Titular, Saldo, Retirar, Comision);
        }

        public override double RetirarDinero(double retirada)
        {
            if (Retirar)
            {
                Saldo -= retirada;
                Console.WriteLine("El titular: "+ Titular + " ha retirado "+ retirada + "y su saldo actual es de "+ Saldo);
            }
            else
            {
                Console.WriteLine("Operación denegada " + Titular + " su saldo " + Saldo + " es menor de lo que va a retirar que es de " + retirada);
            }

            return Saldo;
        }
    }
}
