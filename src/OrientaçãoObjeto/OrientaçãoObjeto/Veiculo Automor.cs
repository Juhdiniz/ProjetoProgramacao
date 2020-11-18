using System;
using System.Collections.Generic;
using System.Text;

namespace OrientaçãoObjeto
{
    class Veiculo_Automor : Veiculo

    {
        string motor;

        public Veiculo_Automor(int valor, string Roda, string motor) : base(valor,Roda)
        {
            this.motor = motor;
        }
    }

}
