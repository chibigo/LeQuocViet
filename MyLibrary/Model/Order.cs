using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Code { get; set; }
        public int UserId { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime? Exportdate { get; set; }
        public String DeliveryAddress { get; set; }
        public String DeliveryName { get; set; }
        public String DeliveryPhone { get; set; }
        public String DeliveryEmail { get; set; }
        public DateTime? Update_At { get; set; }
        public int? Update_By { get; set; }
        public int Status { get; set; }
    }
}
