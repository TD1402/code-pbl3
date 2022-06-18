using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLLQLS
    {
        QLTV db = new QLTV();
        private static BLLQLS _Instance;
        public static BLLQLS Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLQLS();
                return _Instance;
            }
            private set { }
        }
        public List<Sach> GetAllSach()
        {
            return db.Saches.ToList();
        }
        public dynamic HienThi(List<Sach> l)
        {
            List<dynamic> list = new List<dynamic>();

            foreach (var s in l.Select(p=> new {p.Mã_sách, p.Tên_sách, p.Năm_xuất_bản, p.Nhà_xuất_bản, p.Số_lượng, p.Tác_giả, p.Loại, p.Giá}))
            {
                list.Add(s);
            }
            return list;
        }
      
     
        public List<Sach> GetSach(string n, string loai)
        {
            List <Sach> list = new List<Sach>();
            foreach (Sach i in GetAllSach())
            {
                if (i.Tên_sách.Contains(n) && i.Loại == loai)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public List<Sach> GetSachByName(string n)
        {
            List<Sach> sachList = new List<Sach>();
            foreach (Sach i in GetAllSach())
            {
                if (i.Tên_sách.Contains(n))
                {
                    sachList.Add(i);
                }
            }
            return sachList;
        }
        public List<string> GetLoaiSach()
        {
            List<string> loaiList = new List<string>();
            foreach (Sach i in GetAllSach())
            {
                loaiList.Add(i.Loại);
            }
            return loaiList;
        }
        public List<Sach> GetSachByLoai(string l)
        {
            List<Sach> list = new List<Sach>();
            foreach (Sach i in GetAllSach())
            {
                if (i.Loại == l)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public Sach GetSachByMaSach(string MS)
        {
            Sach sach = new Sach();
            foreach(Sach i in GetAllSach())
            {
                
                if (i.Mã_sách == MS)
                {
                    sach = i;
                    break;
                }
            }
            return sach;
        }
        public List<string> GetAllMaSach()
        {
            List<string> l = new List<string>();
            foreach(Sach i in GetAllSach())
            {
                l.Add(i.Mã_sách);
            }
            return l;
        }
        public bool CheckSach(string ms)
        {
            foreach(Sach i in GetAllSach())
            {
                if (i.Mã_sách == ms) return true;
            }
            return false;
        }
        
    }
}
