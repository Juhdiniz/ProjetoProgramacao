using System;

namespace OrientaçãoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Quarto a1= new Quarto(100,50);

            Quarto a2 = new Quarto(2,50);

            Espaço c1 = new Espaço(2, 50);
            Banheiro K1 = new Banheiro(2, 50);

            Console.WriteLine(K1.Espaçoquadrodo());

           

            


            

            
            

            
        }
    }
}
