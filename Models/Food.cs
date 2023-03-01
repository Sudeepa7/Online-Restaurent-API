using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Online_Resturent_1.Models
{
    public class Food
    {
        [Key]
        public int Food_ID { get; set; }
        public decimal Food_price { get; set; }
        public byte[]? Image { get; set; }   
        public string? Food_Name { get; set; }

        //order food relationship
        public int Or_ID { get; set; }
        public Order? Order { get; set; }    
    }
}
