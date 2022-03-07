using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public int? TopId { get; set; }
        [Required]
        public String Title { get; set; }
        public String Slug { get; set; }
        public String Detail { get; set; }
        public String Img { get; set; }
        [Required]
        public String Type { get; set; }
        public String Metakey { get; set; }
        public String Metadesc { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Update_At { get; set; }
        public int? Update_By { get; set; }
        public int Status { get; set; }

    }
}
