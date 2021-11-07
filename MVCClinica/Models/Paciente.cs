using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCClinica.Models
{
    [Table("Paciente")]
    public class Paciente
    {

        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }
        [Required]
       
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Domicilio { get; set; }
        [Required]
        [Key]
        [Column(Order = 2)]
        [Range(5, 10, ErrorMessage = "The field HistoriaClinica must be between 5 and 10")]
        public int NroHistoriaClinica { get; set; }
        [Required]
        [RegularExpression(@"^\d{4}(\-|\/|\.)\d{1,2}\1\d{1,2}$", ErrorMessage = "Ingrese formato de fecha válido")]
        public string FechaNacimiento { get; set; }
      

    }
}