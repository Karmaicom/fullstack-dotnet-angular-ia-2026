using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeFuncionarios.Entities
{
    public class Empresa
    {

        #region Propriedades

        public Guid Id { get; set; } = Guid.NewGuid();
        public string RazaoSocial { get; set; } = string.Empty;
        public string Cnpj { get; set; } = string.Empty;


        #endregion

    }
}
