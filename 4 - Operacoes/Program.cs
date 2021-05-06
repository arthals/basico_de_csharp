using System;

namespace _4___Operacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passagem de valor
            int VariavelApenasDePassagem = 2;

            //Casting, conversões
            //Implicitas
            int valorInteiro = int.MaxValue;
            long valorLongCast = valorInteiro;

            //explicitas
            long valorLong = 1;
            int valorIntCast = (int)valorLong;

            //Convert
            int valorIntConvert = Convert.ToInt32(valorLong);

            //Somas
            int ValorOriginalDaSoma = 1 + 1;
	        ValorOriginalDaSoma += 1;
            ValorOriginalDaSoma = ValorOriginalDaSoma + 1;
            int valorRecebendoPreSoma = ValorOriginalDaSoma++;
	        int valorRecebendoPosSoma = ++ValorOriginalDaSoma;

            //Subtração
            int ValorOriginalDaSub = 1 - 1;
            ValorOriginalDaSub -= 1;
            int valorRecebendoPreSub = ValorOriginalDaSub--;
            int valorRecebendoPosSub = --ValorOriginalDaSub;

            //Multiplicação
            int ValorOriginalDaMult = 1 * 3;
            ValorOriginalDaMult *= 2;

            //Divisão
            int ValorOriginalDaDiv = 4 / 2;
            ValorOriginalDaDiv /= 2;

            //Resto
            int ValorOriginalDaResto = 11 % 3;
            ValorOriginalDaResto %= 2;
        }
    }
}
