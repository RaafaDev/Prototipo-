using System.ComponentModel.DataAnnotations;
namespace CrudContratos.Models
{
    public class Contratos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre del Contrato")]
        public string Nombre { get; set; }

        [Display(Name = "Fecha de Inicio")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "Fecha de Fin")]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }
    }
}
