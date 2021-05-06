using System;

namespace _9___Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unidimensional
            int[] MatrizUnidimensionalDefinidoTamanho = new int[5];
            int[] MatrizUnidimensionalDefinidoValores = new int[] { 1, 3, 5, 7, 9 };
            int[] MatrizUnidimensionalDefinidoTudo = new int[5] { 1, 3, 5, 7, 9 };
            int[] MatrizUnidimensionalResumoDefinidoValores = { 1, 3, 5, 7, 9 };

            string a = "";

            //foreach (int item in MatrizUnidimensionalResumoDefinidoValores)
            //{
            //    a += "" +item;
            //}

            //for (int i = 0; i < MatrizUnidimensionalResumoDefinidoValores.Length; i++)
            //{
            //    a += "" + MatrizUnidimensionalResumoDefinidoValores[i];
            //}

            string[] MatrizUnidimensionalDefinidaa = { "as", "de", "po" };

            int pegandoValorDeMatrizSoDefinidoTamanho = MatrizUnidimensionalDefinidoTamanho[0];
            MatrizUnidimensionalDefinidoTamanho[0] = 3;
            int pegandoValorDeMatrizSoDefinidoValores = MatrizUnidimensionalDefinidoValores[2];
            int tamanhoDaMatriz = MatrizUnidimensionalDefinidoTamanho.Length;
            //int pegandoValorForaDaMatriz = MatrizUnidimensionalDefinidoValores[5];

            //Multidimensional
            int[,] MatrizMultidimensionalDefinidoTamanho = new int[3, 2];
            int[,] MatrizMultidimensionalDefinidoValores = new int[,] { { 2, 4 }, 
                                                                        { 1, 3 }, 
                                                                        { 0, 2 } };
            int[,] MatrizMultidimensionalDefinidoTudo = new int[3, 2] { { 2, 4 }, { 1, 3 }, { 0, 8 } };
            int[,] MatrizMultidimensionalResumoDefinidoValores = { { 2, 4 }, { 1, 3 }, { 0, 8 } };

            pegandoValorDeMatrizSoDefinidoTamanho = MatrizMultidimensionalDefinidoTamanho[0, 1];
            MatrizMultidimensionalDefinidoTamanho[0, 1] = 3;
            pegandoValorDeMatrizSoDefinidoValores = MatrizMultidimensionalDefinidoValores[2,1];
            tamanhoDaMatriz = MatrizUnidimensionalDefinidoTamanho.Length;
            int alturaDaMatriz = MatrizUnidimensionalDefinidoTamanho.Rank;

            foreach (int item in MatrizMultidimensionalDefinidoValores)
            {
                a += "" + item;
            }

            //Denteadas 
            int[][] MatrizDenteadaDefinidoTamanho = new int[3][];
            int[][] MatrizDenteadaDefinidoValores = new int[3][] { 
                                                                   new int[] { 2, 4, 1, 3, 4, 12, 44 }, 
                                                                   new int[] { 1, 3, 12, 42, 11 }, 
                                                                   new int[] { 0, 2, 11, 9, 13 }, 
                                                                 };
            int[][] MatrizDenteadaIndefinidoTamanho = new int[][] {
                                                                   new int[] { 2, 4 },
                                                                   new int[] { 1, 3 },
                                                                   new int[] { 1, 3 },
                                                                   new int[] { 1, 3 },
                                                                   new int[] { 1, 3 },
                                                                   new int[] { 1, 3 },
                                                                   new int[] { 1, 3 },
                                                                   new int[] { 1, 3 },
                                                                   new int[] { 0, 2 },
                                                                 };

            int[][] MatrizDenteadaResumoDefinidoValores = {
                                                            new int[] { 2, 4, 2 },
                                                            new int[] { 1, 3, 4, 2, 1, 12, 94 },
                                                            new int[] { 0 },
                                                          };


            foreach (int[] item in MatrizDenteadaResumoDefinidoValores)
            {
                foreach (int itemInterno in item)
                {
                    a += "" + itemInterno;
                }
            }

            pegandoValorDeMatrizSoDefinidoTamanho = MatrizDenteadaDefinidoValores[0][1];
            MatrizDenteadaDefinidoTamanho[0] = new int[] { 1 };
            MatrizDenteadaDefinidoTamanho[0][0] = 2;
            pegandoValorDeMatrizSoDefinidoValores = MatrizDenteadaDefinidoValores[2][1];
            tamanhoDaMatriz = MatrizDenteadaIndefinidoTamanho.Length;
            int tamanhoDaMatrizSegundaria = MatrizDenteadaIndefinidoTamanho[0].Length;
        }
    }
}
