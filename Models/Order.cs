using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Online_Resturent_1.Models
{
    public class Order
    {
        [Key]
        public int Or_ID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Order_Name { get; set; }
        public int Cu_ID { get; set; }
        //order customer relationship
        public Customer? Customer { get; set; }

        //order payment relationship
        public Payment? Payment { get; set; }

        //order-food relationship
        public ICollection<Food>? Foods { get; set; }
    }
}
