using System.ComponentModel.DataAnnotations;

namespace Beicola.Models
{
    public class Categorie
    {
        [Key]
        public int Id_Cat { get; set; }
        public string Nm_Cat { get; set; }
        public int St_Cat { get; set; }
    }
}
