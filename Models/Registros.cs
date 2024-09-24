using System.ComponentModel.DataAnnotations;

namespace ReyphillNunez_Ap1_P1.Models
{
    public class Registros
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nombres { get; set; }


    }
}
