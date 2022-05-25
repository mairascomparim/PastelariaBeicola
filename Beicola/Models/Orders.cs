using System.ComponentModel.DataAnnotations;

namespace Beicola.Models
{
    public class Orders
    {
        [Key]
        public int Id_Order { get; set; }
        public string Cl_Order { get; set; }
        public decimal Vl_Order { get; set; }
        public decimal Vl_Total_Order { get; set; }
        public int Ct_Order { get; set; }
        public string Dc_Order { get; set; }
        public string Nm_Street_Order { get; set; }
        public decimal Nb_Street_Order { get; set; }
        public string Rf_Order { get; set; }
        public string Dt_Order { get; set; }
        public string Hr_Order { get; set; }
        public string Fp_Order { get; set; }
        public string Ch_Order { get; set; }
        public string Ob_Order { get; set; }
        public decimal Vl_Freight { get; set; }
        public string St_Order { get; set; }
    }
}
