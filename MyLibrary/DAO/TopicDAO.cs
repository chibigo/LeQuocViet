using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary.DAO
{
    public class TopicDAO
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
        // Trả về danh sách.
        public List<Topic> getList()
        {
            var list = db.Topics.ToList();
            return list;
        }
        // Trả về số lượng
        public long getCount()
        {
            var count = db.Topics.Count();
            return count;
        }
        // Trả về một mẩu tin
        public Topic getRow(int? id)
        {
            var row = db.Topics.Find(id);
            return row;
        }
        public Topic getRow(string slug)
        {
            var row = db.Topics.Where(m => m.Slug == slug).FirstOrDefault();
            return row;
        }
        //Thêm
        public void Insert(Topic row)
        {
            db.Topics.Add(row);
            db.SaveChanges();
        }
        //Sữa
        public void Update(Topic row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(Topic row)
        {
            db.Topics.Remove(row);
            db.SaveChanges();
        }
    }
}
