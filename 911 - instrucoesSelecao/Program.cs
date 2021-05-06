using System;

namespace _911___instrucoesSelecao
{
    class Program
    {
        static void Main(string[] args)
        {
           var a = StringGaranteValora(null);
        }

        public static string StringGaranteValora(ObjetoNovo objeto)
        {
            return objeto?.Valor?.ToString()?.ToString()?.ToString()?.ToString();
        }

        public static string StringGaranteValor(string valor)
        {
            return valor ?? "tava nulo";
        }

        public static string OperadorTernario(bool valor, bool valor2, bool valor3)
        {
            return valor ? valor2 ? "Deu boa" : "deu meio" : 
                           valor3 ? "Deu ruim" : "deu muito ruim";
        }

        public static string ifSemChaves(bool valor) 
        {
            if (valor == true)
                return "entrou";
            return "não entrou";
        }

        public static string ifComChaves(bool valor)
        {
            if (valor)
            {
                return "entrou";
            }

            return "não entrou";
        }
        public static string ifElse(bool valor)
        {
            if (valor)
            {
                return "entrou if";
            }
            else
            {
                return "entrou else";
            }
        }

        public static string diaPorExtenso(Dia dia) 
        {
            switch (dia)
            {
                case Dia.Segunda:
                    return "Segunda";
                case Dia.Terceiro:
                    return "Terceiro";
                case Dia.Quarto:
                    return "Quarto";
                case Dia.Quinto:
                    return "Quinto";
                case Dia.Sexto:
                    return "Sexto";
                case Dia.Sabado:
                    return "Sabado";
                case Dia.Domingo:
                    return "Domingo";
                default:
                    return "nenhum"; 
            }
        }

        public static void diaPorExtensoSemRetorno(Dia dia)
        {
            string diaTexto = "";

            switch (diaTexto.ToUpper())
            {
                case "SS":
                    break;
                case "SSW":
                    break;
                case "SSD":
                    break;
                case "SSL":
                    break;
                default:
                    diaTexto = "nenhum";
                    break;
            }
        }



    }

    class ObjetoNovo
    {
        public string Valor { get; set; }
    }

    enum Dia
    {
        Segunda = 2,
        Terceiro,
        Quarto,
        Quinto,
        Sexto,
        Sabado,
        Domingo,
    }
}
