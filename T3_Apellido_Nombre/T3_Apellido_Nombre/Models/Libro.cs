using System.ComponentModel.DataAnnotations;

namespace T3_Apellido_Nombre.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El titulo es necesario")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El autor es necesario")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "El tema es necesario")]
        public string Tema { get; set; }
        [Required(ErrorMessage = "La Editorial es necesario")]
        public string Editorial { get; set; }
        [Range(1900,3000,ErrorMessage ="El rango de publiacion es de 1900 a 3000")]
        public int AnioPublicacion { get; set; }
        [Range(10, 1000, ErrorMessage = "El rango de paginas es de 10 a 1000")]
        public int Paginas { get; set; }
        [Required(ErrorMessage = "La categoria es necesario")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "El material es necesario")]
        public string Material { get; set; }
        [Range(10, 1000, ErrorMessage = "El rango de copias es de 1 a 20")]
        public int Copias { get; set; }

    }
}
