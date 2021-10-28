using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Models
{
    public class Consulta
    {
        [Key]
        public int Id { get; set; }                       

        [Required(ErrorMessage ="Fecha obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name ="Fecha de consulta")]
        public DateTime FechaConsulta{ get; set; }

        [Required(ErrorMessage = "Diagnostico obligatorio")]
        [Display(Name ="Motivo de consulta")]
        public string Diagnostico { get; set; }

        [Required(ErrorMessage ="Receta obligatoria")]
        [Display(Name ="Receta")]
        public string Receta { get; set; }

        //public int? ConsultaId { get; set; }
        //[ForeignKey("ConsultaId")]
        //public virtual Consulta Consulta { get; set; }

        //public int PacienteId { get; set; }
        //[ForeignKey("PacienteId")]
        //public virtual IEnumerable<Paciente> Paciente { get; set; }
    }
}
