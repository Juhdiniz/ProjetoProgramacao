using System;
using System.Collections.Generic;
using System.Text;

namespace OrientaçãoObjeto
{
    class Carro: Veiculo_Automor
    {
        string arcondicionado;

        public Carro(int valor, string Roda, string motor, string arcondicionado) : base(valor, Roda,motor)
        {

            this.arcondicionado = arcondicionado;
        }

       
        
    }
}
