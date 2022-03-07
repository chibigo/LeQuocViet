using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary.DAO
{
    public class UserDAO
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
        // Trả về danh sách.
        public List<User> getList()
        {
            var list = db.Users.ToList();
            return list;
        }
        // Trả về số lượng
        public long getCount()
        {
            var count = db.Users.Count();
            return count;
        }
        // Trả về một mẩu tin
        public User getRow(int? id)
        {
            var row = db.Users.Find(id);
            return row;
        }
        //public User getRow(string slug)
        //{
        //    var row = db.Users.Where(m => m.Slug == slug).FirstOrDefault();
        //    return row;
        //}
        //Thêm
        public void Insert(User row)
        {
            db.Users.Add(row);
            db.SaveChanges();
        }
        //Sữa
        public void Update(User row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(User row)
        {
            db.Users.Remove(row);
            db.SaveChanges();
        }
    }
}
