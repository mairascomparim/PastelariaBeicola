using System.ComponentModel.DataAnnotations;

namespace Beicola.Models
{
    public class OrderItems
    {
        [Key]
        public int Id_Orderitem { get; set; }
        public int Id_Order { get; set; }
        public int Id_Prod { get; set; }
        public int Qt_Prod { get; set; }
        public decimal Vl_Unit { get; set; }
        public decimal Vl_Tot_Item { get; set; }
    }
}
