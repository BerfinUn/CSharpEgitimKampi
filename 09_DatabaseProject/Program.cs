using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net SQL yapılarını kullanmamızı sağlayan kütüphane

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ******");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source= LAPTOP-P0ITN1L5\\SQLEXPRESS;initial Catalog = EgitimKampiDb; integrated security = true ");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            //c# tarafından oluşturmuş olduğumuz sorgunun sql ile arasında bir köprü görevi görmesini sağlar
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //verilerin geçici belleğe almasını sağlar
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {

                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());

                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
