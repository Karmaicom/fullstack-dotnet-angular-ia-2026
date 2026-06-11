using CadastroDeClientes.Entities;
using CadastroDeClientes.Services;

namespace CadastroDeClientes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nSeja bem vindo ao sistema de cadastro de clientes!\n");
            Console.WriteLine("\tPreencha os campos abaixo para cadastrar o cliente:\n");

            // Instaciando um objeto do tipo Clinte
            var cliente = new Cliente();

            // Atribuindo valores aos atributos do objeto cliente
            Console.Write("Nome............: ");
            cliente.Nome = Console.ReadLine() ?? string.Empty;

            Console.Write("Email...........: ");
            cliente.Email = Console.ReadLine() ?? string.Empty;

            Console.Write("CPF.............: ");
            cliente.Cpf = Console.ReadLine() ?? string.Empty;

            Console.Write("Telefone........: ");
            cliente.Telefone = Console.ReadLine() ?? string.Empty;

            // Imprimindo os dados do cliente cadastrado
            Console.WriteLine("\nDados do Cliente:\n");
            Console.WriteLine("\tID...........................: " + cliente.Id);
            Console.WriteLine("\tNome.........................: " + cliente.Nome);
            Console.WriteLine("\tEmail........................: " + cliente.Email);
            Console.WriteLine("\tCPF..........................: " + cliente.Cpf);
            Console.WriteLine("\tTelefone.....................: " + cliente.Telefone);
            Console.WriteLine("\tData e hora do cadastro......: " + cliente.DataHoraCadastro);

            var service = new ClienteService();
            service.ExportarDados(cliente);
        }
    }
}
