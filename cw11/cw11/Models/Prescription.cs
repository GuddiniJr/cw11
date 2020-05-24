using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class Prescription
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrescription { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public DateTime dueDate { get; set; }
        [ForeignKey("Patient")]
        public int? IdPatient { get; set; }
        [ForeignKey("Doctor")]
        public int? IdDoctor { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
