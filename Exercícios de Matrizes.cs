namespace Exercícios_de_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Crie uma Matriz 5x3.Na primeira coluna, solicite que o usuário preencha.A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

            int[,] matriz = new int[5, 3];
            Random rng = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("Insira o valor " + i + ": ");
                matriz[i, 0] = int.Parse(Console.ReadLine());
                matriz[i, 0] = rng.Next(100);
                Console.Write(matriz[i, 0] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 1] = matriz[i, 0] + 10;
                Console.Write(matriz[i, 1] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i <= matriz.GetLength(0); i++)
            {
                matriz[i, 2] = matriz[i, 0] * 2;
                Console.Write(matriz[i, 2] + " ");
            }


            //2) Solicite ao usuário, preencher uma Matriz 3x3

            //Informe ao usuário:
            //*A soma dos elementos de cada linha

            //    -Ex: Linha 1: 30

            //         Linha 2: 17
            //* A soma dos elementos de cada coluna

            //    -Ex: Coluna 1: 23

            //         Coluna 2: 36

            int[,] matriz = new int[3, 3];
            Random rng = new Random();
            int[] somaLinha = new int[3];
            int[] somaColuna = new int[3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(10);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int somax = 0;
                int somay = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somax += matriz[i, j];
                    somay += matriz[j, i];
                }
                somaLinha[i] = somax;
                somaColuna[i] = somay;
            }

            Console.Write(String.Join(" | ", somaLinha));
            Console.WriteLine();
            Console.Write(String.Join(" | ", somaColuna));


            //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            int[,] matriz = new int[4, 4];
            Random rng = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(10);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                }
            }


            //4) Popule uma matriz 5x5 e informe:
            //            -Quantos números são pares
            //            - Quantos números são impares
            //            - Quantos números são positivos
            //            - Quantos números são negativos
            //            - Quantos zeros existem!

            int[,] matriz = new int[5, 5];
            Random rng = new Random();
            int par = 0, impar = 0, positivo = 0, negativo = 0, zero = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(-10, 10);
                    Console.Write(matriz[i, j] + " ");

                    if (matriz[i, j] % 2 == 0)
                    {
                        par++;
                    }
                    else
                    {
                        impar++;
                    }

                    if (matriz[i, j] > 0)
                    {
                        positivo++;
                    }
                    else
                    {
                        negativo++;
                    }

                    if (matriz[i, j] == 0)
                    {
                        zero++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("A matriz possui: ");

            Console.Write(par + " numeros pares\n");
            Console.Write(impar + " numeros impares\n");
            Console.Write(positivo + " numeros positivos\n");
            Console.Write(negativo + " numeros negativos\n");
            Console.Write(zero + " numeros zeros\n");


            //5) Leia duas matrizes 2x3 de números double.
            //Imprima a soma destas duas matrizes.

            int[,] matrizM = new int[2, 3];
            int[,] matrizN = new int[2, 3];
            int[,] soma = new int[2, 3];
            Random rng = new Random();

            for (int i = 0; i < matrizM.GetLength(0); i++)
            {
                for (int j = 0; j < matrizM.GetLength(1); j++)
                {
                    matrizM[i, j] = rng.Next(10);
                    Console.Write(matrizM[i, j] + " + ");
                    matrizN[i, j] = rng.Next(10);
                    Console.Write(matrizN[i, j] + " = ");
                    soma[i, j] = matrizM[i, j] + matrizN[i, j];
                    Console.Write(soma[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < matrizM.GetLength(0); i++)
            {
                for (int j = 0; j < matrizM.GetLength(1); j++)
                {
                    matrizM[i, j] = rng.Next(10);
                    Console.Write(matrizM[i, j] + " + ");
                    matrizN[i, j] = rng.Next(10);
                    Console.Write(matrizN[i, j] + " = ");
                    soma[i, j] = matrizM[i, j] + matrizN[i, j];
                    Console.Write(soma[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0 - 9.Após isso determine o maior número da matriz.
            //Random random = new Random();
            //            int randomNumber = random.Next(0, 100);

            int[,] matriz = new int[4, 4];
            Random rng = new Random();
            int maior = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(0, 9);
                    Console.Write(matriz[i, j] + " ");
                    if (maior < matriz[i, j])
                    {
                        maior = matriz[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("maior número é: " + maior);

            //7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

            int[,] a = new int[4, 4];
            int[,] b = new int[4, 4];
            Random rng = new Random();
            int[,] c = new int[4, 4];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rng.Next(10);
                    Console.Write(a[i, j] + " - ");
                    b[i, j] = rng.Next(10);
                    Console.Write(b[i, j] + " = ");
                    c[i, j] = a[i, j] - b[i, j];
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            int[,] matriz = new int[4, 4];
            Random rng = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(10);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();

                //9) Leia uma matriz 3x3.Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.
                //Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

                int[,] matriz = new int[3, 3];
                Random rng = new Random();

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matriz[i, j] = rng.Next(10);
                        Console.Write(matriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.Write("Digite o valor que deseja encontrar: ");
                int numero = int.Parse(Console.ReadLine());
                int aux = 0;

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (matriz[i, j] == numero)
                        {
                            aux++;
                            break;
                        }
                    }
                    if (aux > 0)
                    {
                        break;
                    }
                }

                if (aux > 0)
                {
                    Console.WriteLine("O número existe no vetor");
                }
                else
                {
                    Console.WriteLine("Número inexistente");

                    //10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

                    int[,] a = new int[4, 4];
                    int[,] b = new int[4, 4];
                    int total = 0, cont = 0, acimaMedia = 0, abaixoMedia = 0, naMedia = 0;
                    Random rng = new Random();

                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            a[i, j] = rng.Next(10);
                            Console.Write(a[i, j] + " ");
                            total += a[i, j];
                            cont++;
                        }
                        Console.Write("\t");
                        for (int j = 0; j < b.GetLength(1); j++)
                        {
                            b[i, j] = rng.Next(10);
                            Console.Write(b[i, j] + " ");
                            total += b[i, j];
                            cont++;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    float media = (float)total / cont;

                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            if (a[i, j] > media)
                            {
                                Console.Write("↑ ");
                                acimaMedia++;
                            }
                            else if (a[i, j] < media)
                            {
                                Console.Write("↓ ");
                                abaixoMedia++;
                            }
                            else if (a[i, j] == media)
                            {
                                Console.Write("= ");
                                naMedia++;
                            }
                        }
                        Console.Write("\t");
                        for (int j = 0; j < b.GetLength(1); j++)
                        {
                            if (b[i, j] > media)
                            {
                                Console.Write("↑ ");
                                acimaMedia++;
                            }
                            else if (b[i, j] < media)
                            {
                                Console.Write("↓ ");
                                abaixoMedia++;
                            }
                            else if (b[i, j] == media)
                            {
                                Console.Write("= ");
                                naMedia++;
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    Console.WriteLine("A media é: " + media);
                    Console.WriteLine("Quantidade a cima da media é: " + acimaMedia);
                    Console.WriteLine("Quantidade a baixo da media é: " + abaixoMedia);
                    Console.WriteLine("Quantidade na media é: " + naMedia);


                    //11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

                    float[,] a = new float[3, 3];
                    float[,] b = new float[3, 3];
                    Random rng = new Random();

                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            a[i, j] = rng.Next(10);
                            Console.Write(a[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    for (int i = 0; i < b.GetLength(0); i++)
                    {
                        for (int j = 0; j < b.GetLength(1); j++)
                        {
                            if (i == 0 && j == 0)
                            {
                                b[i, j] = 0;
                            }
                            else
                            {
                                b[i, j] = a[i, j] / (i + j);
                            }
                            Console.Write(b[i, j].ToString("F1") + "\t");
                        }
                        Console.WriteLine();
                    }


                    //12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices(i + j) seja um número par.

                    int[,] matriz = new int[4, 4];
                    Random rng = new Random();

                    
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            matriz[i, j] = rng.Next(10);
                        }
                    }

                    
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            if ((i + j) % 2 == 0)
                            {
                                Console.Write(matriz[i, j] + "\t");
                            }
                            else
                            {
                                Console.Write("-\t");
                            }
                        }
                        Console.WriteLine();
                    }


                    //13) Escreva um programa que leia uma matriz de ordem 5(ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da
                    //diagonal secundária.


                int tamanho = 5;
                int[,] matriz = new int[tamanho, tamanho];

                
                for (int i = 0; i < tamanho; i++)
                {
                    for (int j = 0; j < tamanho; j++)
                    {
                        Console.Write("Digite o elemento [" + (i + 1) + ", " + (j + 1) + "]: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                }

              
                int somaDiagonalPrincipal = 0;
                for (int i = 0; i < tamanho; i++)
                {
                    somaDiagonalPrincipal += matriz[i, i];
                }

             
                int somaDiagonalSecundaria = 0;
                for (int i = 0; i < tamanho; i++)
                {
                    somaDiagonalSecundaria += matriz[i, tamanho - 1 - i];
                }

             
                if (somaDiagonalPrincipal == somaDiagonalSecundaria)
                {
                    Console.WriteLine("A soma da diagonal principal é igual à soma da diagonal secundária.");
                }
                else
                {
                    Console.WriteLine("A soma da diagonal principal não é igual à soma da diagonal secundária.");
                }


                    //14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal(da esquerda para a direita)
                    //são os mesmos da diagonal
                    //secundária(direita pra esquerda).

                    int tamanho = 5;
                    int[,] matriz = new int[tamanho, tamanho];

                    
                    for (int i = 0; i < tamanho; i++)
                    {
                        for (int j = 0; j < tamanho; j++)
                        {
                            Console.Write("Digite o elemento [" + (i + 1) + ", " + (j + 1) + "]: ");
                            matriz[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                   
                    bool diagonaisIguais = true;
                    for (int i = 0; i < tamanho; i++)
                    {
                        if (matriz[i, i] != matriz[i, tamanho - 1 - i])
                        {
                            diagonaisIguais = false;
                            break;
                        }
                    }

                    if (diagonaisIguais)
                    {
                        Console.WriteLine("Os elementos da diagonal principal são os mesmos da diagonal secundária.");
                    }
                    else
                    {
                        Console.WriteLine("Os elementos da diagonal principal não são os mesmos da diagonal secundária.");

                        //15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

                        int tamanho = 4;
                        int[,] matrizA = new int[tamanho, tamanho];
                        int[,] matrizB = new int[tamanho, tamanho];
                        int[,] matrizSoma = new int[tamanho, tamanho];

                        
                        Console.WriteLine("Preencha a matriz A:");
                        for (int i = 0; i < tamanho; i++)
                        {
                            for (int j = 0; j < tamanho; j++)
                            {
                                Console.Write("Digite o elemento [" + (i + 1) + ", " + (j + 1) + "]: ");
                                matrizA[i, j] = int.Parse(Console.ReadLine());
                            }
                        }

                        Console.WriteLine("Preencha a matriz B:");
                        for (int i = 0; i < tamanho; i++)
                        {
                            for (int j = 0; j < tamanho; j++)
                            {
                                Console.Write("Digite o elemento [" + (i + 1) + ", " + (j + 1) + "]: ");
                                matrizB[i, j] = int.Parse(Console.ReadLine());
                            }
                        }

                        
                        for (int i = 0; i < tamanho; i++)
                        {
                            for (int j = 0; j < tamanho; j++)
                            {
                                matrizSoma[i, j] = matrizA[i, j] + matrizB[i, j];
                            }
                        }

                        
                        Console.WriteLine("Matriz Resultante (A + B):");
                        for (int i = 0; i < tamanho; i++)
                        {
                            for (int j = 0; j < tamanho; j++)
                            {
                                Console.Write(matrizSoma[i, j] + " ");
                            }
                            Console.WriteLine();

                            //16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.Transpor uma matriz significa transformar suas linhas em colunas e vice - versa.

                            int[,] matrizOriginal = new int[3, 4];
                            int[,] matrizTransposta = new int[4, 3];

                        
                            Console.WriteLine("Preencha a matriz original:");
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    Console.Write("Digite o elemento [" + (i + 1) + ", " + (j + 1) + "]: ");
                                    matrizOriginal[i, j] = int.Parse(Console.ReadLine());
                                }
                            }

                  
                            for (int i = 0; i < 4; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    matrizTransposta[i, j] = matrizOriginal[j, i];
                                }
                            }

            
                            Console.WriteLine("Matriz Transposta (4x3):");
                            for (int i = 0; i < 4; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    Console.Write(matrizTransposta[i, j] + " ");
                                }
                                Console.WriteLine();
                            }

                            //17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o
                            //maior elemento da matriz.Escreva também a linha e a coluna onde foi encontrado.

                            int[,] matriz = new int[10, 10];

                            // Preencher a matriz
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    Console.Write("Digite o elemento [" + (i + 1) + ", " + (j + 1) + "]: ");
                                    matriz[i, j] = int.Parse(Console.ReadLine());
                                }
                            }

                            int maiorElemento = matriz[0, 0];
                            int linhaMaiorElemento = 0;

                           
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    if (matriz[i, j] > maiorElemento)
                                    {
                                        maiorElemento = matriz[i, j];
                                        linhaMaiorElemento = i;
                                    }
                                }
                            }

                            int menorElemento = matriz[linhaMaiorElemento, 0];
                            int colunaMenorElemento = 0;

                           
                            for (int j = 0; j < 10; j++)
                            {
                                if (matriz[linhaMaiorElemento, j] < menorElemento)
                                {
                                    menorElemento = matriz[linhaMaiorElemento, j];
                                    colunaMenorElemento = j;
                                }
                            }

                            Console.WriteLine("O elemento minimax é " + menorElemento);
                            Console.WriteLine("Encontrado na linha " + (linhaMaiorElemento + 1) + " e coluna " + (colunaMenorElemento + 1));
                        }
}
}