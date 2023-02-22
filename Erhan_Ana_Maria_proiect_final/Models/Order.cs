using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erhan_Ana_Maria_proiect_final.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int AlbumID { get; set; }

        public DateTime OrderDate { get; set; }

        public Customer? Customer { get; set; }
        public Album? Album { get; set; }
    }
}
