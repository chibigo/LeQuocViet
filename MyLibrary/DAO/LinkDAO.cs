using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary.DAO
{
    public class LinkDAO
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
        // Trả về danh sách.
        public List<Link> getList()
        {
            var list = db.Links.ToList();
            return list;
        }
        // Trả về số lượng
        public long getCount()
        {
            var count = db.Links.Count();
            return count;
        }
        // Trả về một mẩu tin
        public Link getRow(int? id)
        {
            var row = db.Links.Find(id);
            return row;
        }
        public Link getRow(string slug)
        {
            var row = db.Links.Where(m => m.Slug == slug).FirstOrDefault();
            return row;
        }
        //Thêm
        public void Insert(Link row)
        {
            db.Links.Add(row);
            db.SaveChanges();
        }
        //Sữa
        public void Update(Link row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(Link row)
        {
            db.Links.Remove(row);
            db.SaveChanges();
        }
    }
}
