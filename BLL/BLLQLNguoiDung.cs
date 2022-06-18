using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLLQLNguoiDung
    {
        QLTV db = new QLTV();
        private static BLLQLNguoiDung _Instance;
        public static BLLQLNguoiDung Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLQLNguoiDung();
                return _Instance;
            }
            private set { }
        }
        public List<NguoiDung> GetAllNguoiDung()
        {
            return db.NguoiDungs.ToList();
        }
        public bool CheckND(string m)
        {
            foreach (NguoiDung nguoiDung in GetAllNguoiDung())
            {
                if(nguoiDung.Mã_người_dùng==m)
                    return true;
            }    
            return false;
        }
        public string GetNameByMND(string m)
        {
            string name = "";
            foreach(NguoiDung i in GetAllNguoiDung())
            {
                if (i.Mã_người_dùng == m) name = i.Tên_người_dùng;
            }

            
            return name;
        }
    }
}
