using System.ComponentModel.DataAnnotations;

namespace ReyphillNunez_Ap1_P1.Models
{
    public class Prestamos
    {
        [Key]
        [Required]
        public int DeudorId { get; set; }
        [Required(ErrorMessage =" Campo obligatorio")]
        [StringLength(50)]
        public string? Nombres { get; set; }
        [Required(ErrorMessage = " Campo obligatorio")]
        [StringLength(100)]
        public string? Concepto { get; set; }
        [Required(ErrorMessage = " Campo obligatorio")]
        [Range(1,double.MaxValue)]
        public int Deuda {  get; set; }
        


    }
}
