using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    
    public class BLLQLNV
    {
        QLTV db = new QLTV();
        private static BLLQLNV _Instance;
        public static BLLQLNV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLQLNV();
                return _Instance;
            }
            private set { }
        }
        public List<NhanVien> GetAllNhanVien()
        {
            return db.NhanViens.ToList();
        }
        public NhanVien GetNhanVienByMNV(string MNV)
        {
            NhanVien nhanVien = new NhanVien();
            foreach(NhanVien nv in GetAllNhanVien())
            {
                if (nv.MNV == MNV)
                    nhanVien = nv;
            }
            return nhanVien;
        }
        

    }
}
