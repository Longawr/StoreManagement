using StoreManagement.Utils;
using System;
using System.Data;

namespace StoreManagement.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
        }
        public TaiKhoanDAO() { }

        public bool LoginMethod(string TaiKhoan, string MatKhau)
        {
            string query = "select count(*) from TaiKhoan where TaiKhoan = @TaiKhoan and MatKhau = @MatKhau";
            object[] parameters = { TaiKhoan, MatKhau };
            return DataProvider.Instance.ExecuteScalar(query, parameters);
        }

        public DataTable GetCurrentNhanVien(string TaiKhoan)
        {
            string query =  "select nv.MaNhanVien, nv.TenNV, tk.VaiTro"
                            + " from NhanVien as nv"
                            + " inner join TaiKhoan as tk"
                            + " on nv.MaNhanVien = tk.MaNhanVien"
                            + " where tk.MaNhanVien = @TaiKhoan";
            object[] parameters = { TaiKhoan };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        internal int DoiMK(string maNV, string mkCu, string mkMoi)
        {
            string query = "update TaiKhoan set MatKhau = @mkMoi " +
                " where MaNhanVien = @maNV and MatKhau = @mkCu ";
            object[] parameter = { mkMoi, maNV, mkCu };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            Console.WriteLine(result);
            return result;
        }
    }
}
