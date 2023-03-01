using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Online_Resturent_1.Models
{
    public class Payment
    {
        [Key]
        public int P_ID { get ; set ; }
        public string? Card { get; set; }
        public string? Bank { get; set; }
        public string? Email { get; set; }

        public int Or_ID { get; set; }
        public Order? Order { get; set; }
    }
}
