using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Link { get; set; }
        [Required]
        public String Type { get; set; }
        public int? TableId { get; set; }
        public int? Orders { get; set; }
        [Required]
        public String Position { get; set; }
        public int ParentId { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Update_At { get; set; }
        public int? Update_By { get; set; }
        public int Status { get; set; }
    }
}
