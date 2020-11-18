using System;
using System.Collections.Generic;
using System.Text;

namespace OrientaçãoObjeto
{
    class Caminhão: Veiculo_Automor
    {
        int quantidadecarga;

        public Caminhão(int valor, string Roda, string motor, int quantidadecarga) : base(valor, Roda, motor)
        {
            this.quantidadecarga = quantidadecarga;
        }
    }
}
