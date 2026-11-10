using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameVault.Models
{
    public class Videojuego
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El titulo del videojuego es obligatorio.")]
        [StringLength(100, ErrorMessage = "El titulo no puede exceder los 100 caracteres.")]
        [Display(Name = "Titulo del videojuego")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El genero del videojuego es obligatorio.")]
        [Display(Name = "Genero del videojuego")]
        public string Genero { get; set; } = string.Empty;

        [Required(ErrorMessage = "La plataforma del videojuego es obligatorio.")]
        [Display(Name = "Plataforma del videojuego")]
        public string Plataforma { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe indicar el precio del videojuego.")]
        [Range(0,150000,ErrorMessage = "El precio debe estar entre $0 y $150.000 CLP")]
        [Display(Name = "Precio CLP")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Debe indicar la fecha de lanzamiento del videojuego.")]
        [Range(1980, 2030, ErrorMessage = "El año debe estar entre 1980 y 2030")]
        [Display(Name = "Año de lanzamiento")]
        public int AnioLanzamiento { get; set; }

        public Videojuego(){ }
        public Videojuego( int id, string titulo, string genero, string plataforma, double precio, int anioLanzamiento)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Genero = genero;
            this.Plataforma = plataforma;
            this.Precio = precio;
            this.AnioLanzamiento = anioLanzamiento;
        }
    }
}
