using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor = 0;
            int meio = 1;
            int maior = 2;

            bool IgualVerdadeiro = menor == menor;
            bool IgualFalso = menor == maior;

            bool DiferenteVerdadeiro = menor != maior;
            bool DiferenteFalso = meio != meio;

            bool IgualMaiorIgualVerdadeiro = meio >= meio;
            bool IgualMaiorFalso = meio >= maior;
            bool IgualMaiorDiferenteVerdadeiro = maior >= meio;

            bool MaiorlVerdadeiro = maior > menor;
            bool MaiorlFalso = menor > maior;

            bool IgualMenorIgualVerdadeiro = meio <= meio;
            bool IgualMenorFalso = maior <= menor;
            bool IgualMenorDiferenteVerdadeiro = menor <= meio;

            bool MenorVerdadeiro = menor < maior;
            bool MenorFalso = maior < menor;

        }
    }
}
