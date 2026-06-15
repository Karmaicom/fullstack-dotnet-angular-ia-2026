using ControleDeFuncionarios.Entities;
using ControleDeFuncionarios.Enums;
using ControleDeFuncionarios.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeFuncionarios.Controllers
{
    /// <summary>
    /// Classe controlador para implementar um fluxo de entrada de dados para cadastro de funcionário.
    /// </summary>
    public class FuncionarioController
    {

        /// <summary>
        /// Método para executar o cadastro de um funcionário
        /// </summary>
        public void cadastrarFuncionario()
        {
            Console.WriteLine("\nCADASTRO DE FUNCIONÁRIO\n");

            //Criando um objeto do tipo funcionaário
            var funcionario = new Funcionario();

            Console.Write("Informe o nome do funcionario...........: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("CPF.....................................: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("Matricula...............................: ");
            funcionario.Matricula = Console.ReadLine();
            
            Console.Write("Data de Admissão (dd/MM/yyyy)...........: ");
            funcionario.DataAdmissao = DateOnly.Parse(Console.ReadLine());

            Console.Write("Salário.................................: ");
            funcionario.Salario = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a razão social da empresa.......: ");
            funcionario.Empresa.RazaoSocial = Console.ReadLine();

            Console.Write("Informe o cnpj da empresa...............: ");
            funcionario.Empresa.Cnpj = Console.ReadLine();

            Console.WriteLine("\t(1) Jovem Aprendiz");
            Console.WriteLine("\t(2) Estagiário");
            Console.WriteLine("\t(3) CLT");
            Console.WriteLine("\t(3) Terceirizado");
            Console.WriteLine("\t(3) Prestador de Serviço");

            Console.Write("Informe o tipo de contratação..: ");
            funcionario.TipoContratacao = (TipoContratacao) int.Parse(Console.ReadLine());

            //Exportando dados para XML e JSON
            var service = new FuncionarioService();
            service.ExportarDadosParaXml(funcionario);
            service.ExportarDadosParaJson(funcionario);

            Console.WriteLine("Dados gravados com sucesso!");
        }

    }
}
