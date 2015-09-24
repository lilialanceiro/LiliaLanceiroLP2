using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1509_2_
{
    class Empregado: Funcionario
    {
        public double Salario { get; set; }
        abstract public double _valeAlimentacao;


        public double ValeAlimentacao()
        {
            _valeAlimentacao = Salario * (8 / 100);
            if (_valeAlimentacao > 750)
            {
                return 750;
            }
            else { return _valeAlimentacao; }
        }
    }
}
