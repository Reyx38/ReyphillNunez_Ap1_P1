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
		[RegularExpression("^[a-zA-ZÀ-ÿ\\s]+$", ErrorMessage = "Solo se permiten letras.")]
		public string? Nombres { get; set; }
        [Required(ErrorMessage = " Campo obligatorio")]
        [StringLength(100)]
		[RegularExpression("^[a-zA-ZÀ-ÿ\\s]+$", ErrorMessage = "Solo se permiten letras.")]
		public string? Concepto { get; set; }
        [Required(ErrorMessage = " Campo obligatorio")]
        [Range(1,double.MaxValue)]
        public int Deuda {  get; set; }
        


    }
}
