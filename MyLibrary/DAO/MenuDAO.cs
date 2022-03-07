using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary.DAO
{
    public class MenuDAO
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
        // Trả về danh sách.
        public List<Menu> getList()
        {
            var list = db.Menus.ToList();
            return list;
        }
        // Trả về số lượng
        public long getCount()
        {
            var count = db.Menus.Count();
            return count;
        }
        // Trả về một mẩu tin
        public Menu getRow(int? id)
        {
            var row = db.Menus.Find(id);
            return row;
        }
        //public Menu getRow(string slug)
        //{
        //    var row = db.Menus.Where(m => m.Slug == slug).FirstOrDefault();
        //    return row;
        //}
        //Thêm
        public void Insert(Menu row)
        {
            db.Menus.Add(row);
            db.SaveChanges();
        }
        //Sữa
        public void Update(Menu row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(Menu row)
        {
            db.Menus.Remove(row);
            db.SaveChanges();
        }
    }
}
