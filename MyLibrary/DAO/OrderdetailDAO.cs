using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary.DAO
{
    public class OrderdetailDAO
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
        // Trả về danh sách.
        public List<Orderdetail> getList()
        {
            var list = db.OrderDetails.ToList();
            return list;
        }
        // Trả về số lượng
        public long getCount()
        {
            var count = db.OrderDetails.Count();
            return count;
        }
        // Trả về một mẩu tin
        public Orderdetail getRow(int? id)
        {
            var row = db.OrderDetails.Find(id);
            return row;
        }
        //public Orderdetail getRow(string slug)
        //{
        //    var row = db.OrderDetails.Where(m => m.Slug == slug).FirstOrDefault();
        //    return row;
        //}
        //Thêm
        public void Insert(Orderdetail row)
        {
            db.OrderDetails.Add(row);
            db.SaveChanges();
        }
        //Sữa
        public void Update(Orderdetail row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(Orderdetail row)
        {
            db.OrderDetails.Remove(row);
            db.SaveChanges();
        }
    }
}
