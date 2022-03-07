using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary.DAO
{
    public class OrderDAO
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
        // Trả về danh sách.
        public List<Order> getList()
        {
            var list = db.Orders.ToList();
            return list;
        }
        // Trả về số lượng
        public long getCount()
        {
            var count = db.Orders.Count();
            return count;
        }
        // Trả về một mẩu tin
        public Order getRow(int? id)
        {
            var row = db.Orders.Find(id);
            return row;
        }
        //public Order getRow(string slug)
        //{
        //    var row = db.Orders.Where(m => m.Slug == slug).FirstOrDefault();
        //    return row;
        //}
        //Thêm
        public void Insert(Order row)
        {
            db.Orders.Add(row);
            db.SaveChanges();
        }
        //Sữa
        public void Update(Order row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(Order row)
        {
            db.Orders.Remove(row);
            db.SaveChanges();
        }
    }
}
