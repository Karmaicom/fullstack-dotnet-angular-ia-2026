using CrudProdutos.Entities;
using CrudProdutos.Repositories;

namespace CrudProdutos.Controllers
{
    /// <summary>
    /// Controlador para implementar os fluxos de entrada de dados
    /// do usuário para cadastrar, alterar, consultar e excluir produtos.
    /// </summary>
    public class ProdutoController
    {

        public void GerenciarProdutos()
        {
            Console.WriteLine("Sistema de Controle de Produtos:\n");
            Console.WriteLine("\t(1) Cadastrar Produto");
            Console.WriteLine("\t(2) Atualizar Produto");
            Console.WriteLine("\t(3) Excluir Produto");
            Console.WriteLine("\t(4) Consultar Produtos");
            Console.WriteLine("\t(0) Sair");

            Console.Write("Informe a opção desejada:");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Cadastrar();
                    break;
                case "2":
                    Atualizar();
                    break;
                case "3":
                    Excluir();
                    break;
                case "4":
                    Consultar();
                    break;
                case "0":
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\n\nDeseja executar outra operação? (S/N)");
            var resposta = Console.ReadLine();
            if (resposta?.ToUpper() == "S")
            {
                GerenciarProdutos();
            }
            else
            {
                Console.WriteLine("\nFim do programa!");
            }

        }

        public void Cadastrar()
        {
            Console.WriteLine("\nCadastro de Produto:\n");

            var produto = new Produto();

            Console.Write("Nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            var repository = new ProdutoRepository();
            repository.Inserir(produto);

            Console.WriteLine("\nProduto cadastrado com sucesso!");
        }

        public void Atualizar()
        {
            var repository = new ProdutoRepository();

            Console.WriteLine("\nAtualização de Produto:\n");
            Console.Write("Informe o ID do produto a ser atualizado: ");
            var id = Guid.Parse(Console.ReadLine());

            var produto = repository.ObterPorId(id);

            if (produto == null)
            {
                Console.WriteLine("Produto não encontrado.");
                return;
            }

            Console.Write($"Nome do produto ({produto.Nome}): ");
            var nome = Console.ReadLine();
            if (!string.IsNullOrEmpty(nome))
                produto.Nome = nome;

            Console.Write($"Preço ({produto.Preco}): ");
            var precoInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(precoInput))
                produto.Preco = decimal.Parse(precoInput);

            Console.Write($"Quantidade ({produto.Quantidade}): ");
            var quantidadeInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(quantidadeInput))
                produto.Quantidade = int.Parse(quantidadeInput);

            repository.Alterar(produto);

            Console.WriteLine("\nProduto atualizado com sucesso!");
        }

        public void Excluir()
        {
            var repository = new ProdutoRepository();

            Console.WriteLine("\nExclusão de Produto:\n");
            Console.Write("Informe o ID do produto a ser excluído: ");
            var id = Guid.Parse(Console.ReadLine());

            var produto = repository.ObterPorId(id);

            if (produto == null)
            {
                Console.WriteLine("Produto não encontrado.");
                return;
            }

            repository.Excluir(id);

            Console.WriteLine("\nProduto excluído com sucesso!");
        }

        public void Consultar()
        {
            var repository = new ProdutoRepository();
            Console.WriteLine("\nConsulta de Produtos:\n");

            var produtos = repository.Consultar();

            if (produtos == null || produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto encontrado.");
                return;
            }
            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.Id}");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Preço: {produto.Preco:C}");
                Console.WriteLine($"Quantidade: {produto.Quantidade}");
                Console.WriteLine($"Data/Hora Cadastro: {produto.DataHoraCadastro}");
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
