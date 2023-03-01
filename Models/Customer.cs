using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Online_Resturent_1.Models
{
    public class Customer
    {
        [Key]
        public int Cu_ID { get; set; }
        public string Cu_Name { get; set; }
        public string Cu_Password { get; set; }    
        public string Cu_Mobile { get; set; }
        public string Cu_Email { get; set; }

        //order customer relationship
        public ICollection<Order>? Orders { get; set; }
        
    }

    
}
