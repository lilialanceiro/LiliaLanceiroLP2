using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    class Gerente: Empregado
    {
        public string Area { get; set; }
        public double ValorAd { get; set; }
        private double _salarioTotal;


        public double SalarioTotal
        {
            get
            {
                _salarioTotal = Salario + ValorAd;
                return _salarioTotal;
            }
        }

         public override double ValeAlimentacao
        {
            get
            {
                if (SalarioTotal * ((13 / 2) / 100) > 750)
                {
                    return 750;
                }
                else
                {
                    return SalarioTotal * ((13 / 2) / 100);
                }
            }
            set { }
        }
    }
}
