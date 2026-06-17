using CrudProdutos.Entities;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CrudProdutos.Repositories
{
    public class ProdutoRepository
    {
        private string connectionString = @"Data Source=localhost,1433;Initial Catalog=bd_produtos;User ID=sa;Password=Coti@2026;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";

        public void Inserir(Produto produto)
        {
            var query =
                    @"insert into produto(id, nome, preco, quantidade, datahoracadastro)
                    values(@Id, @Nome, @Preco, @Quantidade, @DataHoraCadastro)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, produto);
            }                
        }

        public List<Produto> Consultar()
        {
            try
            {
                var query = @"select id, nome, preco, quantidade, datahoracadastro 
                                from produto
                                order by nome";

                using (var connection = new SqlConnection(connectionString))
                {
                    return connection.Query<Produto>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }            
        }

        public Produto? ObterPorId(Guid id)
        {
            var query = @"select id, nome, preco, quantidade, datahoracadastro 
                            from produto
                            where id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Produto>(query, new { @Id = id }).FirstOrDefault();
            }
        }

        public void Alterar(Produto produto)
        {
            var query = @"update produto set nome = @Nome, preco = @Preco, quantidade = @Quantidade
                            where id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, produto);
            }
        }

        public void Excluir(Guid id)
        {
            var query = @"delete from produto where id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, new { @Id = id});
            }
        }

    }
}
