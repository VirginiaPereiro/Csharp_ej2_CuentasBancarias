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

            CuentaCorriente cc1 = crearCuentaConsola();//crear objeto cuenta corriente por consola
            var cc2= crearCuentaConsola();

            //polimorfismo
            Cuenta cp =new CuentaCorriente("Carlos",3200,true,300);

            //casting
            //queremos transformar cp que es cuenta a cpc que es cuenta corriente
            CuentaCorriente cpc = (CuentaCorriente) cp;
            
            //forma segura de hacer un cast, dará null si fracasa la transformación
            CuentaCorriente cpc2 = cp as CuentaCorriente;

            //Para poder acceder a los atributos hay que forzar la transformación
            Console.WriteLine(((CuentaCorriente)cp).Limite);

            //accede al detalle de cuenta corriente porque es virtual 
            //y va a sobreescribirlo al más específico, a la implementación más profunda
            cp.Detalles();

            //creamos un array de cuentas y lo manejamos al antojo recorriéndolo luego
            var carr = new Cuenta[3];
            carr[0] = crearCuentaConsola();
            carr[1] = crearCuentaConsola();
            carr[2] = new CuentaAhorro("Juan Ruíz", 22000.33, true, 0.25);

            //recorremos el array
            foreach (var cuenta in carr)
            {
                cuenta.Detalles();
                if (cuenta is CuentaAhorro)
                {
                    Console.WriteLine("Soy de ahorro");
                }
            }

            cuenA1.IngresarDinero(500);
            cuenA2.IngresarDinero(320);

            cuenA1.RetirarDinero(800);
            cuenA2.RetirarDinero(400);
            cuenCorr1.RetirarDinero(1500);
            cuenCorr2.RetirarDinero(200);

            cuenCorr1.Detalles();
            cuenA2.Detalles();
            cc2.Detalles();

            Console.ReadLine();

        }

        private static CuentaCorriente crearCuentaConsola()
            //es un método estático por el main y privada para que no pueda ser llamada desde el exterior
            //método para crear una cuenta corriente e ir metiendo por consola los valores para formar la cuenta corriente
        {
            Console.Write("Titular");
            var t = Console.ReadLine();

            Console.Write("Saldo");
            var s = 0.0;
            double.TryParse(Console.ReadLine(), out s);

            Console.Write("Crédito");
            var credito = false;
            bool.TryParse(Console.ReadLine(), out credito);

            Console.Write("Límite");
            var limite = 0.0;
            double.TryParse(Console.ReadLine(), out limite);

            return new CuentaCorriente(t, s, credito, limite);
        }
    }
}
