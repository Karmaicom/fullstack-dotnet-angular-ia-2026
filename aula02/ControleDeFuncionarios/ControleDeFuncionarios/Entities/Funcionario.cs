using ControleDeFuncionarios.Enums;

namespace ControleDeFuncionarios.Entities
{
    /// <summary>
    /// Modelo de dados para representar um funcionário
    /// </summary>
    public class Funcionario : Pessoa
    {

        #region Propriedades

        public string Matricula { get; set; } = string.Empty;
        public DateOnly DataAdmissao { get; set; }
        public decimal Salario { get; set; } = decimal.Zero;
        public Empresa Empresa { get; set; } = new();
        public TipoContratacao TipoContratacao { get; set; }

        #endregion

    }
}
