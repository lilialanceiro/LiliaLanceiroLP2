using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    class Empregado: Funcionario
    {
        public double Salario { get; set; }
 
        virtual public double ValeAlimentacao
        {
            get
            {
                if (Salario * (8 / 100) > 750)
                {
                    return 750;
                }
                else
                {
                    return Salario * (8 / 100);
                }
            }

            set { }
        }

    }
}
