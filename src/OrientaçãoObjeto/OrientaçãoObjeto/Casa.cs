﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrientaçãoObjeto
{
    class Casa
    {
        public int tamanho;
        public static double alicota = 0.03;
        public static double iptutotal = 0;
        
        public  double Iptu;
        public double dobraCasa;
        Quarto a2; 
        
        public Casa(int tamanhoCasa)
        {
            tamanho = tamanhoCasa;
            Iptu = tamanho * 1000 * alicota;
            iptutotal = Iptu + iptutotal;

             a2 = new Quarto(2, 50);

        }

        public static double pagaIptu()
        {

            
            return iptutotal;
            
            
           
            
        }

        public double dobrarcasa()
        {
            dobraCasa = tamanho * 2;

            return dobraCasa;
        }


    }
}
