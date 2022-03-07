using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary.DAO
{
    public class ContactDAO
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
        public List<Contact> getList()
        {
            var list = db.Contacts.ToList();
            return list;
        }
        // Trả về số lượng
        public long getCount()
        {
            var count = db.Contacts.Count();
            return count;
        }
        // Trả về một mẩu tin
        public Contact getRow(int? id)
        {
            var row = db.Contacts.Find(id);
            return row;
        }
        //public Contact getRow(string slug)
        //{
        //    var row = db.Contacts.Where(m => m.Slug == slug).FirstOrDefault();
        //    return row;
        //}
        //Thêm
        public void Insert(Contact row)
        {
            db.Contacts.Add(row);
            db.SaveChanges();
        }
        //Sữa
        public void Update(Contact row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(Contact row)
        {
            db.Contacts.Remove(row);
            db.SaveChanges();
        }
    }
}
