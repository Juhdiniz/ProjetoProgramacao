using System;

namespace OrientaçãoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Casa e = new Casa(2000);

            Console.WriteLine(e.pagaIptu());

            Casa e1 = new Casa(1000);
            Console.WriteLine(e.pagaIptu());
        }
    }
}
