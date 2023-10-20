namespace Exercícios_de_Repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n pessoas e calcular a média das idades.

            Console.Write("Digite a idade da primeira pessoa : ");
            int pessoa1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade da segunda pessoa : ");
            int pessoa2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade da terceira pessoa : ");
            int pessoa3 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade da quarta pessoa : ");
            int pessoa4 = int.Parse(Console.ReadLine());

            int media = (pessoa1 + pessoa2 + pessoa3 + pessoa4) / 4;

            Console.WriteLine("A média de idade das pessoas é: " + media + " anos!");

            //2.Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.

            int maiorNumero = int.MinValue; 

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
            }

            Console.Write("O maior número digitado é: ");
            Console.WriteLine(maiorNumero);

            Console.WriteLine("O maior número digitado é: " + maiorNumero);

            //3.Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número
            //x lido utilizando laços de repetição, e mostre na tela.


            Console.Write("Digite um número para calcular a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada de " + numero + ":");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine(numero + " x " + i + " = " + resultado);


            //4.Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
            //elevado na y sem utilizar a função pow.

                Console.Write("Digite o valor de x: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor de y: ");
                int y = int.Parse(Console.ReadLine());

                double resultado = 1.0; // Inicializa o resultado como 1.0

                if (y >= 0)
                {
                for (int i = 1; i <= y; i++)
                {
                resultado *= x; // Multiplica resultado por x
                }
                }
                else
                {
                for (int i = 1; i <= -y; i++)
                {
                resultado /= x; // Divide resultado por x
                }
                }

                Console.WriteLine("O resultado de " + x + " elevado a " + y + " é: " + resultado);

                //5.Escreva um algoritmo para calcular o fatorial de um número.

                Console.Write("Digite um número inteiro positivo para calcular o fatorial: ");
                int numero = int.Parse(Console.ReadLine());

                long fatorial = 1;

                for (int i = 1; i <= numero; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine("O fatorial de " + numero + " é " + fatorial);

                //6.Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações
                //aplicadas para aquela turma.Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final
                //(média das notas das avaliações).

                Console.Write("Digite o número de alunos na turma: ");
                int numeroDeAlunos = int.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade de avaliações aplicadas: ");
                int quantidadeDeAvaliacoes = int.Parse(Console.ReadLine());

                for (int aluno = 1; aluno <= numeroDeAlunos; aluno++)
                {
                    double somaDasNotas = 0;

                    for (int avaliacao = 1; avaliacao <= quantidadeDeAvaliacoes; avaliacao++)
                    {
                        Console.Write("Digite a nota da avaliação " + avaliacao + " para o aluno " + aluno + ": ");
                        double nota = double.Parse(Console.ReadLine());

                        somaDasNotas += nota;
                    }

                    double media = somaDasNotas / quantidadeDeAvaliacoes;
                    Console.Write("A média das notas do aluno " + aluno + " é: ");
                    Console.WriteLine(media);

                 //7.Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
                 //um usuário. Apresente o resultado.

                 int totalNumeros = 20;
                 int numerosPares = 0;
                 int numerosImpares = 0;

                for (int i = 0; i < totalNumeros; i++)
                {
                   Console.Write("Digite um número: ");
                     int numero = int.Parse(Console.ReadLine());

                      if (numero % 2 == 0)
                       {
                            numerosPares++;
                       }
                      else
                       {
                            numerosImpares++;
                       }
                    }

                    Console.WriteLine("Quantidade de números pares: " + numerosPares);
                    Console.WriteLine("Quantidade de números ímpares: " + numerosImpares);
                }
            }
    }
}