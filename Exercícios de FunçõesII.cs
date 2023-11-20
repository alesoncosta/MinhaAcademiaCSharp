namespace Exercícios_de_Funções_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Na teoria dos Sistemas, define - se como elemento minimax de uma matriz, o menor elemento da linha em que se encontra o maior elemento da matriz.Escreva um programa que lê uma matriz[10 X 10] e em uma função encontre e mostre o elemento minimax e sua posição na matriz.

            {
                int[,] matriz = new int[10, 10];
                PreencherMatriz(matriz);
                EncontrarElementoMinimax(matriz);
            }

            static void PreencherMatriz(int[,] matriz)
            {
                Random random = new Random();

                for (int i = 0; i < matriz.GetLength(0); i++)
                    for (int j = 0; j < matriz.GetLength(1); j++)
                        matriz[i, j] = random.Next(1, 101);
            }

            static void EncontrarElementoMinimax(int[,] matriz)
            {
                int linhaMax = 0, colunaMax = 0;

                for (int i = 0; i < matriz.GetLength(0); i++)
                    for (int j = 0; j < matriz.GetLength(1); j++)
                        if (matriz[i, j] > matriz[linhaMax, colunaMax])
                        {
                            linhaMax = i;
                            colunaMax = j;
                        }

                int elementoMinimax = matriz[linhaMax, 0];
                for (int j = 1; j < matriz.GetLength(1); j++)
                    if (matriz[linhaMax, j] < elementoMinimax)
                        elementoMinimax = matriz[linhaMax, j];

                Console.WriteLine($"O elemento minimax é {elementoMinimax} na posição [{linhaMax}, {colunaMax}] da matriz.");
            }
        }
    }
}

        //2 - Escreva uma função chamada CalcularMedia que recebe um vetor de números, a informação se o usuário deseja escolher os pares ou os impares, e retorna a média dos valores conforme a escolha do usuário.

        
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Escolha a opção:");
            Console.WriteLine("1 - Média dos números pares");
            Console.WriteLine("2 - Média dos números ímpares");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Média dos números pares: " + CalcularMedia(numeros, true));
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Média dos números ímpares: " + CalcularMedia(numeros, false));
            }
            else
            {
        Console.WriteLine("Opção inválida.");
            }
         

        static double CalcularMedia(int[] numeros, bool considerarPares)
    {
        int soma = 0;
        int quantidade = 0;

        foreach (var numero in numeros)
        {
            if (considerarPares && numero % 2 == 0)
            {
                soma += numero;
                quantidade++;
            }
            else if (!considerarPares && numero % 2 != 0)
            {
                soma += numero;
                quantidade++;
            }
        }

        return quantidade > 0 ? (double)soma / quantidade : 0;


    //3 - Escreva uma função chamada TransporMatriz que recebe uma matriz como parâmetro e retorna a matriz transposta.

    {
        
        int[,] matrizOriginal = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrizTransposta = TransporMatriz(matrizOriginal);

        Console.WriteLine("Matriz Original:");
        ImprimirMatriz(matrizOriginal);

        Console.WriteLine("\nMatriz Transposta:");
        ImprimirMatriz(matrizTransposta);
    }

    static int[,] TransporMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        int[,] matrizTransposta = new int[colunas, linhas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matrizTransposta[j, i] = matriz[i, j];
            }
        }

        return matrizTransposta;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

//4 - Escreva uma função chamada MultiplicarMatrizes que recebe duas matrizes como parâmetros e retorna a matriz resultante da multiplicação.

{
    s
    int[,] matrizA = {
            {1, 2, 3},
            {4, 5, 6}
        };

    int[,] matrizB = {
            {7, 8},
            {9, 10},
            {11, 12}
        };

    int[,] resultado = MultiplicarMatrizes(matrizA, matrizB);

    Console.WriteLine("Matriz A:");
    ImprimirMatriz(matrizA);

    Console.WriteLine("\nMatriz B:");
    ImprimirMatriz(matrizB);

    Console.WriteLine("\nResultado da Multiplicação:");
    ImprimirMatriz(resultado);
}

static int[,] MultiplicarMatrizes(int[,] matrizA, int[,] matrizB)
{
    int linhasA = matrizA.GetLength(0);
    int colunasA = matrizA.GetLength(1);
    int linhasB = matrizB.GetLength(0);
    int colunasB = matrizB.GetLength(1);

    if (colunasA != linhasB)
    {
        throw new ArgumentException("Número de colunas da matrizA deve ser igual ao número de linhas da matrizB.");
    }

    int[,] resultado = new int[linhasA, colunasB];

    for (int i = 0; i < linhasA; i++)
    {
        for (int j = 0; j < colunasB; j++)
        {
            for (int k = 0; k < colunasA; k++)
            {
                resultado[i, j] += matrizA[i, k] * matrizB[k, j];
            }
        }
    }

    return resultado;
}

static void ImprimirMatriz(int[,] matriz)
{
    int linhas = matriz.GetLength(0);
    int colunas = matriz.GetLength(1);

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine();
    }
}
}

        //5 - Crie uma função chamada SomaDiagonalPrincipal que recebe uma matriz quadrada como parâmetro e retorna a soma dos elementos na diagonal principal.

        {
   
            int[,] matriz = {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                };

            int somaDiagonalPrincipal = SomaDiagonalPrincipal(matriz);

            Console.WriteLine("Matriz:");
            ImprimirMatriz(matriz);

            Console.WriteLine("\nSoma da Diagonal Principal: " + somaDiagonalPrincipal);
        }

        static int SomaDiagonalPrincipal(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);
            int soma = 0;

            for (int i = 0; i < tamanho; i++)
            {
                soma += matriz[i, i];
            }

            return soma;
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        }

        //6 - Escreva uma função chamada MediaColunaMatriz que recebe uma matriz e um número de coluna como parâmetros, e retorna a soma dos elementos nessa coluna.

        {
   
            int[,] matriz = {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                };

            int numeroColuna = 1;

            double mediaColuna = MediaColunaMatriz(matriz, numeroColuna);

            Console.WriteLine("Matriz:");
            ImprimirMatriz(matriz);

            Console.WriteLine($"\nMédia da Coluna {numeroColuna + 1}: {mediaColuna}");
        }

        static double MediaColunaMatriz(int[,] matriz, int numeroColuna)
        {
            int linhas = matriz.GetLength(0);
            int soma = 0;

            for (int i = 0; i < linhas; i++)
            {
                soma += matriz[i, numeroColuna];
            }

            return linhas > 0 ? (double)soma / linhas : 0;
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


//7 - Crie uma função chamada VerificarNumeroPrimo que recebe um vetor de números inteiros como parâmetro e retorna verdadeiro se pelo menos um número primo estiver presente no vetor, e falso caso contrário.

        {
  
            int[] numeros = { 4, 7, 12, 15, 23 };

            bool temPrimo = VerificarNumeroPrimo(numeros);

            Console.WriteLine("Vetor de números:");
            ImprimirVetor(numeros);

            Console.WriteLine("\nPelo menos um número primo está presente? " + temPrimo);
        }

        static bool VerificarNumeroPrimo(int[] vetor)
        {
            foreach (var numero in vetor)
            {
                if (EhPrimo(numero))
                {
                    return true;
                }
            }

            return false;
        }

        static bool EhPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void ImprimirVetor(int[] vetor)
        {
            foreach (var numero in vetor)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
               
    }
  }
}