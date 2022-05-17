using System.ComponentModel.DataAnnotations;

namespace StarterPlataform.Models.DTO
{
    public class CategoriaDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o nome da Categoria")]
        [MinLength(2, ErrorMessage = "Utilize pelo menos 2 caracteres")]
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}