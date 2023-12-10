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

        internal int ThemNV(byte[] anhNV, string maNV, string tenNV, string sdt)
        {
            string query = "insert into NhanVien(AnhNV, MaNhanVien, TenNV, Sdt)"
                           + " values( @anhVN , @maNV , @tenNV , @sdt )";
            object[] parameter = { anhNV, maNV, tenNV, sdt };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result;
        }

        internal int XoaNV(string maNV)
        {
            string query = "delete from NhanVien where MaNhanVien = @maNV";
            object[] parameter = { maNV };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result;
        }
    }
}
