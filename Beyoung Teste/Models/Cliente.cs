using System.ComponentModel.DataAnnotations;

namespace Beyoung_Teste.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O campo de email é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo de CPF é obrigatório")]
        [RegularExpression(@"^([0-9][0-9][0-9]).([0-9][0-9][0-9]).([0-9][0-9][0-9])-([0-9][0-9])$", ErrorMessage = "Formato de CPF inválido")]
        //[StringLength(11, MinimumLength = 11, ErrorMessage = "CPF no formato inválido")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O campo de CEP é obrigatório")]
        [RegularExpression(@"^([0-9][0-9][0-9][0-9][0-9])-([0-9][0-9][0-9])$", ErrorMessage = "Formato de CEP inválido")]
        public string CEP { get; set; }
    }
}