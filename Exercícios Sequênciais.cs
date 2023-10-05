namespace Exercícios_Sequênciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIOS SEQUÊNCIAIS


            //1) Escreva um programa em C# e no Visual Studio para calcular a média
            //aritmética entre dois números quaisquer.

            int valor1;
            int valor2;
            float media;

            Console.Write("Digite um valor inteiro: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um outro valor inteiro: ");
            valor2 = int.Parse(Console.ReadLine());

            media = (valor1 + valor2) / 2;

            Console.WriteLine("A média dos valores é: " + media);



            //2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

            Console.WriteLine("Cálculo da média entre quatro números quaisquer ");
            Console.WriteLine("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o quarto número: ");
            double numero4 = Convert.ToDouble(Console.ReadLine());

            double Media = (numero1 + numero2 + numero3 + numero4) / 4;

            Console.WriteLine("A média dos números é: " +Media);

            Console.ReadLine();





            //3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio,
            //para trocar entre si os valores de duas variáveis A e B.

            int a = 9;
            int b = 10;
            int tmp = a;
            a = b;
            b = tmp;

            Console.Write("Digite uma frase qualquer: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Você digitou....: " + frase.ToUpper());
            Console.WriteLine("Esta frase tem " + frase.Length + " caracteres");


            Console.Write("Digite algo para pesquisar: ");
            string palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine(palavra + " aparece na frase");
                //bloco de instruções caso a palavra esteja na frase
            }
            else
            {
                Console.WriteLine(palavra + " não aparece na frase");
               
            }

            //4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            //forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            Console.Write("Digite o dia (DD): ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Digite o mês (MM): ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano (AAAA): ");
            int ano = int.Parse(Console.ReadLine());

            string dataAAAAMMDD = $"{ano:D4}/{mes:D2}/{dia:D2}";

            string dataAAMMDD = $"{ano.ToString().Substring(2)}/{mes:D2}/{dia:D2}";

            Console.WriteLine($"Data na forma AAAAMMDD: {dataAAAAMMDD}");
            Console.WriteLine($"Data na forma AAMMDD: {dataAAMMDD}");


            //5)Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            //(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
            //consumido para percorrê-la (medido em l).

            Console.WriteLine("Calculadora de Consumo Médio de Combustível");

            Console.Write("Digite a distância total percorrida em Km: ");

            double distanciaPercorrida = double.Parse(Console.ReadLine());

            Console.Write("Digite o volume de combustível consumido em litros: ");

            double volumeCombustivel = double.Parse(Console.ReadLine());

            double consumoMedio = distanciaPercorrida / volumeCombustivel;

            string consumoFormatado = string.Format("{0:0.00}", consumoMedio);

            Console.WriteLine("O consumo médio de combustível é: " + consumoFormatado + " Km/l");

            //6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            //isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
            //de IPI (única) a ser acrescentada. 


            Console.WriteLine("Cadastro de Parafusos A e B");


            Console.WriteLine("Dados do Parafuso A:");
            Console.Write("Digite o código: ");
            string codigoA = Console.ReadLine();

            Console.Write("Digite a quantidade de peças: ");
            int quantidadeA = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário: ");
            double valorUnitarioA = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem de IPI: ");
            double ipiA = double.Parse(Console.ReadLine());


            Console.WriteLine("Dados do Parafuso B:");
            Console.Write("Digite o código: ");
            string codigoB = Console.ReadLine();

            Console.Write("Digite a quantidade de peças: ");
            int quantidadeB = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário: ");
            double valorUnitarioB = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem de IPI: ");
            double ipiB = double.Parse(Console.ReadLine());


            double valorTotalA = quantidadeA * valorUnitarioA * (1 + (ipiA / 100));
            double valorTotalB = quantidadeB * valorUnitarioB * (1 + (ipiB / 100));


            Console.WriteLine("\nResumo dos Parafusos:");
            Console.WriteLine("Parafuso A - Código: " + codigoA);
            Console.WriteLine("Quantidade: " + quantidadeA + " peças");
            Console.WriteLine("Valor Unitário: R$ " + valorUnitarioA.ToString("F2"));
            Console.WriteLine("Porcentagem de IPI: " + ipiA + "%");
            Console.WriteLine("Valor Total com IPI: R$ " + valorTotalA.ToString("F2"));

            Console.WriteLine("\nParafuso B - Código: " + codigoB);
            Console.WriteLine("Quantidade: " + quantidadeB + " peças");
            Console.WriteLine("Valor Unitário: R$ " + valorUnitarioB.ToString("F2"));
            Console.WriteLine("Porcentagem de IPI: " + ipiB + "%");
            Console.WriteLine("Valor Total com IPI: R$ " + valorTotalB.ToString("F2"));

            ////7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            //o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
            //Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.


            Console.WriteLine("Cálculo do Salário Total do Vendedor");

            Console.Write("Número do vendedor: ");
            int numeroVendedor = int.Parse(Console.ReadLine());

            Console.Write("Salário fixo do vendedor: R$ ");
            double salarioFixo = double.Parse(Console.ReadLine());

            Console.Write("Total de vendas efetuadas: R$ ");
            double totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Percentual de comissão (%): ");
            double percentualComissao = double.Parse(Console.ReadLine());

            double salarioTotal = salarioFixo + (totalVendas * percentualComissao / 100);

            Console.WriteLine("\nNúmero do vendedor: " + numeroVendedor);
            Console.WriteLine("Salário total do vendedor: R$ " + salarioTotal.ToString("F2"));

            //8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            //A fórmula da conversão é F=(9*C+160)/ 5.


            Console.WriteLine("Conversão de Temperatura de Celsius para Fahrenheit");

            Console.Write("Digite a temperatura em graus Celsius: ");
            double temperaturaCelsius = double.Parse(Console.ReadLine());

            double temperaturaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

            Console.WriteLine("Temperatura em graus Fahrenheit: " + temperaturaFahrenheit.ToString("F2") + " °F");


            ////9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
            //do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
            //Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00;
            //se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
            //Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            //da entrada e das duas prestações, de acordo com as regras acima. 
            //Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
            //conseqüente pagamento dos boletos das duas prestações.

            double valorMercadoria;
            double entrada;
            double prestacao;
            double resto;

            Console.Write("Digite o valor da mercadoria: R$ ");
            valorMercadoria = double.Parse(Console.ReadLine());

            resto = valorMercadoria % 3;
            prestacao = (valorMercadoria - resto) / 3;
            entrada = prestacao + resto;

            Console.WriteLine("Valor da entrada: " + entrada);
            Console.WriteLine("Valor das prestaçoes: " + prestacao);

            //10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
            //para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
            //realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
            //notas de menor valor fossem distribuídas em número mínimo possível. 
            //Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            //uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
            //Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
            //de acordo com o critério da “distribuição ótima”.


            Console.WriteLine("Distribuição Ótima de Notas em um Caixa Eletrônico");

            Console.Write("Digite o valor da quantia solicitada em reais (R$): ");
            int quantiaSolicitada = int.Parse(Console.ReadLine());

            int notas50 = quantiaSolicitada / 50;
            int resto50 = quantiaSolicitada % 50;

            int notas20 = resto50 / 20;
            int resto20 = resto50 % 20;

            int notas10 = resto20 / 10;
            int resto10 = resto20 % 10;

            int notas5 = resto10 / 5;
            int notas1 = resto10 % 5;

            Console.WriteLine("\nDistribuição ótima de notas:");
            Console.WriteLine("Notas de R$ 50,00: " + notas50);
            Console.WriteLine("Notas de R$ 20,00: " + notas20);
            Console.WriteLine("Notas de R$ 10,00: " + notas10);
            Console.WriteLine("Notas de R$ 5,00: " + notas5);
            Console.WriteLine("Notas de R$ 1,00: " + notas1);


            ////11)Escreva um algoritmo para ler o número de eleitores de um município, 
            //o número de votos brancos, nulos e válidos. 
            //Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.


            Console.WriteLine("Cálculo de Percentual de Votos");

            Console.Write("Digite o número de eleitores: ");
            int numeroEleitores = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos brancos: ");
            int votosBrancos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos nulos: ");
            int votosNulos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos válidos: ");
            int votosValidos = int.Parse(Console.ReadLine());

            double percentualBrancos = (double)votosBrancos / numeroEleitores * 100;
            double percentualNulos = (double)votosNulos / numeroEleitores * 100;
            double percentualValidos = (double)votosValidos / numeroEleitores * 100;

            Console.WriteLine("\nResultados:");
            Console.WriteLine("Percentual de votos brancos: " + percentualBrancos.ToString("F2") + "%");
            Console.WriteLine("Percentual de votos nulos: " + percentualNulos.ToString("F2") + "%");
            Console.WriteLine("Percentual de votos válidos: " + percentualValidos.ToString("F2") + "%");


            //12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
            //marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido
            //dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

            //Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia 

            //Média do consumo = Total quilometragem/ quantidade de combustível gasto

            //Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)


            Console.WriteLine("Calculadora de Média de Consumo e Lucro Diário");


            Console.Write("Quilometragem inicial do dia (em Km): ");
            double odometroInicio = double.Parse(Console.ReadLine());

            Console.Write("Quilometragem final do dia (em Km): ");
            double odometroFinal = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de litros de combustível gastos: ");
            double litrosCombustivel = double.Parse(Console.ReadLine());

            Console.Write("Valor total recebido dos passageiros (R$): ");
            double valorTotalRecebido = double.Parse(Console.ReadLine());

            double totalQuilometragem = odometroFinal - odometroInicio;


            double mediaConsumo = totalQuilometragem / litrosCombustivel;

            double lucroDia = valorTotalRecebido - (litrosCombustivel * 6.90);


            Console.WriteLine("\nResultados:");
            Console.WriteLine("Média de consumo em Km/l: " + mediaConsumo.ToString("F2") + " Km/l");
            Console.WriteLine("Lucro líquido do dia: R$ " + lucroDia.ToString("F2"));



            //13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
            //preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
            //vendidas pelo vendedor, calcule e mostre: o salário do empregado

            Console.WriteLine("Cálculo do Salário do Vendedor");

            Console.Write("Digite o valor do salário mínimo mensal: R$ ");
            double salarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço de custo de cada bicicleta: R$ ");
            double precoCustoBicicleta = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
            int numeroBicicletasVendidas = int.Parse(Console.ReadLine());

            double salarioBase = 2 * salarioMinimo;
            double comissao = numeroBicicletasVendidas * 0.15 * precoCustoBicicleta;
            double SalarioTotal = salarioBase + comissao;

            Console.WriteLine("\nSalário do empregado: R$ " + salarioTotal.ToString("F2"));

            //FIM DOS EXERCÍCIOS SEQUÊNCIAIS
        }
    }
}