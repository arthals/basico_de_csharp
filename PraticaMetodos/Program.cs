using System;

namespace PraticaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = RetornaTextoPadraoCasoNulo();
        }

        public static string PassagemDeOParametros(params string[] partesTexto)
        {
            string texto = "";
            foreach (var item in partesTexto)
            {
                texto += item;
            }

            return texto;
        }

        public static string RetornaTextoPadraoCasoNulo(string texto = "oooooo")
        {
            if (texto == null)
                return "padrao";
            else
                return texto;
        }

        public static string PassagemDeIn(in ObjetoNovo objeto)
        {
            objeto.Valor = "Novo";

            return objeto.Valor;
        }

        public static int RetornaDoisValores(out int numerico)
        {
            numerico = 1;
            return 2;
        }

        public static void NaoTemRetorno(int numerico)
        {
            numerico = 3;
        }

        public static int RetornoSomaInteiro(int numerico, int numerico2)
        {
            return numerico + numerico2;
        }

        public static string RetornoString()
        {
            return "qualquer coisa";
        }

        public static int CapturaTamanhoDoDadoPosAdicaoNoTexto(ref string texto)
        {
            texto += "Adicionado";
            return texto.Length;
        }




        public static int CapturaTamanhoDoDadoPosAdicaoNoTextoSentadoTextoAMais(ref string texto, out string textoVazio)
        {
            texto += "Adicionado";
            textoVazio = "AlgumaCoisa";
            return texto.Length;
        }
    }

    class ObjetoNovo
    {
        public string Valor { get; set; }
    }
}