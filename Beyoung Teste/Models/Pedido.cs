using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Beyoung_Teste.Models
{
    public class Pedido
    {
        [Key]
        [Required]
        public int IdPedido { get; set; }
        [Required(ErrorMessage = "O campo de frete é obrigatório")]
        public double Frete { get; set; }
        [Required(ErrorMessage = "O campo de valor total é obrigatório")]
        public double Total { get; set; }

        [Required(ErrorMessage = "O objeto Cliente é obrigatório")]
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "A lista de itens é obrigatório")]
        public IEnumerable<Item> Itens{ get; set; }
    }
}
