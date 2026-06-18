using EFClientes.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFClientes.Entities
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateOnly DataNascimento { get; set; }
        public string NumeroDocumento { get; set; } = string.Empty;
        public TipoDocumento TipoDocumento { get; set; }
        public Status Status { get; set; } = Status.ATIVO;


    }
}
