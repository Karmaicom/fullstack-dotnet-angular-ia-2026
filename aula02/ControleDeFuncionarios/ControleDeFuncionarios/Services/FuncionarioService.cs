using ControleDeFuncionarios.Entities;
using System.Text.Json;
using System.Xml.Serialization;

namespace ControleDeFuncionarios.Services
{
    /// <summary>
    /// Classe de serviço para realizar operações de gravação
    /// de dados de funcionário em arquivo
    /// </summary>
    public class FuncionarioService
    {
        /// <summary>
        /// Método para exportar dados de funcionário
        /// em arquivo XML
        /// </summary>
        public void ExportarDadosParaXml(Funcionario funcionario)
        {
            // Configurando a biblioteca XmlSerializer para gravar funcionário
            var xmlSerializer = new XmlSerializer(typeof(Funcionario));

            // Criando um StreamWriter para escrever o arquivo XML
            var streamWriter = new StreamWriter("c:\\temp\\funcionario" + funcionario.Id + ".xml");

            // Escrever o conteúdo XML dentro do arquivo
            xmlSerializer.Serialize(streamWriter, funcionario);

            // Fechando o arquivo após a escrita
            streamWriter.Close();
        }

        /// <summary>
        /// Método para exportar dados de funcionário
        /// em arquivo JSON
        /// </summary>
        public void ExportarDadosParaJson(Funcionario funcionario)
        {
            //Serializar os dados do funcionário para formato JSON
            var jsonSerializer = JsonSerializer.Serialize(funcionario);

            //Criando arquivo JSON
            var streamWriter = new StreamWriter("c:\\temp\\funcionario" + funcionario.Id + ".json");

            //Escrever conteúdo JSON dentro do arquivo
            streamWriter.Write(jsonSerializer);

            //Fecnahdo o arquivo após a escrita
            streamWriter.Close();
        }

    }
}
