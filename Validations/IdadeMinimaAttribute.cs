using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestDev.Validations
{
    public class IdadeMinimaAttribute:ValidationAttribute
    {
        private int _idadeMinima;
        private string _mensagem;

        public IdadeMinimaAttribute(int idadeMinima, string mensagem)
        {
            _idadeMinima = idadeMinima;
            _mensagem = mensagem;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var nascimento = Convert.ToDateTime(value);
            var idadeAtual = (DateTime.Today - nascimento).TotalDays / 365.2425;

            if (idadeAtual < _idadeMinima)
                return new ValidationResult(_mensagem);

            return ValidationResult.Success;
        }
    }
}
