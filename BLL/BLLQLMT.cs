using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLLQLMT
    {
        QLTV db = new QLTV();
        private static BLLQLMT _Instance;
        public static BLLQLMT Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLQLMT();
                return _Instance;
            }
            private set { }
        }
        public List<MuonSach> GetAllLichSuMuon()
        {
            return db.MuonSaches.ToList();
        }
        public dynamic HienThi(List<MuonSach> l)
        {
            List<dynamic> list = new List<dynamic>();
            foreach(var i in l.Select(p=>new {p.STT,p.Mã_mượn,p.Mã_Người_Mượn,p.Tên_Người_Mượn,p.Mã_Sách,p.Thời_Gian_Mượn,p.Tình_Trạng,p.Mã_Nhân_Viên,p.Thời_Gian_Trả}))
            {
                list.Add(i);
            }
            return list;
        }
        public List<TraSach> GetAllLichSuTra()
        {
            return db.TraSaches.ToList();
        }
        public dynamic HienThiTra(List<TraSach> l)
        {
            List<dynamic> list = new List<dynamic>();
            foreach (var i in l.Select(p => new { p.STT, p.Mã_Trả, p.Mã_Người_Trả,p.Tên_Người_Trả, p.Mã_Sách, p.Thời_Gian_Trả, p.Tình_Trạng, p.Mã_Nhân_Viên,p.Đã_Trả }))
            {
                
                list.Add(i);
            }
            return list;
        }
        public bool CheckMuon(string MaMuon)
        {
            foreach(MuonSach i in GetAllLichSuMuon())
            {
                if (i.Mã_mượn == MaMuon)
                    return false;
            }
            return true;
        }
        public bool CheckTra(string MaTra)
        {
            foreach (TraSach i in GetAllLichSuTra())
            {
                if (i.Mã_Trả == MaTra)
                    return false;
            }
            return true;
        }
        public void AddMuon(MuonSach m)
        {
            int demS =0,demND =0;
            foreach(Sach i in BLL.BLLQLS.Instance.GetAllSach())
            {
                if (i.Mã_sách == m.Mã_Sách) demS++;
            }
            foreach(NguoiDung i in BLL.BLLQLNguoiDung.Instance.GetAllNguoiDung())
            {
                if(i.Mã_người_dùng==m.Mã_Người_Mượn) demND++;
            }
            if(demS > 0&&demND>0)
            {
                db.MuonSaches.Add(m);
                db.SaveChanges();
            }
        }
        public void UpdateMuon(MuonSach m)
        {
            int demS = 0, demND = 0;
            foreach (Sach i in BLL.BLLQLS.Instance.GetAllSach())
            {
                if (i.Mã_sách == m.Mã_Sách) demS++;
            }
            foreach (NguoiDung i in BLL.BLLQLNguoiDung.Instance.GetAllNguoiDung())
            {
                if (i.Mã_người_dùng == m.Mã_Người_Mượn) demND++;
            }
            if (demS > 0&& demND > 0)
            {
                var ms = db.MuonSaches.Find(m.Mã_mượn);
                ms.Tên_Người_Mượn = m.Tên_Người_Mượn;
                ms.Mã_Người_Mượn = m.Mã_Người_Mượn;
                ms.Mã_Sách = m.Mã_Sách;
                ms.Thời_Gian_Mượn = m.Thời_Gian_Mượn;
                ms.Thời_Gian_Trả = m.Thời_Gian_Trả;
                ms.Tình_Trạng = m.Tình_Trạng;
                db.SaveChanges();
            }
        }
        public void AddUpdateMuon(MuonSach m)
        {
            if (CheckMuon(m.Mã_mượn)) AddMuon(m);
            else UpdateMuon(m);
        }
        public MuonSach GetMuonSachByMaMuon(string m)
        {
            MuonSach muonSach = new MuonSach();
            foreach(MuonSach i in GetAllLichSuMuon())
            {
                if(i.Mã_mượn==m) muonSach = i;
            }
            return muonSach;
        }
        public void DeleteMuon(string m)
        {
            MuonSach ms = db.MuonSaches.Find(m);
            db.MuonSaches.Remove(ms);
            db.SaveChanges();
        }

    }
}
