using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP1
{
    class Numero
    {
        double num;

        public string SetNumero
        {
            set
            {
                this.num = validarNumero(value);
            }
        }
        
        public Numero()
        {
            num = 0;
        }
        public Numero(string str)
        {
            this.SetNumero = str;
        }
        public Numero(double dbl)
        {
            num = dbl;
        }        

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.num - n2.num;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.num * n2.num;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.num != 0)
                return n1.num / n2.num;
            else
                return 0;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.num + n2.num;
        }

        double validarNumero(string str)
        {
            double aux;
            double ret;
            if (double.TryParse(str, out aux))
                ret = aux;
            else
                ret = 0;
            return ret;
        }

        public static string BinarioDecimal(string binario)
        {
            double numero = 0;
            int b;
            for (int i = binario.Length - 1; i >= 0; i--)
            {
                if (int.TryParse(binario[binario.Length - i - 1].ToString(), out b))
                {
                    numero += b * Math.Pow(2, i);
                }
                else
                {
                    return "Valor inválido";
                }
            }
            return numero.ToString();
        }

        public static string DecimalBinario(double numero)
        {
            string binario = "";
            do
            {
                if ((numero % 2) == 0)
                    binario = "0" + binario;
                else
                    binario = "1" + binario;
                numero = (int)(numero / 2);
            } while (numero > 0);
            return binario;
        }

        public static string DecimalBinario(string numero)
        {
            if (Regex.IsMatch(numero, @"^-*[0-9,\.]+$"))
            {
                return DecimalBinario(double.Parse(numero));
            }
            else
                return "Valor inválido";
        }
    }
}
