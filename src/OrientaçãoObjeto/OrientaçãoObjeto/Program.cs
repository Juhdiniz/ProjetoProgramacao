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

            Veiculo v1 = new Veiculo(3, "Roda");
            Bicicleta b1 = new Bicicleta(20,"Roda","amarelo");
            Veiculo_Automor aa1 = new Veiculo_Automor(20,"Roda","motor");
            Carro c3 = new Carro(20, "Roda","motor","Arcondicionado");
            Caminhão c4 = new Caminhão(20,"Roda","motor",20);

            Console.WriteLine(K1.Espaçoquadrodo());

           

            


            

            
            

            
        }
    }
}
