using System.ComponentModel.DataAnnotations;

namespace SalesCet97.web.Data.Entities
{
    public class Country
    {
        //[Key]
        public int Id { get; set; }


        [Display( Name = "Pais" )]
        [MaxLength(50,ErrorMessage = "O campo {0} deve ter no maximo {1} caracteres")]
        [Required(ErrorMessage = "o campo {0} é obrigatório!")]
        public string? Name { get; set; }
    }
}
