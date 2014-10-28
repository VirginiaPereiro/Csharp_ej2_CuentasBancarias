using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Cs_cuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaAhorro cuenA1= new CuentaAhorro("Juan Ruíz",22000.33,true,0.25);
            CuentaAhorro cuenA2 = new CuentaAhorro("María Martín", 20.33, false, 0.55);

            CuentaCorriente cuenCorr1= new CuentaCorriente("Silvia Moreno",1000.1,true,100);
            CuentaCorriente cuenCorr2 = new CuentaCorriente("Cristina Vaquero", 51000.1, false, 250);

            cuenA1.IngresarDinero(500);
            cuenA2.IngresarDinero(320);

            cuenA1.RetirarDinero(800);
            cuenA2.RetirarDinero(400);
            cuenCorr1.RetirarDinero(1500);
            cuenCorr2.RetirarDinero(200);

            cuenCorr1.Detalles();
            cuenA2.Detalles();

            Console.ReadLine();

        }
    }
}
