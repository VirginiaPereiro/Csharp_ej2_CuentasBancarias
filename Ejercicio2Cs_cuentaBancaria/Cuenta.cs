using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Cs_cuentaBancaria
{
    public abstract class Cuenta
    {
        public String Titular { get; set; }

        public double Saldo { get; set; }

        protected Cuenta()
        {
            
        }

        protected Cuenta(String titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        //método ingresar dinero
        public double IngresarDinero(double ingreso)
        {
            Saldo += ingreso;
            Console.WriteLine("El titular: " + Titular + " ha hecho un ingreso de: "+ ingreso +" y su saldo ahora es de: "+ Saldo);
            return Saldo;
        }

        //método retirar dinero
        public virtual double RetirarDinero(double retirada)
        {
            Saldo -= retirada;
            return Saldo;
        }

        //método detalles
        public virtual void Detalles()
        {
            Console.WriteLine("El saldo es de : " + Saldo);
        }
    }
}
