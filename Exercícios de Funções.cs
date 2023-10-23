

namespace Exercícios_de_Funções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIOS DE FUNÇÕES

            //1) Fazer uma calculadora das 4 operações(soma, subtração, multiplicação e divisão) Para isso, precisaremos aceitar números com vírgula.


            double num1, num2, result;
        char op;

        Console.WriteLine("Calculadora das 4 operações");
        Console.Write("Digite o primeiro número: ");
        if (double.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Digite o operador (+, -, *, /): ");
            if (char.TryParse(Console.ReadLine(), out op))
            {
                Console.Write("Digite o segundo número: ");
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    switch (op)
                    {
                        case '+':
                            result = num1 + num2;
                            Console.WriteLine("Resultado: " + num1 + " + " + num2 + " = " + result);
                            break;
                        case '-':
                            result = num1 - num2;
                            Console.WriteLine("Resultado: " + num1 + " - " + num2 + " = " + result);
                            break;
                        case '*':
                            result = num1 * num2;
                            Console.WriteLine("Resultado: " + num1 + " * " + num2 + " = " + result);
                            break;
                        case '/':
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine("Resultado: " + num1 + " / " + num2 + " = " + result);
                            }
                            else
                            {
                                Console.WriteLine("Erro: Divisão por zero.");
                            }
                            break;
                        default:
                            Console.WriteLine("Operador inválido.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }
            else
            {
                Console.WriteLine("Operador inválido.");
            }
        }
        else
        {
            Console.WriteLine("Número inválido.");

            //2) Fazer programa que tenha duas funções. i) para ler um vetor de 10 elementos(variável global) e ii) para verificar e apresentar a quantidadede elementos pares que este vetor possui.

            LerVetor();
            int pares = ContarElementosPares();
            Console.WriteLine("A quantidade de elementos pares no vetor é: " + pares);
        }

        static void LerVetor()
        {
            Console.WriteLine("Digite os 10 elementos do vetor:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Elemento " + (i + 1) + ": ");
                if (int.TryParse(Console.ReadLine(), out vetor[i]) == false)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                    i--;
                }
            }
        }

        static int ContarElementosPares()
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;

            //3) Desenvolva uma função que calcule a média de três números fornecidos como argumentos.

            double num1 = 5.5;
            double num2 = 7.2;
            double num3 = 10.1;

            double media = CalcularMedia(num1, num2, num3);

            Console.WriteLine("A média dos três números é: " + media);
        

        static double CalcularMedia(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }

            //4) Escreva uma função que calcule o fatorial de um número inteiro positivo.

            int numero = 5;
            long fatorial = CalcularFatorial(numero);

            Console.WriteLine("O fatorial de " + numero + " é: " + fatorial);
        

        static long CalcularFatorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("O número deve ser não negativo.");
            }

            if (numero == 0)
            {
                return 1;
            }
            else
            {
                long resultado = 1;
                for (int i = 1; i <= numero; i++)
                {
                    resultado *= i;
                }
                return resultado;

                    //5) Desenvolva uma função que converta uma temperatura em graus Celsius para Fahrenheit.

                        double celsius = 25.0;
                        double fahrenheit = CelsiusParaFahrenheit(celsius);

                        Console.WriteLine(celsius + " graus Celsius é equivalente a " + fahrenheit + " graus Fahrenheit.");
                    

                    static double CelsiusParaFahrenheit(double celsius)
                    {
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        return fahrenheit;
                    }

                    //6) Escreva uma função que calcule a média de um vetor de 10 números.

                    int[] vetor = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

                    double media = CalcularMedia(vetor);

                    Console.WriteLine("A média dos elementos do vetor é: " + media);
                

                static double CalcularMedia(int[] vetor)
                {
                    if (vetor.Length == 0)
                    {
                        throw new ArgumentException("O vetor não pode estar vazio.");
                    }

                    int soma = 0;

                    foreach (int numero in vetor)
                    {
                        soma += numero;
                    }

                    double media = (double)soma / vetor.Length;
                    return media;

                        //7) Crie uma função que determine se um número é primo ou não.

                        int numero = 13; 
                        bool primo = VerificarPrimo(numero);

                        if (primo)
                        {
                            Console.WriteLine(numero + " é um número primo.");
                        }
                        else
                        {
                            Console.WriteLine(numero + " não é um número primo.");
                        }
                    

                    static bool VerificarPrimo(int numero)
                    {
                        if (numero <= 1)
                        {
                            return false;
                        }

                        if (numero == 2)
                        {
                            return true;
                        }

                        if (numero % 2 == 0)
                        {
                            return false;
                        }

                        int limite = (int)Math.Floor(Math.Sqrt(numero));

                        for (int i = 3; i <= limite; i += 2)
                        {
                            if (numero % i == 0)
                            {
                                return false;
                            }
                        }

                        return true;

                            //8) Ler um número inteiro e passar por parâmetro para uma função e retornar 0, se o número é par, ou 1, se o número é ímpar.

                            Console.Write("Digite um número inteiro: ");
                            int numero = int.Parse(Console.ReadLine());

                            int resultado = VerificarParOuImpar(numero);

                            Console.WriteLine("O resultado é: " + resultado);
                        }

                        static int VerificarParOuImpar(int numero)
                        {
                            if (numero % 2 == 0)
                            {
                                return 0; // O número é par.
                            }
                            else
                            {
                                return 1; // O número é ímpar.
                            }

                            //9) Escrever um programa com uma função que receba por parâmetro dois números(n1 e n2) e retorna a soma dos números inteiros que existem entre n1 e n2(inclusive ambos).Apresente o resultado na main.
                            //Desafio: Ler um vetor de inteiros com 10 elementos e passar por parâmetro para uma função que verifica e retorna o menor elemento do vetor.

                            Console.Write("Digite o primeiro número (n1): ");
                            int n1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo número (n2): ");
                            int n2 = int.Parse(Console.ReadLine());

                            int soma = CalcularSomaEntreNumeros(n1, n2);
                            Console.WriteLine("A soma dos números entre " + n1 + " e " + n2 + " é: " + soma);

                            
                            int[] vetor = new int[10];
                            for (int i = 0; i < 10; i++)
                            {
                                Console.Write("Digite o elemento " + (i + 1) + " do vetor: ");
                                vetor[i] = int.Parse(Console.ReadLine());
                            }

                            int menorElemento = EncontrarMenorElemento(vetor);
                            Console.WriteLine("O menor elemento do vetor é: " + menorElemento);
                        }

              
                        static int CalcularSomaEntreNumeros(int n1, int n2)
                        {
                            int soma = 0;
                            for (int i = n1; i <= n2; i++)
                            {
                                soma += i;
                            }
                            return soma;
                        }

                       
                        static int EncontrarMenorElemento(int[] vetor)
                        {
                            int menor = vetor[0];
                            for (int i = 1; i < vetor.Length; i++)
                            {
                                if (vetor[i] < menor)
                                {
                                    menor = vetor[i];
                                }
                            }
                            return menor;
                        

                        }
    }
}

