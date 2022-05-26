using System.ComponentModel.DataAnnotations;

namespace Beicola.Models
{
    public class SubCategories
    {
        [Key]
        public int Id_Subcat { get; set; }
        public int Id_Cat { get; set; }
        public string Nm_Subcat { get; set; }
        public int St_Subcat { get; set; }         
    }
}
