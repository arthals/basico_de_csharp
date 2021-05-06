using System;

namespace _9___Enumerador
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = (int)Dia.Domingo;
            Dia dia = Dia.Sabado;
            Dia diaa = (Dia)1;

        }

        enum Dia 
        { 
            Segunda ,
            Terceiro,
            Quarto,
            Quinto,
            Sexto,
            Sabado,
            Domingo,
        }
    }
}
