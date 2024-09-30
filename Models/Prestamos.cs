using System.ComponentModel.DataAnnotations;

namespace ReyphillNunez_Ap1_P1.Models
{
    public class Prestamos
    {
        [Key]
        [Required]
        public int DeudorId { get; set; }
        [Required]
        [StringLength(50)]
        public string? Nombres { get; set; }
        [Required]
        [StringLength(100)]
        public string? Concepto { get; set; }
        [Required]
        public int Deuda {  get; set; }
        


    }
}
