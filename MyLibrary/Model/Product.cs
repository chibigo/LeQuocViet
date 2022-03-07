using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int CatId { get; set; }
        [Required(ErrorMessage = "Tên sản phẩm không để trống")]
        public String Name { get; set; }
        public String Slug { get; set; }
        public String Img { get; set; }
        [Required(ErrorMessage = "Chi tiết không để trống")]
        public String Detail { get; set; }
        public int Number { get; set; }
        public float Price { get; set; }
        public float? PriceSale { get; set; }
        [Required(ErrorMessage = "Từ khóa không để trống")]
        public String Metakey { get; set; }
        [Required(ErrorMessage = "Mô tả không để trống")]
        public String Metadesc { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Update_At { get; set; }
        public int? Update_By { get; set; }
        public int Status { get; set; }
    }
}
