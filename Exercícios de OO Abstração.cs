namespace Exercícios_de_OO_Abstração
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //1 - Criar uma classe Pessoa que contém as propriedades Nome e Idade.Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa.
            //A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade adicional Disciplina.  
            //Criar um método abstrato Apresentar na classe Pessoa. 
            //Em seguida, criar um método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno, e um método Apresentar na classe Professor que imprime o nome, a idade e a disciplina do professor.
                    
        abstract class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }

            public abstract void Apresentar();
        }

        class Aluno : Pessoa
        {
            public string Matricula { get; set; }

            public override void Apresentar()
            {
                Console.WriteLine("Aluno: Nome: " + Nome + ", Idade: " + Idade + ", Matrícula: " + Matricula);
            }
        }

        class Professor : Pessoa
        {
            public string Disciplina { get; set; }

            public override void Apresentar()
            {
                Console.WriteLine("Professor: Nome: " + Nome + ", Idade: " + Idade + ", Disciplina: " + Disciplina);
            }
        }

        class Program
        {
            static void Main()
            {
                Aluno aluno = new Aluno
                {
                    Nome = "João",
                    Idade = 20,
                    Matricula = "12345"
                };

                Professor professor = new Professor
                {
                    Nome = "Maria",
                    Idade = 35,
                    Disciplina = "Matemática"
                };

                aluno.Apresentar();
                professor.Apresentar();
            }
        }


        //2 - Criar uma classe Veiculo que contém as propriedades Marca e Modelo.Criar um método abstrato chamado Dirigir. Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo.
        //A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade adicional Cilindrada. 
        //Criar um método abstrato Dirigir na classe Veiculo. 
        //Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e um método Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas"

       
    abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public abstract void Dirigir();
    }

    class Carro : Veiculo
    {
        public int QuantidadeDePortas { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine("Dirigindo o " + Marca + " " + Modelo + " com " + QuantidadeDePortas + " portas");
        }
    }

    class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine("Dirigindo a " + Marca + " " + Modelo + " com " + Cilindrada + " cilindradas");
        }
    }

    class Program
    {
        static void Main()
        {
            Carro meuCarro = new Carro
            {
                Marca = "Fiat",
                Modelo = "Marea",
                QuantidadeDePortas = 4
            };

            Moto minhaMoto = new Moto
            {
                Marca = "dafra",
                Modelo = "Zig50",
                Cilindrada = 50
            };

            meuCarro.Dirigir();
            minhaMoto.Dirigir();
        }
    }


    //3 - Crie uma interface chamada "IFormaGeometrica" com dois métodos abstratos: "CalcularArea()" e "CalcularPerimetro()". 
    //Em seguida, crie duas classes que implementam essa interface: "Retangulo" e "Circulo". 
    //Implemente os métodos "CalcularArea()" e "CalcularPerimetro()" para cada uma dessas classes, de forma que o "Retangulo" calcule a área e o perímetro de um retângulo e o "Circulo" calcule a área e o perímetro de um círculo.


    public interface IFormaGeometrica
    {
        double CalcularArea();
        double CalcularPerimetro();
    }

    
    public class Retangulo : IFormaGeometrica
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double CalcularArea()
        {
            return Altura * Largura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Altura + Largura);
        }
    }


    public class Circulo : IFormaGeometrica
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }

        class Program
    {
        static void Main()
        {
            Retangulo retangulo = new Retangulo(5, 8);
            Circulo circulo = new Circulo(3);

            Console.WriteLine("Área e Perímetro do Retângulo:");
            Console.WriteLine("Área: " + retangulo.CalcularArea() + ", Perímetro: " + retangulo.CalcularPerimetro());

            Console.WriteLine("\nÁrea e Perímetro do Círculo:");
            Console.WriteLine("Área: " + circulo.CalcularArea() + ", Perímetro: " + circulo.CalcularPerimetro());
        }
    }


    //4 - Crie uma classe abstrata "ContaBancaria" com propriedades para "Saldo" e métodos abstratos "Depositar" e "Sacar". Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca", que implementam os métodos de depósito e saque de acordo com as regras de cada tipo de conta.

    public abstract class ContaBancaria
    {
        public double Saldo { get; protected set; }

    
        public abstract void Depositar(double valor);

    
        public abstract void Sacar(double valor);
    }

    
    public class ContaCorrente : ContaBancaria
    {
    
        public override void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito de " + valor.ToString("C") + " realizado na Conta Corrente. Saldo atual: " + Saldo.ToString("C"));
        }

            public override void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque na Conta Corrente.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("Saque de " + valor.ToString("C") + " realizado na Conta Corrente. Saldo atual: " + Saldo.ToString("C"));
            }
        }
    }

    
    public class ContaPoupanca : ContaBancaria
    {
       
        public override void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito de " + valor.ToString("C") + " realizado na Conta Poupança. Saldo atual: " + Saldo.ToString("C"));
        }

        
        public override void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque na Conta Poupança.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("Saque de " + valor.ToString("C") + " realizado na Conta Poupança. Saldo atual: " + Saldo.ToString("C"));
            }
        }
    }

    
    class Program
    {
        static void Main()
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.Depositar(1000);
            contaCorrente.Sacar(500);

            Console.WriteLine(); 

            ContaPoupanca contaPoupanca = new ContaPoupanca();
            contaPoupanca.Depositar(2000);
            contaPoupanca.Sacar(1000);
        }
    }


    //5 - Crie uma classe abstrata "Produto" com propriedades para "Nome", "Preço" e um método abstrato "CalcularDesconto". Crie classes derivadas para diferentes tipos de produtos, como "Livro" e "Eletrônico", que implementam o método "CalcularDesconto" de acordo com as regras específicas de desconto para cada tipo de produto.
    //Livro – 5% de desconto
    //Eletrônico  - 12.5% de desconto
           
    public abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

       
        public abstract double CalcularDesconto();
    }

    
    public class Livro : Produto
    {
        
        public override double CalcularDesconto()
        {
            return Preco * 0.05; 
        }
    }

    
    public class Eletronico : Produto
    {
       
        public override double CalcularDesconto()
        {
            return Preco * 0.125; 
        }
    }

    
    class Program
    {
        static void Main()
        {
            Livro livro = new Livro
            {
                Nome = "Aventuras na Floresta",
                Preco = 50.0
            };

            Eletronico eletronico = new Eletronico
            {
                Nome = "Smartphone",
                Preco = 800.0
            };

            Console.WriteLine("Livro: " + livro.Nome + ", Preço Original: " + livro.Preco.ToString("C") + ", Desconto: " + livro.CalcularDesconto().ToString("C"));
            Console.WriteLine("Eletrônico: " + eletronico.Nome + ", Preço Original: " + eletronico.Preco.ToString("C") + ", Desconto: " + eletronico.CalcularDesconto().ToString("C"));
        }
    }


    //6 - Crie uma classe "ContaBancaria" com propriedades para "Saldo" e métodos "Depositar" e "Sacar". 


    //Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca", que implementam os métodos de depósito e saque de acordo com as regras de cada tipo de conta.
    //Regras: 
    //i) Para sacar na conta poupança, cada saque tem um custo de 0,10 
    //ii) para depositar na conta poupança, não existe custo
    //iii) Para sacar na conta corrente somente o primeiro saque é gratuito e o restante tem tem um custo de 0,05 centavos
    //iv) Para depositar na conta corrente não existe custo porém deve apresentar a mensgem na tela do valor do saldo.
        
    public class ContaBancaria
    {
        public double Saldo { get; protected set; }

        
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito realizado. Saldo atual: " + Saldo.ToString("C"));
        }

       
        public virtual void Sacar(double valor)
        {
            Saldo -= valor;
            Console.WriteLine("Saque realizado. Saldo atual: " + Saldo.ToString("C"));
        }
    }

   
    public class ContaPoupanca : ContaBancaria
    {
        
        public override void Sacar(double valor)
        {
            base.Sacar(valor + 0.10); 
        }
    }

    
    public class ContaCorrente : ContaBancaria
    {
        private bool primeiroSaqueGratuito = true;

      
        public override void Sacar(double valor)
        {
            if (primeiroSaqueGratuito)
            {
                base.Sacar(valor);
                primeiroSaqueGratuito = false;
            }
            else
            {
                base.Sacar(valor + 0.05); 
            }
        }
    }


    class Program
    {
        static void Main()
        {
            ContaPoupanca poupanca = new ContaPoupanca();
            poupanca.Depositar(1000);
            poupanca.Sacar(200);

            Console.WriteLine();

            ContaCorrente corrente = new ContaCorrente();
            corrente.Depositar(2000);
            corrente.Sacar(500);
            corrente.Sacar(100);
        }
    }


    //7 -
    // a) Crie uma classe base chamada "Veiculo" com propriedades como "Marca" e "Ano."
    // b) Crie classes derivadas como "Carro" e "Moto" que herdem de "Veiculo" e adicionem propriedades específicas, como "Número de Portas" para carros e "Cilindrada" para motos.
    // c) Crie uma lista de Veículos que inclui instâncias de "Veiculo", "Carro" e "Moto." Use um loop para percorrer a lista e chamar um método "Apresentar" que exibe informações sobre cada veículo, demonstrando o polimorfismo.
    // d) Modifique a classe "Veiculo" para ter um método virtual "Apresentar" que exiba informações gerais do veículo.
    // e) Sobrescreva o método "Apresentar" nas classes derivadas para incluir informações específicas, como o número de portas para carros ou a cilindrada para motos.

       
    public class Veiculo
    {
        public string Marca { get; set; }
        public int Ano { get; set; }

       
        public virtual void Apresentar()
        {
            Console.WriteLine("Veículo: Marca - " + Marca + ", Ano - " + Ano);
        }
    }

    
    public class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }

       
        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("Carro: Número de Portas - " + NumeroDePortas);
        }
    }

    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("Moto: Cilindrada - " + Cilindrada);
        }
    }

    
    class Program
    {
        static void Main()
        {
            List<Veiculo> veiculos = new List<Veiculo>
        {
            new Veiculo { Marca = "Ford", Ano = 2022 },
            new Carro { Marca = "Chevrolet", Ano = 2021, NumeroDePortas = 4 },
            new Moto { Marca = "Toyota", Ano = 2020, Cilindrada = 500 }
        };

            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.Apresentar();
                Console.WriteLine(); 
            }
        }
    }


    //8 - Crie uma classe chamada "Calculadora" com métodos para somar, subtrair, multiplicar e dividir números. Implemente sobrecargas desses métodos para aceitar diferentes números de argumentos e tipos, como inteiros e decimais.
        
    public class Calculadora
    {
        
        public int Somar(int a, int b)
        {
            return a + b;
        }

        
        public decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }

        
        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

       
        public decimal Somar(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }

        
        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        
        public decimal Subtrair(decimal a, decimal b)
        {
            return a - b;
        }

       
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

       
        public decimal Multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        
        public double Dividir(int a, int b)
        {
            if (b != 0)
            {
                return (double)a / b;
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero.");
                return double.NaN;
            }
        }

        
        public decimal Dividir(decimal a, decimal b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero.");
                return decimal.NaN; 
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Calculadora calculadora = new Calculadora();

            
            Console.WriteLine("Soma (int): " + calculadora.Somar(5, 3));
            Console.WriteLine("Soma (decimal): " + calculadora.Somar(5.5m, 3.2m));
            Console.WriteLine("Soma (int, Sobrecarga): " + calculadora.Somar(2, 3, 5));
            Console.WriteLine("Soma (decimal, Sobrecarga): " + calculadora.Somar(2.5m, 3.7m, 1.8m));

            Console.WriteLine("Subtração (int): " + calculadora.Subtrair(8, 3));
            Console.WriteLine("Subtração (decimal): " + calculadora.Subtrair(8.5m, 3.2m));

            Console.WriteLine("Multiplicação (int): " + calculadora.Multiplicar(4, 5));
            Console.WriteLine("Multiplicação (decimal): " + calculadora.Multiplicar(4.5m, 2.2m));

            Console.WriteLine("Divisão (int): " + calculadora.Dividir(10, 2));
            Console.WriteLine("Divisão (decimal): " + calculadora.Dividir(10.5m, 2.1m));
        }
    }


    //9 -
    //a) Crie uma classe base "Pessoa" com propriedades como "Nome" e "Idade." 
    //b) Crie uma classe derivada "Estudante" que herde de "Pessoa" e adicione propriedades específicas, como "Matricula" e "Curso."
    //c) Certifique-se de que a classe derivada chame o construtor da classe base

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

       
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }

 
    public class Estudante : Pessoa
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }

        
        public Estudante(string nome, int idade, string matricula, string curso)
            : base(nome, idade)
        {
            Matricula = matricula;
            Curso = curso;
        }
    }

    
    class Program
    {
        static void Main()
        {
           
            Estudante estudante = new Estudante("Aleson", 24, "12345", "Ciências da Computação");

            
            Console.WriteLine("Nome: " + estudante.Nome + ", Idade: " + estudante.Idade + ", Matrícula: " + estudante.Matricula + ", Curso: " + estudante.Curso);
        }
    }


    //10 - 
    //a) Crie uma classe base "Funcionario" com propriedades como "Nome" e "Salario."
    //b) Crie classes derivadas, como "Gerente" e "Desenvolvedor," que herdem de "Funcionario" e forneçam implementações específicas para calcular bônus ou mostrar funções.

    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        
        public virtual double CalcularBonus()
        {
            return Salario * 0.1; 
        }

       
        public virtual void MostrarFuncao()
        {
            Console.WriteLine("Funcionário genérico");
        }
    }

  
    public class Gerente : Funcionario
    {
        
        public Gerente(string nome, double salario)
            : base(nome, salario)
        {
        }

        
        public override double CalcularBonus()
        {
            return Salario * 0.15; 
        }

        public override void MostrarFuncao()
        {
            Console.WriteLine("Gerente");
        }
    }

    public class Desenvolvedor : Funcionario
    {
       
        public Desenvolvedor(string nome, double salario)
            : base(nome, salario)
        {
        }

       
        public override double CalcularBonus()
        {
            return Salario * 0.12; 
        }

      
        public override void MostrarFuncao()
        {
            Console.WriteLine("Desenvolvedor");
        }
    }

    
    class Program
    {
        static void Main()
        {
            
            Gerente gerente = new Gerente("Alexandre", 5000);
            Desenvolvedor desenvolvedor = new Desenvolvedor("Sonia", 4000);

           
            Console.WriteLine("Nome: " + gerente.Nome + ", Salário: " + gerente.Salario.ToString("C") + ", Bônus: " + gerente.CalcularBonus().ToString("C"));
            gerente.MostrarFuncao();

            Console.WriteLine(); 

            Console.WriteLine("Nome: " + desenvolvedor.Nome + ", Salário: " + desenvolvedor.Salario.ToString("C") + ", Bônus: " + desenvolvedor.CalcularBonus().ToString("C"));
            desenvolvedor.MostrarFuncao();
        }
    }


    //11 - 
    //a) Crie uma classe "Produto" com propriedades como "Nome," "Preço" e "Estoque."
    //b) Implemente construtores sobrecarregados que permitam criar instâncias de produtos de diferentes maneiras, como especificando apenas o nome ou especificando todas as propriedades.

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }

        
        public Produto(string nome, decimal preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        
        public Produto(string nome)
            : this(nome, 0, 0) 
        {
        }

        
        public Produto(string nome, decimal preco)
            : this(nome, preco, 0) 
        {
        }

        
    }

    
    class Program
    {
        static void Main()
        {
            
            Produto produto1 = new Produto("Laptop", 1500, 10);
            Produto produto2 = new Produto("Mouse", 20);
            Produto produto3 = new Produto("Teclado");

            ExibirInformacoes(produto1);
            ExibirInformacoes(produto2);
            ExibirInformacoes(produto3);
        }

        static void ExibirInformacoes(Produto produto)
        {
            Console.WriteLine("Nome: " + produto.Nome + ", Preço: " + produto.Preco.ToString("C") + ", Estoque: " + produto.Estoque);
        }
    }

    }
}

