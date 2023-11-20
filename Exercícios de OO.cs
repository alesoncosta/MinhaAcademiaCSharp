namespace Exercícios_de_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIOS DE OO

            //1 - Crie uma classe Produto com atributos como nome, preço e quantidade em estoque. Implemente um construtor e métodos para adicionar e remover itens do estoque.

            class Produto
            {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
            public int QuantidadeEmEstoque { get; private set; }

            public Produto(string nome, decimal preco, int quantidadeEmEstoque)
            {
                Nome = nome;
                Preco = preco;
                QuantidadeEmEstoque = quantidadeEmEstoque;
            }

            public void AdicionarEstoque(int quantidade)
            {
                if (quantidade > 0)
                {
                    QuantidadeEmEstoque += quantidade;
                    Console.WriteLine(quantidade + " unidades de " + Nome + " adicionadas ao estoque. Novo estoque: " + QuantidadeEmEstoque);
                }
                else
                {
                    Console.WriteLine("A quantidade deve ser maior que zero.");
                }
            }

            public void RemoverEstoque(int quantidade)
            {
                if (quantidade > 0 && quantidade <= QuantidadeEmEstoque)
                {
                    QuantidadeEmEstoque -= quantidade;
                    Console.WriteLine(quantidade + " unidades de " + Nome + " removidas do estoque. Novo estoque: " + QuantidadeEmEstoque);
                }
                else if (quantidade > QuantidadeEmEstoque)
                {
                    Console.WriteLine("Quantidade insuficiente em estoque.");
                }
                else
                {
                    Console.WriteLine("A quantidade deve ser maior que zero.");
                }
            }
        }

        class Program
        {
            static void Main()
            {
                Produto meuProduto = new Produto("Notebook", 2500.00m, 10);

                meuProduto.AdicionarEstoque(5);
                meuProduto.RemoverEstoque(3);
            }
        }


        //2 - Crie uma classe RegistroDeCompras com atributos para registrar informações de compras (data, produto, valor). Implemente um construtor e métodos para adicionar e listar compras.

        using System;
        using System.Collections.Generic;

        class RegistroDeCompras
    {
        private List<Compra> compras;

        public RegistroDeCompras()
        {
            compras = new List<Compra>();
        }

        public void AdicionarCompra(DateTime data, string produto, decimal valor)
        {
            Compra novaCompra = new Compra(data, produto, valor);
            compras.Add(novaCompra);
        }

        public void ListarCompras()
        {
            Console.WriteLine("Registro de Compras:");
            foreach (var compra in compras)
            {
                Console.WriteLine(compra.ToString());
            }
        }
    }

    class Compra
    {
        public DateTime Data { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; }

        public Compra(DateTime data, string produto, decimal valor)
        {
            Data = data;
            Produto = produto;
            Valor = valor;
        }

        public override string ToString()
        {
            return "Data: " + Data.ToShortDateString() + ", Produto: " + Produto + ", Valor: " + Valor.ToString("C");
        }
    }

    class Program
    {
        static void Main()
        {
            RegistroDeCompras registro = new RegistroDeCompras();

            registro.AdicionarCompra(new DateTime(2023, 1, 15), "Notebook", 2500.00m);
            registro.AdicionarCompra(new DateTime(2023, 2, 20), "Smartphone", 1200.50m);

            registro.ListarCompras();
        }
    }


    //3 - Crie uma classe CorretoraDeImóveis com atributos para armazenar informações sobre imóveis (endereço, preço, tipo). Implemente um construtor e métodos para listar imóveis disponíveis e calcular o valor médio.
    //Crie um menu que contenha as opções de inserir imoveis, alterar preço do imovel e apresentar todos os imoveis. Insira os imoveis numa lista para facilitar o trabalho.

    class CorretoraDeImoveis
    {
        private List<Imovel> imoveis;

        public CorretoraDeImoveis()
        {
            imoveis = new List<Imovel>();
        }

        public void InserirImovel(string endereco, decimal preco, string tipo)
        {
            Imovel novoImovel = new Imovel(endereco, preco, tipo);
            imoveis.Add(novoImovel);
            Console.WriteLine("Imóvel adicionado com sucesso.");
        }

        public void AlterarPreco(string endereco, decimal novoPreco)
        {
            Imovel imovel = BuscarImovelPorEndereco(endereco);
            if (imovel != null)
            {
                imovel.Preco = novoPreco;
                Console.WriteLine("Preço do imóvel alterado com sucesso.");
            }
            else
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
        }

        public void ListarImoveis()
        {
            Console.WriteLine("Lista de Imóveis Disponíveis:");
            foreach (var imovel in imoveis)
            {
                Console.WriteLine(imovel.ToString());
            }

            if (imoveis.Count == 0)
            {
                Console.WriteLine("Nenhum imóvel disponível.");
            }
        }

        public decimal CalcularValorMedio()
        {
            if (imoveis.Count > 0)
            {
                decimal somaPrecos = 0;
                foreach (var imovel in imoveis)
                {
                    somaPrecos += imovel.Preco;
                }
                return somaPrecos / imoveis.Count;
            }
            else
            {
                return 0;
            }
        }

        private Imovel BuscarImovelPorEndereco(string endereco)
        {
            foreach (var imovel in imoveis)
            {
                if (imovel.Endereco.Equals(endereco, StringComparison.OrdinalIgnoreCase))
                {
                    return imovel;
                }
            }
            return null;
        }
    }

    class Imovel
    {
        public string Endereco { get; set; }
        public decimal Preco { get; set; }
        public string Tipo { get; set; }

        public Imovel(string endereco, decimal preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return "Endereço: " + Endereco + ", Tipo: " + Tipo + ", Preço: " + Preco.ToString("C");
        }
    }

    class Program
    {
        static void Main()
        {
            CorretoraDeImoveis corretora = new CorretoraDeImoveis();
            int opcao;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir Imóvel");
                Console.WriteLine("2. Alterar Preço do Imóvel");
                Console.WriteLine("3. Listar Todos os Imóveis");
                Console.WriteLine("4. Calcular Valor Médio dos Imóveis");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Informe o endereço do imóvel: ");
                            string endereco = Console.ReadLine();
                            Console.Write("Informe o preço do imóvel: ");
                            decimal preco = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Informe o tipo do imóvel: ");
                            string tipo = Console.ReadLine();
                            corretora.InserirImovel(endereco, preco, tipo);
                            break;

                        case 2:
                            Console.Write("Informe o endereço do imóvel: ");
                            string enderecoAlterarPreco = Console.ReadLine();
                            Console.Write("Informe o novo preço do imóvel: ");
                            decimal novoPreco = Convert.ToDecimal(Console.ReadLine());
                            corretora.AlterarPreco(enderecoAlterarPreco, novoPreco);
                            break;

                        case 3:
                            corretora.ListarImoveis();
                            break;

                        case 4:
                            decimal valorMedio = corretora.CalcularValorMedio();
                            Console.WriteLine("Valor médio dos imóveis: " + valorMedio.ToString("C"));
                            break;

                        case 0:
                            Console.WriteLine("Saindo do programa.");
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

            } while (opcao != 0);
        }
    }


    //4 - Crie uma classe AgendaTelefônica com atributos para armazenar contatos (nome, telefone, e-mail). Implemente um construtor e métodos para adicionar numa lista, remover e buscar contatos.

    class AgendaTelefonica
    {
        private List<Contato> contatos;

        public AgendaTelefonica()
        {
            contatos = new List<Contato>();
        }

        public void AdicionarContato(string nome, string telefone, string email)
        {
            Contato novoContato = new Contato(nome, telefone, email);
            contatos.Add(novoContato);
            Console.WriteLine("Contato adicionado com sucesso.");
        }

        public void RemoverContato(string nome)
        {
            Contato contato = BuscarContatoPorNome(nome);
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine("Contato removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        public void ListarContatos()
        {
            Console.WriteLine("Lista de Contatos:");
            foreach (var contato in contatos)
            {
                Console.WriteLine(contato.ToString());
            }

            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato na agenda.");
            }
        }

        public Contato BuscarContatoPorNome(string nome)
        {
            foreach (var contato in contatos)
            {
                if (contato.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    return contato;
                }
            }
            return null;
        }
    }

    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + ", Telefone: " + Telefone + ", E-mail: " + Email;
        }
    }

    class Program
    {
        static void Main()
        {
            AgendaTelefonica agenda = new AgendaTelefonica();
            int opcao;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar Contato");
                Console.WriteLine("2. Remover Contato");
                Console.WriteLine("3. Listar Contatos");
                Console.WriteLine("4. Buscar Contato por Nome");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Informe o nome do contato: ");
                            string nome = Console.ReadLine();
                            Console.Write("Informe o telefone do contato: ");
                            string telefone = Console.ReadLine();
                            Console.Write("Informe o e-mail do contato: ");
                            string email = Console.ReadLine();
                            agenda.AdicionarContato(nome, telefone, email);
                            break;

                        case 2:
                            Console.Write("Informe o nome do contato a ser removido: ");
                            string nomeRemover = Console.ReadLine();
                            agenda.RemoverContato(nomeRemover);
                            break;

                        case 3:
                            agenda.ListarContatos();
                            break;

                        case 4:
                            Console.Write("Informe o nome do contato a ser buscado: ");
                            string nomeBuscar = Console.ReadLine();
                            Contato contatoEncontrado = agenda.BuscarContatoPorNome(nomeBuscar);
                            if (contatoEncontrado != null)
                            {
                                Console.WriteLine("Contato encontrado: " + contatoEncontrado.ToString());
                            }
                            else
                            {
                                Console.WriteLine("Contato não encontrado.");
                            }
                            break;

                        case 0:
                            Console.WriteLine("Saindo do programa.");
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

            } while (opcao != 0);
        }
    }

    //5 - Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de tarefas (descrição, data de vencimento). Implemente um construtor e métodos para adicionar, remover e listar tarefas. Adicione um método para verificar se a tarefa deverá ser executada no dia de hoje. 

        class GerenciadorDeTarefas
    {
        private List<Tarefa> tarefas;

        public GerenciadorDeTarefas()
        {
            tarefas = new List<Tarefa>();
        }

        public void AdicionarTarefa(string descricao, DateTime dataVencimento)
        {
            Tarefa novaTarefa = new Tarefa(descricao, dataVencimento);
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada com sucesso.");
        }

        public void RemoverTarefa(string descricao)
        {
            Tarefa tarefa = BuscarTarefaPorDescricao(descricao);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        public void ListarTarefas()
        {
            Console.WriteLine("Lista de Tarefas:");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine(tarefa.ToString());
            }

            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa na lista.");
            }
        }

        public bool TarefaDeveSerExecutadaHoje(Tarefa tarefa)
        {
            DateTime hoje = DateTime.Today;
            return tarefa.DataVencimento.Date == hoje;
        }

        public void ListarTarefasParaHoje()
        {
            Console.WriteLine("Tarefas para hoje:");
            foreach (var tarefa in tarefas)
            {
                if (TarefaDeveSerExecutadaHoje(tarefa))
                {
                    Console.WriteLine(tarefa.ToString());
                }
            }

            if (tarefas.Count == 0 || tarefas.TrueForAll(t => !TarefaDeveSerExecutadaHoje(t)))
            {
                Console.WriteLine("Nenhuma tarefa para hoje.");
            }
        }

        private Tarefa BuscarTarefaPorDescricao(string descricao)
        {
            foreach (var tarefa in tarefas)
            {
                if (tarefa.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase))
                {
                    return tarefa;
                }
            }
            return null;
        }
    }

    class Tarefa
    {
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }

        public Tarefa(string descricao, DateTime dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }

        public override string ToString()
        {
            return "Descrição: " + Descricao + ", Data de Vencimento: " + DataVencimento.ToShortDateString();
        }
    }

    class Program
    {
        static void Main()
        {
            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();
            int opcao;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Remover Tarefa");
                Console.WriteLine("3. Listar Tarefas");
                Console.WriteLine("4. Listar Tarefas para Hoje");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Informe a descrição da tarefa: ");
                            string descricao = Console.ReadLine();
                            Console.Write("Informe a data de vencimento da tarefa (formato dd/mm/yyyy): ");
                            DateTime dataVencimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                            gerenciador.AdicionarTarefa(descricao, dataVencimento);
                            break;

                        case 2:
                            Console.Write("Informe a descrição da tarefa a ser removida: ");
                            string descricaoRemover = Console.ReadLine();
                            gerenciador.RemoverTarefa(descricaoRemover);
                            break;

                        case 3:
                            gerenciador.ListarTarefas();
                            break;

                        case 4:
                            gerenciador.ListarTarefasParaHoje();
                            break;

                        case 0:
                            Console.WriteLine("Saindo do programa.");
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

            } while (opcao != 0);
        }
    }


    //6 - Utilize o exercício 1 para criar uma lista de produtos e faça métodos para apresentar na tela e para consultar produtos pelo código. 

    class Program
    {
        static void Main()
        {
            List<Produto> listaDeProdutos = new List<Produto>();

            
            listaDeProdutos.Add(new Produto(1, "Notebook", 2500.00m, 10));
            listaDeProdutos.Add(new Produto(2, "Smartphone", 1200.50m, 15));
            listaDeProdutos.Add(new Produto(3, "Tablet", 800.00m, 20));

            
            ApresentarProdutos(listaDeProdutos);

            Console.Write("Digite o código do produto para consultar: ");
            int codigoConsulta = int.Parse(Console.ReadLine());

            Produto produtoConsultado = ConsultarProdutoPorCodigo(listaDeProdutos, codigoConsulta);

            if (produtoConsultado != null)
            {
                Console.WriteLine("\nProduto Consultado:\n" + produtoConsultado.ToString());
            }
            else
            {
                Console.WriteLine("\nProduto não encontrado.");
            }
        }

        static void ApresentarProdutos(List<Produto> produtos)
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.ToString());
            }
        }

        static Produto ConsultarProdutoPorCodigo(List<Produto> produtos, int codigo)
        {
            foreach (Produto produto in produtos)
            {
                if (produto.Codigo == codigo)
                {
                    return produto;
                }
            }
            return null;
        }
    }

    class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto(int codigo, string nome, decimal preco, int quantidadeEstoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public override string ToString()
        {
            return "Código: " + Codigo + ", Nome: " + Nome + ", Preço: " + Preco.ToString("C") + ", Estoque: " + QuantidadeEstoque;
        }
    }


    //7 - Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora. Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e uma string para armazenar o dono da playlist. Implemente um método para adicionar músicas na lista, para "tocar a música" (só mostrar uma mensagem na tela com o titulo da música). Tente fazer uma reprodução aleatória, ou seja, em vez de percorrer do inicio ao fim da lista, faça um random para acessar valores aleatórios válidos.

    
    class Program
    {
        static void Main()
        {
            Playlist minhaPlaylist = new Playlist("Minha Playlist");

            minhaPlaylist.AdicionarMusica(new Musica("Música 1", "Autor 1", "Gravadora 1"));
            minhaPlaylist.AdicionarMusica(new Musica("Música 2", "Autor 2", "Gravadora 2"));
            minhaPlaylist.AdicionarMusica(new Musica("Música 3", "Autor 3", "Gravadora 3"));

            Console.WriteLine("Playlist: " + minhaPlaylist.Nome);
            minhaPlaylist.TocarMusicaAleatoria();
            minhaPlaylist.TocarMusicaAleatoria();
            minhaPlaylist.TocarMusicaAleatoria();
        }
    }

    class Musica
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Gravadora { get; set; }

        public Musica(string nome, string autor, string gravadora)
        {
            Nome = nome;
            Autor = autor;
            Gravadora = gravadora;
        }
    }

    class Playlist
    {
        private List<Musica> listaDeMusicas;
        public string Nome { get; set; }

        public Playlist(string nome)
        {
            Nome = nome;
            listaDeMusicas = new List<Musica>();
        }

        public void AdicionarMusica(Musica musica)
        {
            listaDeMusicas.Add(musica);
            Console.WriteLine("Música '" + musica.Nome + "' adicionada à playlist '" + Nome + "'.");
        }

        public void TocarMusicaAleatoria()
        {
            if (listaDeMusicas.Count == 0)
            {
                Console.WriteLine("Playlist '" + Nome + "' está vazia.");
                return;
            }

            Random random = new Random();
            int indiceAleatorio = random.Next(0, listaDeMusicas.Count);

            Musica musicaTocada = listaDeMusicas[indiceAleatorio];
            Console.WriteLine("Tocando a música: " + musicaTocada.Nome);
        }
    }


    //8 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade.  Produto que tenha as propriedades Nome, Fabricante (objeto da classe Fabricante) e Preco. Utilize o encapsulamento para garantir que o nome não seja vazio e que o preço seja positivo. 

    class Fabricante
    {
        private string nome;
        private string endereco;
        private string cidade;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do fabricante não pode ser vazio ou nulo.");
                }
                nome = value;
            }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
    }

    class Produto
    {
        private string nome;
        private Fabricante fabricante;
        private decimal preco;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.");
                }
                nome = value;
            }
        }

        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O preço do produto não pode ser negativo.");
                }
                preco = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Fabricante fabricante = new Fabricante();
                fabricante.Nome = "Empresa XYZ";
                fabricante.Endereco = "Rua ABC, 123";
                fabricante.Cidade = "Cidade A";

                Produto produto = new Produto();
                produto.Nome = "Produto 1";
                produto.Fabricante = fabricante;
                produto.Preco = 29.99m;

                Console.WriteLine("Produto: " + produto.Nome + ", Fabricante: " + produto.Fabricante.Nome + ", Preço: " + produto.Preco.ToString("C"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }


    //9 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor. Utilize o encapsulamento  para garantir que o título e o autor não sejam vazios.

    class Livro
    {
        private string titulo;
        private string autor;

        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O título do livro não pode ser vazio ou nulo.");
                }
                titulo = value;
            }
        }

        public string Autor
        {
            get { return autor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O autor do livro não pode ser vazio ou nulo.");
                }
                autor = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Livro livro = new Livro();
                livro.Titulo = "Aventuras Fantásticas";
                livro.Autor = "Autor Desconhecido";

                Console.WriteLine("Livro: " + livro.Titulo + ", Autor: " + livro.Autor);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }


    //10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado EmitirSom, que imprime na tela o som do animal.

   class Animal
    {
        private string nome;
        private string especie;
        private int idade;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public void EmitirSom()
        {
            Console.WriteLine("O " + Especie + " " + Nome + " emite um som.");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal gato = new Animal();
            gato.Nome = "Bichano";
            gato.Especie = "Gato";
            gato.Idade = 3;

            Animal cachorro = new Animal();
            cachorro.Nome = "Rex";
            cachorro.Especie = "Cachorro";
            cachorro.Idade = 5;

            gato.EmitirSom();
            cachorro.EmitirSom();
        }
    }


    //11 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um método para acelerar o carro (aumentando a velocidade em 10) e outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a  velocidade negativa).
      class Carro
      {
        private string modelo;
        private int ano;
        private int velocidade;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public int Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }

        public void Acelerar()
        {
            velocidade += 10;
        }

        public void Frear()
        {
            velocidade = Math.Max(0, velocidade - 10);
        }
    }

    class Program
    {
        static void Main()
        {
            Carro meuCarro = new Carro();
            meuCarro.Modelo = "Fusca";
            meuCarro.Ano = 2022;
            meuCarro.Velocidade = 0;

            Console.WriteLine("Carro: " + meuCarro.Modelo + ", Ano: " + meuCarro.Ano + ", Velocidade: " + meuCarro.Velocidade + " km/h");

            meuCarro.Acelerar();
            Console.WriteLine("Acelerando... Velocidade: " + meuCarro.Velocidade + " km/h");

            meuCarro.Frear();
            Console.WriteLine("Freando... Velocidade: " + meuCarro.Velocidade + " km/h");
        }
    }


    //12 - Crie uma classe Agenda que pode armazenar inúmeras pessoas e que seja capaz de realizar as seguintes operações:
    //void armazenaPessoa(String nome, int idade, float altura);
    //void removePessoa(String nome);
    //Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
    //void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
    //Faça um menu para navegar entre as opções infinitamente.


