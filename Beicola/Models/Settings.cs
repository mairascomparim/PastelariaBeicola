using System.ComponentModel.DataAnnotations;

namespace Beicola.Models
{
    public class Settings
    {
        [Key]
        public decimal Vl_Freight { get; set; }
        public int Is_open { get; set; }
    }
}
