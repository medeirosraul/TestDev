using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TestDev.Models.Clientes
{
    public enum ClienteTipo
    {
        [Description("Pessoa Física")]
        PessoaFisica,

        [Description("Pessoa Jurídica")]
        PessoaJuridica
    }
}
