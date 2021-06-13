using System;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        public delegate string Mostrar(string cadena);
        static async Task Main(string[] args)
        {
            Mostrar mostrar = Show;
            HacerAlgo(mostrar);
        }

        public static string Show(string cad)
        {
            return cad.ToUpper();
        }

        public static void HacerAlgo(Mostrar funcionfinal)
        {
            Console.WriteLine("Hago Algo");
            Console.WriteLine(funcionfinal("Se envio desde otra funcion"));
            Console.WriteLine("Hago algo mas");

        }
    }
}
