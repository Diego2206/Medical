using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre obligatorio")]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Apellido paterno obligatorio")]
        [Display(Name = "Apellido Paterno")]
        public string ApPaterno { get; set; }

        [Required(ErrorMessage = "Apellido materno obligatorio")]
        [Display(Name = "Apellido Materno")]
        public string ApMaterno { get; set; }

        [Required(ErrorMessage = "Fecha obligatoria")]
        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNac { get; set; }

        [Required(ErrorMessage = "Sexo obligatorio")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Dirección obligatoria")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Teléfono")]
        [MaxLength(10)]
        public string Cel { get; set; }

        [Display(Name = "Ocupación")]
        public string Ocupación { get; set; }

        //Definicion de la relación
        //public int ConsultaId { get; set; }
        //[ForeignKey("ConsultaId")]
        //public virtual Consulta Consulta { get; set; }
    }
}
