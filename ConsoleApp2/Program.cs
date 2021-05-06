using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoOriginal = "Original";
            int inteiroOriginal = 1;
            double fluanteOriginal = 1.0f;

            PassagemDeValor(textoOriginal, inteiroOriginal, fluanteOriginal);


            ObjetoNovo objetoOriginal = new ObjetoNovo();
            objetoOriginal.Valor = "Original";

            PassagemDeReferencia(objetoOriginal);
        }

        public static void PassagemDeReferencia(ObjetoNovo objeto)
        {
            objeto.Valor = "Novo";
        }

        public static void PassagemDeValor(string text, int inteiro, double flutuante)
        {
            text = "Novo";
            inteiro = 2;
            flutuante = 2.0f;
        }
    }


    class ObjetoNovo
    {
        public string Valor{ get; set; }
    }
}
