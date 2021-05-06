using System;

namespace _3___TipoAnulavel
{
    class Program
    {
        static void Main(string[] args)
        {
            int? variavelAnulavel = null;
            variavelAnulavel = 1;

            int variavelComum = 1;

            string? ai = "asd";
            ai = null;
            ai.ToLower();
            //variavelComum = variavelAnulavel;
        }
    }
}
