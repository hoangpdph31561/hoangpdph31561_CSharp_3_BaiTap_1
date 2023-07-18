using hoangpdph31561_CSharp_3_BaiTap_1.Context;
using hoangpdph31561_CSharp_3_BaiTap_1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangpdph31561_CSharp_3_BaiTap_1.Respository
{
    internal class XeMayRespository
    {
        DBContext _db;
        public XeMayRespository()
        {
            _db = new DBContext();
        }
        public List<LoaiXe> GetLoaiXes()
        {
            return _db.LoaiXes.ToList();
        }
        public List<XeMay> GetXeMays()
        {
            return _db.XeMays.ToList();
        }
        public string AddXeMay(XeMay moto)
        {
            moto.IdXeMay = Guid.NewGuid();
            _db.XeMays.Add(moto);
            _db.SaveChanges();
            return "Thêm thành công";
        }
        public string DeleteXeMay(Guid id)
        {
            var data = _db.XeMays.FirstOrDefault(x => x.IdXeMay == id);
            _db.XeMays.Remove(data);
            _db.SaveChanges() ;
            return "Xóa thành công";
        }
        
    }
}
