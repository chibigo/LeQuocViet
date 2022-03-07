using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên tài khoản không để trống")]
        public String Fullname { get; set; }
        [Required(ErrorMessage = "Username không để trống")]
        public String Username { get; set; }
        [Required(ErrorMessage = "Password không để trống")]
        public String Password { get; set; }
        [Required(ErrorMessage = "Email không để trống")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Gender không để trống")]
        public int? Gender { get; set; }
        public String Phone { get; set; }
        public String Img { get; set; }
        public int? Access { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Update_At { get; set; }
        public int? Update_By { get; set; }
        public int Status { get; set; }
    }
}
