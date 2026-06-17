using System;
using System.Collections.Generic;
using System.Text;

namespace CrudProdutos.Entities
{
    /// <summary>
    /// Modelo de entidade para produto
    /// </summary>
    public class Produto
    {
        #region Atributos

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; } = decimal.Zero;
        public int Quantidade { get; set; }
        public DateTime DataHoraCadastro { get; set; } = DateTime.Now;

        #endregion

    }
}
