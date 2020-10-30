using System;
using System.Collections.Generic;
using System.Text;

namespace OrientaçãoObjeto
{
    class Casa
    {
        public  int tamanho;
        public static double alicota = 0.03;
        
        public double Iptu;
        public double dobraCasa;
        
        public Casa(int tamanhoCasa)
        {
            tamanho = tamanhoCasa;
            

        }

        public  double pagaIptu()
        {

           Iptu = tamanho * 1000 * alicota;
            return Iptu;
            
        }

        public double dobrarcasa()
        {
            dobraCasa = tamanho * 2;

            return dobraCasa;
        }


    }
}
