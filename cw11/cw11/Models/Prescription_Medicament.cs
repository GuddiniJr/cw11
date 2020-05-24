using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cw11.Models
{
    public class Prescription_Medicament
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdP_M { get; set; }
        [ForeignKey("Medicament")]
        public int? IdMedicament { get; set; }
        
        [ForeignKey("Prescription")]
        public int? IdPrescription { get; set; }
        public int? Dose { get; set; }
        [Required]
        public string Details { get; set; }
        public Prescription Prescription { get; set; }
        public Medicament Medicament { get; set; }
    }
}
