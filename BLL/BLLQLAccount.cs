using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    
    public class BLLQLAccount
    {
        private static BLLQLAccount _Instance;
        public static BLLQLAccount Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLQLAccount();
                return _Instance;
            }
            private set { }
        }

        QLTV db = new QLTV();
        public List<Account> GetALLAccount()
        {
           
            return db.Accounts.ToList();
        }
     
        public void TaiKhoan(Account i)
        {
            
            var v = db.TaiKhoanHienTais.ToList();
            if(v!=null)
            {
                foreach (var t in v)
                {
                    db.TaiKhoanHienTais.Remove(t);
                }
                
            }
            TaiKhoanHienTai tk = new TaiKhoanHienTai()
            {
                MNV = i.MNV,
                UserName = i.UserName,
                PassWord = i.PassWord
            };
            db.TaiKhoanHienTais.Add(tk);
            db.SaveChanges();
        }
        public Account TaiKhoanHienTai()
        {
            var i = db.TaiKhoanHienTais.ToList();
            foreach(var t in i)
            {
                Account a = new Account()
                {
                    MNV = t.MNV,
                    UserName = t.UserName,
                    PassWord = t.PassWord
                };
                return a;
            }
            return null;

        }
        public void DoiMatKhau(Account ac,string newPass)
        {
            var a = db.Accounts.Find(ac.MNV);
            a.PassWord = newPass;
            var b = db.TaiKhoanHienTais.Find(ac.MNV);
            b.PassWord = newPass;
            db.SaveChanges();
        }

    
}
}
