using CrudProdutos.Controllers;
using CrudProdutos.Repositories;

namespace CrudProdutos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var controller = new ProdutoController();
            controller.GerenciarProdutos();

        }
    }
}
