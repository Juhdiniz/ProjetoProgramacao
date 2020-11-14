using System;
using System.Collections.Generic;
using System.Text;

namespace OrientaçãoObjeto
{
    class Espaço
    {
        
        public int tamanhoespaço;
        public Espaço(int largura, int comprimento)
        {
            tamanhoespaço = largura * comprimento;
        }

        public int Espaçoquadrodo()
        {
            return tamanhoespaço;
        }

    }
}
