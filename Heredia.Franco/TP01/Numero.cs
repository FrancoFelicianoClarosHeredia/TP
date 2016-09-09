using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double num)
        {
            this.numero = num;
        }

        public Numero(string num)
        {
            
        }

        public double validarNumero(string numeroString)
        {
            double retorno=0;

            if (double.TryParse(numeroString, out retorno))
            {
                return retorno;
            }

            return retorno;
        }

        public double getNumero
        {
            get { return this.numero; }
        }

        private void setNumero(string numero)
        {
            set { this.numero=validarNumero(numero); }
        }


    }
}
