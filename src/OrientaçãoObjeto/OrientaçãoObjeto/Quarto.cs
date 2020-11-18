using System;
using System.Collections.Generic;
using System.Text;

namespace OrientaçãoObjeto
{
    class Quarto:Espaço
    {
      
        
        public int tamanhoquardado;

        public Quarto(int larguraQuarto, int comprimentoQuarto) : base (larguraQuarto,comprimentoQuarto)
        {
          
        }

        public int Quartoquadrodo()
        {
            return tamanhoquardado;
        }
    }
}
