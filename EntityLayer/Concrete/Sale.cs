using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Sale
    {
        [Key]
        public int SaleID { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int Piece { get; set; }
    }
}
