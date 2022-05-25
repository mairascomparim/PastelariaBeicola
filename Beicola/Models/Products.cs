using System.ComponentModel.DataAnnotations;

namespace Beicola.Models
{
    public class Products
    {
        [Key]
        public int Id_Prod { get; set; }
        public int Id_Subcat { get; set; }
        public string Nm_Prod { get; set; }
        public decimal Vl_Prod { get; set; }
        public string Ds_Prod { get; set; }
        public int Av_Prod { get; set; }
        public string Pic_Prod { get; set; }
        public int St_Prod { get; set; }
    }
}
