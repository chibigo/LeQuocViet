using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary.DAO
{
    public class ProductDAO
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
        // Trả về danh sách.
        public List<Product> getList()
        {
            var list = db.Products.ToList();
            return list;
        }
        // Trả về số lượng
        public long getCount()
        {
            var count = db.Products.Count();
            return count;
        }
        // Trả về một mẩu tin
        public Product getRow(int? id)
        {
            var row = db.Products.Find(id);
            return row;
        }
        public Product getRow(string slug)
        {
            var row = db.Products.Where(m => m.Slug == slug).FirstOrDefault();
            return row;
        }
        //Thêm
        public void Insert(Product row)
        {
            db.Products.Add(row);
            db.SaveChanges();
        }
        //Sữa
        public void Update(Product row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(Product row)
        {
            db.Products.Remove(row);
            db.SaveChanges();
        }
    }
}
