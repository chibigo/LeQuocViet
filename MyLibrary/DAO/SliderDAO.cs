using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary.DAO
{
    public class SliderDAO
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
        // Trả về danh sách.
        public List<Slider> getList()
        {
            var list = db.Sliders.ToList();
            return list;
        }
        // Trả về số lượng
        public long getCount()
        {
            var count = db.Sliders.Count();
            return count;
        }
        // Trả về một mẩu tin
        public Slider getRow(int? id)
        {
            var row = db.Sliders.Find(id);
            return row;
        }
        //public Slider getRow(string slug)
        //{
        //    var row = db.Sliders.Where(m => m.Slug == slug).FirstOrDefault();
        //    return row;
        //}
        //Thêm
        public void Insert(Slider row)
        {
            db.Sliders.Add(row);
            db.SaveChanges();
        }
        //Sữa
        public void Update(Slider row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(Slider row)
        {
            db.Sliders.Remove(row);
            db.SaveChanges();
        }
    }
}
