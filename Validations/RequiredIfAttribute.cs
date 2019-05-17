using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestDev.Validations
{
    public class RequiredIfAttribute:ValidationAttribute
    {
        private string _propriedade;
        private object _valorCondicao;
        private string _mensagem;

        public RequiredIfAttribute(string propriedade, object valorCondicao, string mensagem)
        {
            _propriedade = propriedade;
            _valorCondicao = valorCondicao;
            _mensagem = mensagem;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            object modelo = validationContext.ObjectInstance;
            string valorPropriedade = modelo.GetType()
                .GetProperty(_propriedade)
                .GetValue(modelo)
                .ToString();

            if (_valorCondicao.ToString() == valorPropriedade && string.IsNullOrWhiteSpace(value?.ToString()))
                return new ValidationResult(_mensagem);

            return ValidationResult.Success;
        }
    }
}
