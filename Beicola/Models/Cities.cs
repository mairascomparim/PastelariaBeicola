using System.ComponentModel.DataAnnotations;

namespace Beicola.Models
{
    public class Cities
    {
        [Key]
        public int Id_City { get; set; }
        public string Nm_City { get; set; }
        public int St_City { get; set; }
    }
}
