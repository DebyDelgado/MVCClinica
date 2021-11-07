using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCClinica.Models
{
    public class Clinica
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [RegularExpression(@"^\d{4}(\-|\/|\.)\d{1,2}\1\d{1,2}$", ErrorMessage = "Ingrese formato de fecha válido")]
        public string FechaNacimiento { get; set; }
        [Required]
        public string Domicilio { get; set; }

}
}