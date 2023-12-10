using StoreManagement.Utils;
using System.Data;

namespace StoreManagement.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
        }
        public NhanVienDAO() { }

        public DataTable GetNhanVienById(string MaNhanVien)
        {

            string query =  "select nv.AnhNV, nv.MaNhanVien, tk.TaiKhoan, nv.TenNV, nv.Sdt"
                            + " from NhanVien as nv"
                            + " inner join TaiKhoan as tk"
                            + " on nv.MaNhanVien = tk.MaNhanVien"
                            + " where nv.MaNhanVien = @MaNhanVien";
            object[] parameter = { MaNhanVien };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }

        public int SuaNhanVien(string maNV, string tenNV, string sdt)
        {

            string query = "update NhanVien set tenNV = @tenNV ," +
                " sdt = @sdt where maNhanVien = @maNV";
            object[] parameter = { tenNV, sdt, maNV };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter);
        }
    }
}
