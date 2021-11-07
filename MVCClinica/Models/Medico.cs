using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCClinica.Models
{
    [Table("Medico")]
    public class Medico
    {


        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Required]
        [Key]
        [Column(Order = 2)]
        [Range(5, 10, ErrorMessage = "The field Matricula must be between 5 and 10")]
        public string Matricula { get; set; }
        [Required]
        [StringLength(50)]
        public string Especialidad { get; set; }

    }
}