using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TestDev.Models.Comum;
using TestDev.Validations;

// https://stackoverflow.com/questions/52321148/conditional-validation-in-mvc-net-core-requiredif
// https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-2.1#custom-attributes

namespace TestDev.Models.Clientes
{
    public class Cliente
    {
        public string Id { get; set; }

        [DisplayName("Selecione")]
        public ClienteTipo Tipo { get; set; }

        #region Pessoa física

        [RequiredIf("Tipo", ClienteTipo.PessoaFisica, "O CPF do cliente é obrigatório.")]
        public string CPF { get; set; }

        [RequiredIf("Tipo", ClienteTipo.PessoaFisica, "A data de nascimento do cliente é obrigatória.")]
        [IdadeMinima(19, "O cliente deve ter no mínimo 19 anos.")]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Text)]
        public DateTime? DataNascimento { get; set; }

        [RequiredIf("Tipo", ClienteTipo.PessoaFisica, "O nome do cliente é obrigatório.")]
        public string Nome { get; set; }

        [RequiredIf("Tipo", ClienteTipo.PessoaFisica, "O sobrenome do cliente é obrigatório.")]
        public string Sobrenome { get; set; }

        #endregion

        #region Pessoa jurídica

        [RequiredIf("Tipo", ClienteTipo.PessoaJuridica, "O CNPJ do cliente é obrigatório.")]
        public string CNPJ { get; set; }

        [RequiredIf("Tipo", ClienteTipo.PessoaJuridica, "A Razão Social do cliente é obrigatória.")]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [RequiredIf("Tipo", ClienteTipo.PessoaJuridica, "O Nome Fantasia do cliente é obrigatório.")]
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }

        #endregion

        public Endereco Endereco { get; set; }
    }
}
