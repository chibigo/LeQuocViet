using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Fullname không để trống")]
        public String Fullname { get; set; }
        [Required(ErrorMessage = "Email không để trống")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Phone không để trống")]
        public String Phone { get; set; }
        [Required(ErrorMessage = "Title không để trống")]
        public String Title { get; set; }
        [Required(ErrorMessage = "Detail không để trống")]
        public String Detail { get; set; }
        public int? ReplayId { get; set; }
        public String Replaydetail { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Update_At { get; set; }
        public int? Update_By { get; set; }
        public int Status { get; set; }
    }
}
