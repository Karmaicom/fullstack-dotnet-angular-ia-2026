namespace ControleDeFuncionarios.Entities
{
    /// <summary>
    /// Modelo de dados para representar uma pessoa.
    /// </summary>
    public class Pessoa
    {

        #region Propriedades

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;

        #endregion

    }
}
