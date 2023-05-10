using DAL;
using ENTITIES;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SERVICES
{
    public class ToolService
    {
        public static bool KiemTraKetNoi()
        {
            var db = new MyShopContext();
            try
            {
                db.Database.OpenConnection();
                db.Database.CloseConnection();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static void TaoRegistry()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MyShopSettings");
            key.SetValue("Username", "");
            key.SetValue("Password", "");
            key.SetValue("Check", "0");
            key.SetValue("Entropy", "");
            key.Close();
        }

        public static void Encode(string password)
        {
            Byte[] entropy = new Byte[20];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(entropy);
            }
            var passwordInBytes = Encoding.UTF8.GetBytes(password);
            var encodePassword = ProtectedData.Protect(passwordInBytes, entropy, DataProtectionScope.CurrentUser);
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyShopSettings", true);
            key.SetValue("Password", Convert.ToBase64String(encodePassword));
            key.SetValue("Entropy", Convert.ToBase64String(entropy));
            key.Close();
        }

        public static string Decode(string encodePassword, string entropy)
        {
            var passwordInBytes = Convert.FromBase64String(encodePassword);
            var entropyInBytes = Convert.FromBase64String(entropy);
            var password = ProtectedData.Unprotect(passwordInBytes, entropyInBytes, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(password);
        }

        //import product & category
        public static bool ImportAccess()
        {
            OrderDAL order = new OrderDAL();
            ProductDAL product = new ProductDAL();
            CategoryDAL category = new CategoryDAL();

            if (order.DanhSachOrder().Count != 0 || product.DanhSachProduct().Count != 0 || category.DanhSachCategory().Count != 0)
            {
                return false;
            }
            try
            {
                var screen = new OpenFileDialog();
                if (screen.ShowDialog() == true)
                {
                    string connectionString = """"
                    Provider = Microsoft.ACE.OLEDB.12.0; 
                    Data Source = @FileName; 
                    Persist Security Info=False;
                    """";
                    connectionString = connectionString.Replace("@FileName", screen.FileName);

                    var connection = new OleDbConnection(connectionString);
                    connection.Open();

                    string sql = "select ID, Ten from Category";
                    var command = new OleDbCommand(sql, connection);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ten = (string)reader["Ten"];
                            var temp = new Category()
                            {
                                Ten = ten
                            };
                            category.ThemCategory(temp);
                        }
                    }

                    sql = "select Ten, Gia, MoTa, HinhAnh, Loai, SanXuat, SoLuong from Product";
                    command = new OleDbCommand(sql, connection);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ten = (string)reader["Ten"];
                            int gia = (int)reader["Gia"];
                            string mota = (string)reader["MoTa"];
                            string hinhanh = (string)reader["HinhAnh"];
                            int loai = (int)reader["Loai"];
                            string sanxuat = (string)reader["SanXuat"];
                            int soluong = (int)reader["SoLuong"];

                            var temp = new Product()
                            {
                                Ten = ten,
                                Gia = gia,
                                MoTa = mota,
                                HinhAnh = hinhanh,
                                LoaiSanPham = loai,
                                SanXuat = sanxuat,
                                SoLuong = soluong
                            };
                            product.ThemProduct(temp);

                        }
                    }
                    return true;
                }

                return false;
            }
            catch
            {
                category.XoaCategory();
                return false;
            }
        }
    }
}
