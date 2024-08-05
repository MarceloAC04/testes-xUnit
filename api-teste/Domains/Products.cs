using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_teste.Domains
{
    [Table("Produtos")]
    public class Products
    {
        [Key]
        public Guid IdProduct { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome do produto é obrigatório")]
        public string Name { get; set; }

        [Column(TypeName = "Decimal(4,2)")]
        [Required(ErrorMessage = "O Preço do jogo é obrigatório")]
        public decimal Price { get; set; }
    }
}
