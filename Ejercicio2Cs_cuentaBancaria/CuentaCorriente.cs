using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Cs_cuentaBancaria
{
    public class CuentaCorriente:Cuenta
    {
        public bool TCredito { get; set; }
        public double Limite { get; set; }

        public CuentaCorriente(String titular, double saldo, bool tCredito, double limite)
        :base(titular,saldo)
        {
            TCredito = tCredito;
            Limite = limite;
        }

        public override void Detalles()
        {
            Console.WriteLine("Titular: {0} Saldo: {1} Tarjeta de credito: {2} Límite: {3}",
                Titular,Saldo,TCredito,Limite);
        }

        public override double RetirarDinero(double retirada)
        {
            if (Saldo>retirada)
            {
                Saldo -= retirada;
                Console.WriteLine("El titular: " + Titular + " ha retirado " + retirada + "y su saldo actual es de " + Saldo);
            }
            else
            {
                Console.WriteLine("Operación denegada " + Titular + " su saldo "+ Saldo + " es menor de lo que va a retirar que es de " + retirada);
            }

            return Saldo;
        }
    }
}
