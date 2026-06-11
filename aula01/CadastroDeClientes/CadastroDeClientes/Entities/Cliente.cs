using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDeClientes.Entities
{
    public class Cliente
    {
        
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public DateTime DataHoraCadastro { get; set; } = DateTime.Now;

    }
}
