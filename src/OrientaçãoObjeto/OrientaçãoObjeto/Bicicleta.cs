using System;
using System.Collections.Generic;
using System.Text;

namespace OrientaçãoObjeto
{
    class Bicicleta: Veiculo

    {
        string cor;

        public Bicicleta( int valor, string cor, string Roda) : base (valor, Roda)
        {
            this.cor = cor;
        }
    }
}
