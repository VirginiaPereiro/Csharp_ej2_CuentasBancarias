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
            base.Detalles();
            Console.WriteLine("Tarjeta de credito: {0} Límite: {1}",
                TCredito,Limite);
        }

        public override double RetirarDinero(double retirada)
        {
            if (Saldo>retirada)
            {
                Saldo -= retirada;
                Console.WriteLine("El titular: " + Titular + " ha retirado " + retirada + "y su saldo actual es de " + Saldo);
            }
            else if (TCredito&&(Limite>Saldo-retirada))
            {
                Saldo -= retirada;
                //para hacer operación denegada habrá que lanzar una excepción 
                //Console.WriteLine("Operación denegada " + Titular + " su saldo "+ Saldo + " es menor de lo que va a retirar que es de " + retirada);
            }

            return Saldo;
        }

       
    }
}
