using System.ComponentModel.DataAnnotations;

namespace MVCCapas.Models
{
    public class CursoModel
    {
        public int CursoID { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string Nombre { get; set; }
    }
}
