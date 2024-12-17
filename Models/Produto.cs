using System.ComponentModel.DataAnnotations;

namespace ProdutosAPI.Models
{
    public class Produto
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório")]
        public string Name { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Preço precisa ser maior que {1}")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Estoque precisa ser maior que {1}")]
        public int StockQuantity { get; set; }
    }

}
