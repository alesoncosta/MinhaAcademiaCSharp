using System.Runtime.ConstrainedExecution;

namespace Exercícios_de_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

            int tamanho = 10;
            int[] vetor = new int[tamanho];
            int pares = 0;
            int impares = 0;

            Console.WriteLine("Digite 10 números para os vetores");
            Console.Write("Insira o número: ");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine("Quantidade de números pares: " + pares);
            Console.WriteLine("Quantidade de números ímpares: " + impares);


            // 2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

            int tamanho = 20;
            int[] vetor1 = new int[tamanho];
            int[] vetor2 = new int[tamanho];
            int[] resultado = new int[tamanho];

            Console.WriteLine("Digite 20 números para o primeiro vetor");

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite 20 números para o segundo vetor");

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < resultado.Length; i++)
            {
                resultado[i] = vetor1[i] + vetor2[i];
            }

            Console.WriteLine("Resultado da soma dos vetores:");
            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine("Elemento " + (i + 1) + ": " + resultado[i]);
            }


            // 3.Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.

            int tamanho = 20;
            int[] vetor = new int[tamanho];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Índice das posições com números primos:");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (primo(vetor[i]))
                {
                    Console.WriteLine("Posição " + i + ": " + vetor[i]);
                }
            }

            Console.ReadLine();
        }

        static bool primo(int numero)
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


        // 4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

        int tamanho = 10;
        int[] vetor1 = new int[tamanho];
        int[] vetor2 = new int[tamanho];
        int[] resultado = new int[tamanho];

        Console.WriteLine("Digite 10 números para o primeiro vetor");

        for (int i = 0; i<vetor1.Length; i++)
        {
            Console.Write("Digite o " + (i + 1) + "º número: ");
            vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite 10 números para o segundo vetor");

        for (int i = 0; i<vetor2.Length; i++)
        {
            Console.Write("Digite o " + (i + 1) + "º número: ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < resultado.Length; i++)
        {
            resultado[i] = vetor1[i] * vetor2[i];
        }

        Console.WriteLine("Resultado da multiplicação dos vetores:");
        for (int i = 0; i < resultado.Length; i++)
        {
            Console.WriteLine("Elemento " + (i + 1) + ": " + resultado[i]);
        }


        // 5.Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

        int tamanho = 80;
        int[] vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Digite o valor para a posição " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int menorElemento = vetor[0];
        int posicaoMenorElemento = 0;

        for (int i = 1; i < tamanho; i++)
        {
            if (vetor[i] < menorElemento)
            {
                menorElemento = vetor[i];
                posicaoMenorElemento = i;
            }
        }

        Console.WriteLine("Menor elemento: " + menorElemento);
        Console.WriteLine("Posição do menor elemento: " + posicaoMenorElemento);

        Console.ReadLine();


        ////6.Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura.Exemplo:
        ////a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
        ////b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

        int tamanho = 10;
        int[] numeros = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Digite o " + (i + 1) + "º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números na ordem contrária:");
        for (int i = tamanho - 1; i >= 0; i--)
        {
            Console.Write(numeros[i] + " ");
        }

        Console.ReadLine();



        //7.Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
        //            a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
        //            b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |

        int tamanho = 10;
        int[] numeros = new int[tamanho];
        int[] numerosPares = new int[tamanho];
        int[] numerosImpares = new int[tamanho];
        int contadorPares = 0;
        int contadorImpares = 0;

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Digite o " + (i + 1) + "º número: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                numerosPares[contadorPares] = numeros[i];
                contadorPares++;
            }
            else
            {
                numerosImpares[contadorImpares] = numeros[i];
                contadorImpares++;
            }
        }

        Console.WriteLine("Números pares:");
        for (int i = 0; i < contadorPares; i++)
        {
            Console.Write(numerosPares[i] + " ");
        }

        Console.WriteLine("\nNúmeros ímpares:");
        for (int i = 0; i < contadorImpares; i++)
        {
            Console.Write(numerosImpares[i] + " ");
        }

        Console.ReadLine();

        //            8.Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
        //            a.lê:          	| 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
        //            b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .

        int tamanho = 30;
        double[] numeros = new double[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Digite o " + (i + 1) + "º número: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Posições dos números menores que zero: ");
        for (int i = 0; i < tamanho; i++)
        {
            if (numeros[i] < 0)
            {
                Console.Write((i + 1) + " ");
            }
        }

        Console.ReadLine();



        //9.Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

        int tamanho = 10;
        int[] vetor = new int[tamanho];
        int[] vetorOrdenado = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Digite o valor para a posição " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Array.Copy(vetor, vetorOrdenado, tamanho);
        Array.Sort(vetorOrdenado);

        Console.WriteLine("Vetor Ordenado em Ordem Crescente:");
        foreach (int num in vetorOrdenado)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();


        //10.Escreva um algoritmo que leia um vetor inteiro de 20 posições.Crie um segundo vetor, substituindo os valores nulos por 2.Mostre os vetores lidos e o vetor resultado.

        int tamanho = 20;
        int[] vetorOriginal = new int[tamanho];
        int[] vetorResultado = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Digite o valor para a posição " + (i + 1) + ": ");
            vetorOriginal[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < tamanho; i++)
        {
            if (vetorOriginal[i] == 0)
            {
                vetorResultado[i] = 2;
            }
            else
            {
                vetorResultado[i] = vetorOriginal[i];
            }
        }

        Console.WriteLine("Vetor Original:");
        MostrarVetor(vetorOriginal);

        Console.WriteLine("\nVetor Resultado:");
        MostrarVetor(vetorResultado);

        Console.ReadLine();
        }

        static void MostrarVetor(int[] vetor)
        {
            foreach (int elemento in vetor)
            {
                Console.Write(elemento + " ");
            }


        //11.Escreva um programa que leia valores em um vetor de 5 posições.Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

        int tamanho = 5;
        int[] numeros = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Digite o " + (i + 1) + "º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números na ordem contrária:");
        for (int i = tamanho - 1; i >= 0; i--)
        {
            Console.Write(numeros[i] + " ");
        }

        Console.ReadLine();


        //12.Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".

        int tamanho = 10;
        int[] vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Digite o valor para a posição " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite um número para verificar se existe no vetor: ");
        int numeroProcurado = int.Parse(Console.ReadLine());

        bool encontrado = false;
        Console.Write("Número encontrado e está na posição: ");
        for (int i = 0; i < tamanho; i++)
        {
            if (vetor[i] == numeroProcurado)
            {
                Console.Write((i + 1) + " ");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("O número fornecido não existe no vetor!");
        }

        Console.ReadLine();


        //13.Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8.O vetor terá no máximo 100 posições.Sair do programa quando for digitado - 1 ou quando atingir o máximo de posições do vetor.

        const int tamanho = 100;
        int[] vetor = new int[tamanho];
        int contador2 = 0;
        int contador4 = 0;
        int contador8 = 0;
        int posicao = 0;

        Console.WriteLine("Digite números inteiros e positivos para preencher o vetor.");
        Console.WriteLine("Digite -1 para sair ou atingir o máximo de posições (100).");

        while (posicao < tamanho)
        {
            Console.Write("Digite o número na posição ");
            Console.Write(posicao + 1);
            Console.Write(": ");
            vetor[posicao] = int.Parse(Console.ReadLine());

            if (vetor[posicao] == -1)
            {
                break;
            }

            if (vetor[posicao] == 2)
            {
                contador2++;
            }
            else if (vetor[posicao] == 4)
            {
                contador4++;
            }
            else if (vetor[posicao] == 8)
            {
                contador8++;
            }

            posicao++;
        }

        Console.Write("Número 2 aparece ");
        Console.Write(contador2);
        Console.WriteLine(" vez(es).");

        Console.Write("Número 4 aparece ");
        Console.Write(contador4);
        Console.WriteLine(" vez(es).");

        Console.Write("Número 8 aparece ");
        Console.Write(contador8);
        Console.WriteLine(" vez(es).");

        Console.ReadLine();


        //14.Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números.Se o código for zero, termine o algoritmo.Se o código for 1, mostre o vetor na ordem em que foi lido.Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

        const int tamanho = 50;
        int[] vetor = new int[tamanho];
        int codigo;

        Console.Write("Digite o código numérico (0 para sair, 1 para mostrar na ordem, 2 para mostrar na ordem inversa): ");
        codigo = int.Parse(Console.ReadLine());

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Digite o número na posição ");
            Console.Write(i + 1);
            Console.Write(": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        switch (codigo)
        {
            case 0:
                Console.WriteLine("Programa encerrado.");
                break;
            case 1:
                Console.WriteLine("Vetor na ordem em que foi lido:");
                MostrarVetor(vetor);
                break;
            case 2:
                Console.WriteLine("Vetor na ordem inversa:");
                MostrarVetorInverso(vetor);
                break;
            default:
                Console.WriteLine("Código inválido.");
                break;
        }

        Console.ReadLine();
    }

    static void MostrarVetor(int[] vetor)
    {
        foreach (int numero in vetor)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }

    static void MostrarVetorInverso(int[] vetor)
    {
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }


    //15.Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem.Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo.Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

    int tamanho = 20;
    int[] vetor1 = new int[tamanho];
    int[] vetor2 = new int[tamanho];

    Console.WriteLine("Digite 20 elementos inteiros:");
    for (int i = 0; i < tamanho; i++)
    {
        Console.Write("Elemento ");
        Console.Write(i + 1);
        Console.Write(": ");
        vetor1[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < tamanho; i++)
    {
        vetor2[i] = vetor1[tamanho - 1 - i];
    }

    Console.Write("Vetor 1: ");
    MostrarVetor(vetor1);

    Console.Write("Vetor 2 (Ordem invertida): ");
    MostrarVetor(vetor2);

    Console.ReadLine();
    }

    static void MostrarVetor(int[] vetor)
    {
        foreach (int elemento in vetor)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
}


    //16.Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva.Crie, a seguir, um vetor para cada uma das operações:
    //•	A união de X com Y
    //•	A diferença entre X e Y
    //•	A interseção entre X e Y
    //Escreva o vetor resultado de cada uma das operações.

    int tamanho = 10;
    int[] X = new int[tamanho];
    int[] Y = new int[tamanho];

    Console.WriteLine("Digite 10 elementos para o vetor X:");
    LerVetor(X);

    Console.WriteLine("Digite 10 elementos para o vetor Y:");
    LerVetor(Y);

    int[] uniao = Uniao(X, Y);
    int[] diferenca = Diferenca(X, Y);
    int[] intersecao = Intersecao(X, Y);

    Console.WriteLine("\nVetor União:");
    MostrarVetor(uniao);

    Console.WriteLine("Vetor Diferença (X - Y):");
    MostrarVetor(diferenca);

    Console.WriteLine("Vetor Interseção:");
    MostrarVetor(intersecao);

    Console.ReadLine();
    }

    static void LerVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Elemento ");
            Console.Write(i + 1);
            Console.Write(": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static int[] Uniao(int[] X, int[] Y)
    {
        int[] uniao = new int[X.Length + Y.Length];
        Array.Copy(X, uniao, X.Length);
        Array.Copy(Y, 0, uniao, X.Length, Y.Length);
        return uniao;
    }

    static int[] Diferenca(int[] X, int[] Y)
    {
        int[] diferenca = new int[X.Length];
        for (int i = 0; i < X.Length; i++)
        {
            diferenca[i] = X[i];
            if (Array.IndexOf(Y, X[i]) != -1)
            {
                diferenca[i] = 0;
            }
        }
        return diferenca;
    }

    static int[] Intersecao(int[] X, int[] Y)
    {
        int[] intersecao = new int[Math.Min(X.Length, Y.Length)];
        int contador = 0;
        for (int i = 0; i < X.Length; i++)
        {
            if (Array.IndexOf(Y, X[i]) != -1)
            {
                intersecao[contador] = X[i];
                contador++;
            }
        }
        Array.Resize(ref intersecao, contador);
        return intersecao;
    }

    static void MostrarVetor(int[] vetor)
    {
        foreach (var elemento in vetor)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
}

}
}
}