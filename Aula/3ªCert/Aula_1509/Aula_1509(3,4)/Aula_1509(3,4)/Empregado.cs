using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1509_3_4_
{
    class Empregado: Funcionario
    {
        public double Salario { get; set; }

        public double ValeAlimentacao
        {
            get
            {
                if (Salario * (8/100) > 750)
            {
                return 750;
            }
            else
            { 
               return Salario * (8/100); 
            }
            }

            set{ }
        }


        }
    }
