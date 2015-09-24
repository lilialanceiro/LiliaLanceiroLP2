using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1509_2_
{
    class Gerente: Empregado
    {
        public string Area { get; set; }
        public double ValorAd { get; set; }
        

        public double SalarioTotal()
        {
            return Salario + ValorAd;
        }

        public override double ValeAlimentacao()
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
