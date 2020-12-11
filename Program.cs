using System;
using AulaPOO_PolimosrfismoSobrecarga.classes;

namespace AulaPOO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("Tsuka");
            fun.Mostrar(3);

            Console.Beep();

            
        }
    }
}
