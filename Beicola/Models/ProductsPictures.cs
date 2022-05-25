using System.ComponentModel.DataAnnotations;

namespace Beicola.Models
{
    public class ProductsPictures
    {
        [Key]
        public int Id_Pic { get; set; }
        public int Id_Prod { get; set; }
        public string Li_Pc { get; set; }
        public int Is_Cover { get; set; }
        public int St_Pic { get; set; }
    }
}
