using System.ComponentModel.DataAnnotations;

namespace lista4.Models
{
    public class NovoPessoa
    {
        [Required(ErrorMessage = "Obrigatório")]
        [MaxLength(10, ErrorMessage = "Maximo 10 letras ")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public string Cf { get; set; }
        [Required(ErrorMessage = "Obrigatório")]

        public float Peso { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public float Altura { get; set; }
        [Required(ErrorMessage = "Altura inválida")]

    }
}
