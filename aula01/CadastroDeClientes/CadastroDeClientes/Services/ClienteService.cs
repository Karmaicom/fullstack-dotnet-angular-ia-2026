using CadastroDeClientes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDeClientes.Services
{
    public class ClienteService
    {

        /* Metodo para receber um objeto do tipo cliente e expostar os dados
         * gravando em um arquivo e extensão .TXT na máquina do usuário
         */
        public void ExportarDados(Cliente cliente)
        {

            // Criando ou abrindo um arquivo na máquina local
            var streamwriter = new StreamWriter("c:\\temp\\cliente_"+cliente.Id+".txt");

            // Escrevendo os dados do cliente no arquivo
            streamwriter.WriteLine($"Id: {cliente.Id}");
            streamwriter.WriteLine($"Nome: {cliente.Nome}");
            streamwriter.WriteLine($"Email: {cliente.Email}");
            streamwriter.WriteLine($"Cpf: {cliente.Cpf}");
            streamwriter.WriteLine($"Telefone: {cliente.Telefone}");
            streamwriter.WriteLine($"Data e Hora do Cadastro: {cliente.DataHoraCadastro}");
            streamwriter.WriteLine("--------------------------------------------------");

            // Fechando o arquivo para garantir que os dados sejam salvos corretamente
            streamwriter.Close();

        }

    }
}
