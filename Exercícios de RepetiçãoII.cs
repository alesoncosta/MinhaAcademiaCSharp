using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace Exercício_de_Repetição_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados
            //(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

          

            int numero;
            do
            {
                Console.WriteLine("Insira um número inteiro positivo: ");
                numero = int.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    Console.WriteLine("Numero informado não é positivo!");
                    Console.WriteLine();
                    continue;
                }
            } while (numero <= 0);


            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();


            //2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
            //informar um outro número. Caso positivo, o programa em VS deve ser repetido.


            bool continuar = true;

            while (continuar)
            {
                int numero;
                bool entradaValida = false;

                while (!entradaValida)
                {
                    Console.Write("Digite um número inteiro positivo: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out numero) && numero > 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Valor incorreto! Por favor, digite um número inteiro positivo.");
                    }
                }

                Console.WriteLine("Número digitado: " + numero);
                Console.Write("Números inteiros pares entre 1 e " + numero + ": ");

                for (int i = 2; i <= numero; i += 2)
                {
                    Console.Write(i);
                    if (i < numero - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine();

                Console.Write("Deseja informar outro número (S para sim, N para não)? ");
                string resposta = Console.ReadLine();
                continuar = (resposta.ToLower() == "s");

                //3)Fazer um laço(repetição) que fique solicitando números ao usuário. 
                //Se o usuário digitar 0 o programa em VS deve parar. 
                //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.


                int numero;

                while (true)
                {
                    Console.Write("Digite um número (ou 0 para sair): ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero == 0)
                    {
                        Console.WriteLine("Programa encerrado.");
                        break;
                    }

                    if (numero % 2 == 0)
                    {
                        Console.WriteLine(numero + " é um número par.");
                    }
                    else
                    {
                        Console.WriteLine(numero + " é um número ímpar.");
                    }

                    bool primo = VerificarPrimo(numero);
                    if (primo)
                    {
                        Console.WriteLine(numero + " é um número primo.");
                    }
                    else
                    {
                        Console.WriteLine(numero + " não é um número primo.");
                    }
                }
            }

            static bool VerificarPrimo(int num)
            {
                if (num <= 1)
                {
                    return false;
                }

                for (int index = 2; index <= Math.Sqrt(num); index++)
                {
                    if (num % index == 0)
                    {
                        return false;
                    }
                }
                return true;

                //4.Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA).
                //Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
                //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
                //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
                //escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
                //de votos em branco. 

                int votosJoao = 0;
                int votosZeca = 0;
                int votosBranco = 0;

                while (true)
                {
                    Console.Write("Digite o seu voto (JOAO, ZECA, BRANCO ou FIM): ");
                    string voto = Console.ReadLine().ToUpper();

                    if (voto == "FIM")
                    {
                        break;
                    }
                    else if (voto == "JOAO")
                    {
                        votosJoao++;
                    }
                    else if (voto == "ZECA")
                    {
                        votosZeca++;
                    }
                    else if (voto == "BRANCO")
                    {
                        votosBranco++;
                    }
                    else
                    {
                        Console.WriteLine("Voto inválido. Por favor, digite JOAO, ZECA, BRANCO ou FIM.");
                    }
                }

                Console.WriteLine("Total de votos para JOAO: " + votosJoao);
                Console.WriteLine("Total de votos para ZECA: " + votosZeca);
                Console.WriteLine("Total de votos em branco: " + votosBranco);

                //5.Modifique o programa em VS anterior para aceitar votos nulos
                //(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
                //Ao final, informe o nome do candidato vencedor, o número de votos nulos
                //e o número de pessoas que votaram.

                int votosJoao = 0;
                int votosZeca = 0;
                int votosBranco = 0;
                int votosNulos = 0;
                int totalVotos = 0;

                while (true)
                {
                    Console.Write("Digite o seu voto (JOAO, ZECA, BRANCO, NULO ou FIM): ");
                    string voto = Console.ReadLine().ToUpper();

                    if (voto == "FIM")
                    {
                        break;
                    }
                    else if (voto == "JOAO")
                    {
                        votosJoao++;
                        totalVotos++;
                    }
                    else if (voto == "ZECA")
                    {
                        votosZeca++;
                        totalVotos++;
                    }
                    else if (voto == "BRANCO")
                    {
                        votosBranco++;
                        totalVotos++;
                    }
                    else if (voto == "NULO")
                    {
                        votosNulos++;
                        totalVotos++;
                    }
                    else
                    {
                        Console.WriteLine("Voto inválido. Por favor, digite JOAO, ZECA, BRANCO, NULO ou FIM.");
                    }
                }

                Console.WriteLine("Total de votos para JOAO: " + votosJoao);
                Console.WriteLine("Total de votos para ZECA: " + votosZeca);
                Console.WriteLine("Total de votos em branco: " + votosBranco);
                Console.WriteLine("Total de votos nulos: " + votosNulos);
                Console.WriteLine("Total de pessoas que votaram: " + totalVotos);

                if (votosJoao > votosZeca)
                {
                    Console.WriteLine("JOAO venceu a eleição.");
                }
                else if (votosZeca > votosJoao)
                {
                    Console.WriteLine("ZECA venceu a eleição.");
                }
                else
                {
                    Console.WriteLine("A eleição terminou em empate.");

                    //6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
                    //ou seja, repita a leitura até que ela esteja correta(maior do que zero). 
                    //Ao final, mostre a idade digitada.

                    int idade;

                    do
                    {
                        Console.Write("Informe a idade (maior que zero): ");
                    } while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0);

                    Console.WriteLine("Idade digitada: " + idade);

                    //7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa.
                    //A cada solicitação, teste se o usuário informou um valor válido. 
                    //Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
                    //informe que ele está incorreto e saia do programa em VS.
                    //Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
                    //informe que está errada e saia.Se estiver correta, solicite o salário.
                    //Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
                    //Se estiver correto, mostre todos os valores lidos.

                    string nome;
                    int idade;
                    double salario;

                  
                    do
                    {
                        Console.Write("Informe o nome: ");
                        nome = Console.ReadLine().Trim();
                        if (string.IsNullOrWhiteSpace(nome))
                        {
                            Console.WriteLine("Nome incorreto. Por favor, insira um nome válido.");
                        }
                    } while (string.IsNullOrWhiteSpace(nome));

                   
                    do
                    {
                        Console.Write("Informe a idade (maior que zero): ");
                    } while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0);

                    
                    do
                    {
                        Console.Write("Informe o salário (maior que zero): ");
                    } while (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0);

          
                    Console.WriteLine("Nome: " + nome);
                    Console.WriteLine("Idade: " + idade);
                    Console.WriteLine("Salário: " + salario.ToString("C"));

                    //8.Faça um programa em VS que solicite um numero inteiro.S
                    //e o numero não for inteiro, solicite - o até que seja.após, informe se ele é par ou impar.
                    //Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

                    do
                    {
                        int numero;

                        do
                        {
                            Console.Write("Informe um número inteiro: ");
                        } while (!int.TryParse(Console.ReadLine(), out numero));

                        if (numero % 2 == 0)
                        {
                            Console.WriteLine(numero + " é um número par.");
                        }
                        else
                        {
                            Console.WriteLine(numero + " é um número ímpar.");
                        }

                        Console.Write("Deseja repetir o programa (S/N)? ");
                    } while (Console.ReadLine().ToUpper() == "S");

                    //9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
                    //o zoológico num determinado dia, imprimindo:
                    //Quantas pessoas tem entre 1 e 3 filhos.
                    //Quantas pessoas tem entre 4 e 7 filhos.
                    //Quantas pessoas tem mais de 8 filhos.
                    //Quantas pessoas não tem filhos.

                    int pessoasCom1a3Filhos = 0;
                    int pessoasCom4a7Filhos = 0;
                    int pessoasMaisDe8Filhos = 0;
                    int pessoasSemFilhos = 0;

                    for (int i = 1; i <= 30; i++)
                    {
                        Console.Write("Quantidade de filhos da pessoa " + i + ": ");
                        int quantidadeFilhos = int.Parse(Console.ReadLine());

                        if (quantidadeFilhos >= 1 && quantidadeFilhos <= 3)
                        {
                            pessoasCom1a3Filhos++;
                        }
                        else if (quantidadeFilhos >= 4 && quantidadeFilhos <= 7)
                        {
                            pessoasCom4a7Filhos++;
                        }
                        else if (quantidadeFilhos > 8)
                        {
                            pessoasMaisDe8Filhos++;
                        }
                        else if (quantidadeFilhos == 0)
                        {
                            pessoasSemFilhos++;
                        }
                    }

                    Console.WriteLine("Pessoas com 1 a 3 filhos: " + pessoasCom1a3Filhos);
                    Console.WriteLine("Pessoas com 4 a 7 filhos: " + pessoasCom4a7Filhos);
                    Console.WriteLine("Pessoas com mais de 8 filhos: " + pessoasMaisDe8Filhos);
                    Console.WriteLine("Pessoas sem filhos: " + pessoasSemFilhos);

                    //10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
                    //Número de pessoas do sexo masculino.
                    //Número de pessoas do sexo feminino.
                    //Número de pessoas com idade inferior a 30 anos.
                    //Número de pessoas com idade superior a 60 anos.
                    //Média de idade das mulheres.

                    int pessoasDoSexoMasculino = 0;
                    int pessoasDoSexoFeminino = 0;
                    int pessoasComIdadeInferiorA30 = 0;
                    int pessoasComIdadeSuperiorA60 = 0;
                    int totalIdadeMulheres = 0;
                    int totalMulheres = 0;

                    for (int i = 1; i <= 50; i++)
                    {
                        Console.Write("Nome da pessoa " + i + ": ");
                        string nome = Console.ReadLine();

                        Console.Write("Sexo (M/F) da pessoa " + i + ": ");
                        char sexo = char.ToUpper(Console.ReadKey().KeyChar);
                        Console.WriteLine();

                        Console.Write("Idade da pessoa " + i + ": ");
                        int idade = int.Parse(Console.ReadLine());

                        if (sexo == 'M')
                        {
                            pessoasDoSexoMasculino++;
                        }
                        else if (sexo == 'F')
                        {
                            pessoasDoSexoFeminino++;
                            totalIdadeMulheres += idade;
                            totalMulheres++;
                        }

                        if (idade < 30)
                        {
                            pessoasComIdadeInferiorA30++;
                        }

                        if (idade > 60)
                        {
                            pessoasComIdadeSuperiorA60++;
                        }
                    }

                    Console.WriteLine("Número de pessoas do sexo masculino: " + pessoasDoSexoMasculino);
                    Console.WriteLine("Número de pessoas do sexo feminino: " + pessoasDoSexoFeminino);
                    Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + pessoasComIdadeInferiorA30);
                    Console.WriteLine("Número de pessoas com idade superior a 60 anos: " + pessoasComIdadeSuperiorA60);

                    double mediaIdadeMulheres = totalMulheres > 0 ? (double)totalIdadeMulheres / totalMulheres : 0;
                    Console.WriteLine("Média de idade das mulheres: " + mediaIdadeMulheres.ToString("F2"));

                    //11.Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
                    //a média aritmética da turma e a quantidade de alunos da turma.Usar - 1 para encerrar a leitura.

                    double nota;
                    double notaMaisAlta = double.MinValue;
                    double notaMaisBaixa = double.MaxValue;
                    double somaNotas = 0;
                    int quantidadeAlunos = 0;

                    Console.WriteLine("Digite as notas dos alunos (-1 para encerrar a leitura):");

                    while (true)
                    {
                        Console.Write("Nota do aluno (ou -1 para encerrar): ");
                        nota = double.Parse(Console.ReadLine());

                        if (nota == -1)
                        {
                            break;
                        }

                        quantidadeAlunos++;
                        somaNotas += nota;

                        if (nota > notaMaisAlta)
                        {
                            notaMaisAlta = nota;
                        }

                        if (nota < notaMaisBaixa)
                        {
                            notaMaisBaixa = nota;
                        }
                    }

                    if (quantidadeAlunos == 0)
                    {
                        Console.WriteLine("Nenhum aluno inseriu notas.");
                    }
                    else
                    {
                        double media = somaNotas / quantidadeAlunos;

                        Console.WriteLine("Nota mais alta: " + notaMaisAlta);
                        Console.WriteLine("Nota mais baixa: " + notaMaisBaixa);
                        Console.WriteLine("Média da turma: " + media);
                        Console.WriteLine("Quantidade de alunos: " + quantidadeAlunos);



                        //12.Apresentar o total da soma dos cem primeiros números inteiros.

                        int soma = 0;

                        for (int i = 1; i <= 100; i++)
                        {
                            soma += i;
                        }

                        Console.WriteLine("A soma dos cem primeiros números inteiros é: " + soma);



                        //13.Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e 500.

                        int soma = 0;

                        for (int i = 2; i <= 500; i += 2)
                        {
                            soma += i;
                        }

                        Console.WriteLine("O somatório dos valores pares entre 1 e 500 é: " + soma);



                        //14.Mostrar as potências de 2 variando de 0 a 10.

                        for (int i = 0; i <= 10; i++)
                        {
                            long potenciaDe2 = (long)Math.Pow(2, i);
                            Console.WriteLine("2^" + i + " = " + potenciaDe2);
                        }

                        //15.Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado
                        //ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente.
                        //Considerar nota 7,0 como mínima para aprovação.

                        double nota1, nota2, nota3, nota4;

                        Console.Write("Digite a primeira nota: ");
                        nota1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite a segunda nota: ");
                        nota2 = double.Parse(Console.ReadLine());

                        Console.Write("Digite a terceira nota: ");
                        nota3 = double.Parse(Console.ReadLine());

                        Console.Write("Digite a quarta nota: ");
                        nota4 = double.Parse(Console.ReadLine());

                      
                        double media = (nota1 * 2 + nota2 * 1 + nota3 * 2 + nota4 * 4) / 9;

                        Console.WriteLine("Média ponderada: " + media);

                       
                        if (media >= 7.0)
                        {
                            Console.WriteLine("Aluno APROVADO!");
                        }
                        else
                        {
                            Console.WriteLine("Aluno REPROVADO!");

                            //16.Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da
                            //multiplicação sucessiva de N por 3 enquanto o produto for menor que 250
                            //(N * 3; N * 3 * 3; N * 3 * 3 * 3; etc).

                            Console.Write("Digite um número N (menor ou igual a 50): ");
                            int n = int.Parse(Console.ReadLine());

                            int produto = n;
                            int multiplicador = 3;

                            while (produto < 250)
                            {
                                produto *= multiplicador;
                                Console.WriteLine("Produto atual: " + produto);
                            }

                            Console.WriteLine("Valor final obtido: " + produto);



                            //17.Apresentar os quadrados dos números inteiros de 15 a 200.



                            for (int i = 15; i <= 200; i++)
                            {
                                int quadrado = i * i;
                                Console.WriteLine("O quadrado de " + i + " é " + quadrado);



                                //18.Elaborar um programa que apresente o valor de uma potência de uma base qualquer
                                //levada a um expoente qualquer, ou seja, NM.

                                Console.Write("Digite a base (N): ");
                                double baseN = double.Parse(Console.ReadLine());

                                Console.Write("Digite o expoente (M): ");
                                int expoenteM = int.Parse(Console.ReadLine());

                                double resultado = Math.Pow(baseN, expoenteM);

                                Console.WriteLine($"O valor de {baseN}^{expoenteM} é {resultado}");



                                //19.A prefeitura de uma cidade fez uma pesquisa entre seus habitantes,
                                //coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 

                                //a) média do salário da população;
                                //b) média do número de filhos;
                                //c) maior salário;
                                //d) percentual de pessoas com salário até R$ 100,00.
                                //O final da leitura de dados se dará com a entrada de um salário negativo.


                                double salario;
                                int numeroFilhos;
                                double somaSalario = 0;
                                int somaNumeroFilhos = 0;
                                int quantidadePessoas = 0;
                                double maiorSalario = double.MinValue;
                                int quantidadeSalarioAte100 = 0;

                                while (true)
                                {
                                    Console.Write("Digite o salário (ou um valor negativo para encerrar): ");
                                    salario = double.Parse(Console.ReadLine());

                                    if (salario < 0)
                                    {
                                        break;
                                    }

                                    Console.Write("Digite o número de filhos: ");
                                    numeroFilhos = int.Parse(Console.ReadLine());

                                    somaSalario += salario;
                                    somaNumeroFilhos += numeroFilhos;
                                    quantidadePessoas++;

                                    if (salario > maiorSalario)
                                    {
                                        maiorSalario = salario;
                                    }

                                    if (salario <= 100)
                                    {
                                        quantidadeSalarioAte100++;
                                    }
                                }

                                if (quantidadePessoas == 0)
                                {
                                    Console.WriteLine("Nenhum dado foi inserido.");
                                }
                                else
                                {
                                    double mediaSalario = somaSalario / quantidadePessoas;
                                    double mediaFilhos = (double)somaNumeroFilhos / quantidadePessoas;
                                    double percentualSalarioAte100 = (double)quantidadeSalarioAte100 / quantidadePessoas * 100;

                                    Console.WriteLine("Média do salário da população: " + mediaSalario.ToString("C2"));
                                    Console.WriteLine("Média do número de filhos: " + mediaFilhos.ToString("F2"));
                                    Console.WriteLine("Maior salário: " + maiorSalario.ToString("C2"));
                                    Console.WriteLine("Percentual de pessoas com salário até R$ 100,00: " + percentualSalarioAte100.ToString("F2") + "%");


                                    //20.Foi realizada uma pesquisa de algumas características físicas da população de uma
                                    //certa região, a qual coletou os seguintes dados referentes a cada habitante para serem analisados:
                                    //-sexo(masculino e feminino)
                                    //- cor dos olhos(azuis, verdes ou castanhos)
                                    //-cor dos cabelos(louros, castanhos, pretos)
                                    //-idade


                                    //Faça um algoritmo que determine e escreva:

                                    //-a maior idade dos habitantes
                                    //-a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
                                    //e que tenham olhos verdes e cabelos louros.
                                    //O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

                                    int maiorIdade = int.MinValue;
                                    int quantidadeFemininosVerdesLouros = 0;

                                    while (true)
                                    {
                                        Console.Write("Digite o sexo (M/F): ");
                                        char sexo = char.ToUpper(Console.ReadKey().KeyChar);
                                        Console.WriteLine();

                                        if (sexo == 'M' || sexo == 'F')
                                        {
                                            Console.Write("Digite a cor dos olhos (azuis, verdes, castanhos): ");
                                            string olhos = Console.ReadLine().ToLower();

                                            Console.Write("Digite a cor dos cabelos (louros, castanhos, pretos): ");
                                            string cabelos = Console.ReadLine().ToLower();

                                            Console.Write("Digite a idade (ou -1 para encerrar): ");
                                            int idade = int.Parse(Console.ReadLine());

                                            if (idade == -1)
                                            {
                                                break;
                                            }

                                            if (idade > maiorIdade)
                                            {
                                                maiorIdade = idade;
                                            }

                                            if (sexo == 'F' && idade >= 18 && idade <= 35 && olhos == "verdes" && cabelos == "louros")
                                            {
                                                quantidadeFemininosVerdesLouros++;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Sexo inválido. Digite 'M' ou 'F'.");
                                        }
                                    }

                                    Console.WriteLine("Maior idade dos habitantes: " + maiorIdade);

                                    Console.WriteLine("Quantidade de indivíduos do sexo feminino, com idade entre 18 e 35 anos, olhos verdes e cabelos louros: " + quantidadeFemininosVerdesLouros);
                                }
    }
        }
                
        }
    }
}