using StoreManagement.DAO;
using System;
using System.Windows.Forms;

namespace StoreManagement.BUS
{
    class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }
        }
        public TaiKhoanBUS() { }

        public bool LoginMethod(string username, string password)
        {
            return TaiKhoanDAO.Instance.LoginMethod(username, password);
        }

        internal void DoiMatKhau(string mkCu, string mkMoi, string xacNhanMK)
        {
            if (mkMoi.Equals(xacNhanMK))
            {
            string maNV = NhanVienBUS.currentNhanVien.MaNhanVien;
            int result = TaiKhoanDAO.Instance.DoiMK(maNV, mkCu, mkMoi);
                if (result <= 0) { throw new Exception("Mật khẩu hoặc tài khoản không đúng"); }
            }
            else { throw new Exception("Xác nhận mật khẩu không trùng với mật khẩu mới"); }
        }
    }
}
