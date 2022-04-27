using System.ComponentModel.DataAnnotations;

namespace Beyoung_Teste.Models
{
    public class Item
    {
        [Key]
        [Required]
        public int IdItem { get; set; }
        [Required(ErrorMessage = "O campo de SKU é obrigatório")]
        public int SKU { get; set; }
        [Required(ErrorMessage = "O campo de descrição é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo de valor do item é obrigatório")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "O campo de quantidade de itens é obrigatório")]
        public int Quantidade { get; set; }

    }
}
