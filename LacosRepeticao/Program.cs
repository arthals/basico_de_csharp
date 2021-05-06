using System;

namespace LacosRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileRandom();
        }

        public static void WhileRandom() 
        {
            Random a = new Random();
            int i = 0;
            string d = "";

            do
            {
                i = a.Next(0, 11);

                d += "" + i;
            } while (i < 10);
        }

        public static void forBasico() 
        {
            string a = "";
            for (int i = 0; i < 10; i++)
            {
                a += i + " ";
            }
        }

        public static void forInfinito()
        {
            string a = "";
            for ( ; ; )
            {
                a += "1";
            }
        }
        public static void forCheioDeCoisa()
        {
            string a = "";
            int j = 0;
            int jDobroMenosUm = 0;

            for (a = "a", j = 15, jDobroMenosUm = (2*j)- 1;  jDobroMenosUm > j; j = a.Length < 10 ? --j: ++j , a+="a")
            {
                a += Environment.NewLine;
            }
        }

        //public static string umMonteDeLetra(string letra, int quantidade) 
        //{
        //    quantidade  = quantidade > 0 ? quantidade : 0;
        //    for (int i = 0; i < quantidade ; i++)
        //    {

        //    }
        //}
    }
}