class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }
    }

    class Agenda
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = nome,
                Idade = idade,
                Altura = altura
            };

            pessoas.Add(pessoa);
            Console.WriteLine("Pessoa adicionada à agenda.");
        }

        public void RemovePessoa(string nome)
        {
            Pessoa pessoa = BuscaPessoa(nome);
            if (pessoa != null)
            {
                pessoas.Remove(pessoa);
                Console.WriteLine("Pessoa removida da agenda.");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada na agenda.");
            }
        }

        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome == nome);
        }

        public void ImprimeAgenda()
        {
            Console.WriteLine("\nAgenda:");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine("Nome: " + pessoa.Nome + ", Idade: " + pessoa.Idade + ", Altura: " + pessoa.Altura + "m");
            }

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Adicionar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("5. Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite a idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Digite a altura (em metros): ");
                        float altura = float.Parse(Console.ReadLine());

                        agenda.ArmazenaPessoa(nome, idade, altura);
                        break;
                    case 2:
                        Console.Write("Digite o nome da pessoa a ser removida: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemovePessoa(nomeRemover);
                        break;
                    case 3:
                        Console.Write("Digite o nome da pessoa a ser buscada: ");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaEncontrada = agenda.BuscaPessoa(nomeBuscar);

                        if (pessoaEncontrada != null)
                        {
                            Console.WriteLine("Pessoa encontrada: Nome: " + pessoaEncontrada.Nome + ", Idade: " + pessoaEncontrada.Idade + ", Altura: " + pessoaEncontrada.Altura + "m");
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda.");
                        }
                        break;
                    case 4:
                        agenda.ImprimeAgenda();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }


    //FIM DOS EXERCÍCIOS SEQUÊNCIAIS
}
}
}