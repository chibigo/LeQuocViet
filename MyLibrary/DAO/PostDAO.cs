using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary.DAO
{
    public class PostDAO
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
        // Trả về danh sách.
        public List<Post> getList()
        {
            var list = db.Posts.ToList();
            return list;
        }
        // Trả về số lượng
        public long getCount()
        {
            var count = db.Posts.Count();
            return count;
        }
        // Trả về một mẩu tin
        public Post getRow(int? id)
        {
            var row = db.Posts.Find(id);
            return row;
        }
        public Post getRow(string slug)
        {
            var row = db.Posts.Where(m => m.Slug == slug).FirstOrDefault();
            return row;
        }
        //Thêm
        public void Insert(Post row)
        {
            db.Posts.Add(row);
            db.SaveChanges();
        }
        //Sữa
        public void Update(Post row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(Post row)
        {
            db.Posts.Remove(row);
            db.SaveChanges();
        }
    }
}
