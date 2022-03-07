using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary.DAO
{
    public class CategoryDAO
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
        // Trả về danh sách.
        public List<Category> getList()
        {
            var list = db.Categorys.ToList();
            return list;
        }
        // Trả về số lượng
        public long getCount()
        {
            var count = db.Categorys.Count();
            return count;
        }
        // Trả về một mẩu tin
        public Category getRow(int? id)
        {
            var row = db.Categorys.Find(id);
            return row;
        }
        public Category getRow(string slug)
        {
            var row = db.Categorys.Where(m => m.Slug == slug).FirstOrDefault();
            return row;
        }
        //Thêm
        public void Insert(Category row)
        {
            db.Categorys.Add(row);
            db.SaveChanges();
        }
        //Sữa
        public void Update(Category row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(Category row)
        {
            db.Categorys.Remove(row);
            db.SaveChanges();
        }
    }
}
