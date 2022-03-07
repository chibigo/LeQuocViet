using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    [Table("Categorys")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên loại sản phẩm không để trống")]/*Có Required là bắt buộc phải có*/
        [DisplayName("Tên loại sản phẩm")]
        public String Name { get; set; }
        public String Slug { get; set; }
        public int ParentId { get; set; }
        public int Orders { get; set; }
        [Required(ErrorMessage = "Từ khóa không để trống")]
        public String Metakey { get; set; }
        [Required(ErrorMessage = "Mô tả không để trống")]
        public String MetaDesc { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Update_At { get; set; }
        /*Có ? có thể được phép null với số nguyên*/
        public int? Update_By { get; set; }
        public int Status { get; set; }
    }
}
