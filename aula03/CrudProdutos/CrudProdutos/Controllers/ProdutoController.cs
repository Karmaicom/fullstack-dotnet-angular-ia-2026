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


    }
}
