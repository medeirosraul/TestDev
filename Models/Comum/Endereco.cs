using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestDev.Models.Comum
{
    public class Endereco
    {
        [Required(ErrorMessage = "O CEP é de preenchimento obrigatório.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O Logradouro é de preenchimento obrigatório.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O Número é de preenchimento obrigatório.")]
        [DisplayName("Número")]
        [DataType(DataType.Text)]
        public int? Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O Bairro é de preenchimento obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "A Cidade é de preenchimento obrigatório.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O UF é de preenchimento obrigatório.")]
        [MaxLength(8, ErrorMessage = "Máximo de 8 caracteres.")]
        public string UF { get; set; }

        public override string ToString()
        {
            var complemento = string.IsNullOrWhiteSpace(Complemento) ? "" : $" ({Complemento})";
            return $"{CEP} - {Logradouro}, {Numero}{complemento}, {Bairro}, {Cidade} - {UF}";
        }
    }
}
