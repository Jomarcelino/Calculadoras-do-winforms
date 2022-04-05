using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rihu.Classe
{
    class CalculadoraBasica
    {
        private decimal _num1;
        decimal _num2;
        decimal _resultado;

        public decimal Num1
        {
            get => _num1;
            set => _num1 = value;
        }
        public decimal Num2
        {
            get => _num2;
            set => _num2 = value;
        }
        public decimal Resultado
        {
            get => _resultado;
            set => _resultado = value;
        }

        public void somar()
        {
            _resultado = _num1 + _num2;
        }

        public void Menos()
        {
            _resultado = _num1 - _num2;
        }

        public void Multiplicar()
        {
            _resultado = _num1 * _num2;
        }

        public void Dividir()
        {
            _resultado = _num1 / _num2;
        }

        public void Potencia()
        {
            
        }
    }
}
