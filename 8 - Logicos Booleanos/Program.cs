using System;

namespace _8___Logicos_Booleanos
{
    class Program
    {
        static void Main(string[] args)
		{
			bool e = true && true;
			e &= false;

			int inteiro = 0;
			e = false & (inteiro = 1) == 1;

			bool ou = true || true;
			ou |= false;

			ou = true | (inteiro = 2) == 2;

			bool negacao = !true;

			bool exclusivo = true ^ true;
			exclusivo ^= true;

        }
    }
}
