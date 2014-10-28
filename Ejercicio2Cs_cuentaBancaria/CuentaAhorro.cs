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

        public CuentaAhorro(String titular, double saldo, bool retirar=true, double comision=500)
        :base(titular,saldo)
        {
            Retirar = retirar;
            Comision = comision;
        }

        public override void Detalles()
        {
            base.Detalles();
            Console.WriteLine("Permite sacar dinero: {0} Comision: {1:p}",
                 Retirar ? "Sí":"No", Comision);
        }

        public override double RetirarDinero(double retirada)
        {
            if (Retirar)
            {
                Saldo -= retirada + retirada * Comision;
                Console.WriteLine("El titular: "+ Titular + " ha retirado "+ retirada + "y su saldo actual es de "+ Saldo);
            }

            return Saldo;
        }
    }
}
