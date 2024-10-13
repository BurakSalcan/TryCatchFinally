using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYakalamaSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hata Yakalama (Try - Catch)
            //Try tek başına tanımlanamaz. Tanımlanabilmesi için mutlaka catch olmalıdır. 

            //try
            //{
            //    Console.Write("Lütfen bir sayı giriniz: ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Lütfen başka bir sayı daha giriniz: ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 / sayi2;

            //    Console.WriteLine("Bölüm: " + sonuc);
            //}
            //catch
            //{
            //    Console.WriteLine("Bir hata oluştu.");
            //}
            //Console.WriteLine("Hata potansiyeli dışı bölge.");

            #endregion

            #region Türe göre hata yakalama

            //try
            //{
            //    Console.Write("Lütfen bir sayı giriniz: ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Lütfen başka bir sayı daha giriniz: ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 / sayi2;

            //    Console.WriteLine("Bölüm: " + sonuc);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Bir hata oluştu.");
            //    Console.WriteLine(ex.Message); //Hata mesajını yazar.
            //    Console.WriteLine(ex.StackTrace); //Kaçıncı satırda hata olduğunu yazar.
            //}
            //Console.WriteLine("Hata potansiyeli dışı bölge.");

            #endregion

            #region Mimari oluşturma

            //try
            //{
            //    Console.Write("Lütfen bir sayı giriniz: ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Lütfen başka bir sayı daha giriniz: ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 / sayi2;
            //    string temp = null;
            //    Console.WriteLine(temp.ToUpper());

            //    Console.WriteLine("Bölüm: " + sonuc);
            //}
            //catch (FormatException ex) //Exceptionları tanımlarken hep özelden genele doğru tanımlamalıyız.
            //{
            //    Console.WriteLine("Bir format hatası oluştu.");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Sıfıra bölge işlemi tanımsızdır.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Bir hata oluştu.");
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("Hata potansiyeli dışı bölge.");

            #endregion

            #region Try Catch Finally 

            //try
            //{
            //    Console.Write("Lütfen bir sayı giriniz: ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Lütfen başka bir sayı daha giriniz: ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 / sayi2;
            //    string temp = null;
            //    Console.WriteLine(temp.ToUpper());

            //    Console.WriteLine("Bölüm: " + sonuc);
            //}
            //catch (FormatException ex) //Exceptionları tanımlarken hep özelden genele doğru tanımlamalıyız.
            //{
            //    Console.WriteLine("Bir format hatası oluştu.");

            //}
            //finally 
            //{ 
            //    Console.WriteLine("Finally çalıştı.");
            //}

            //Console.WriteLine("Hata potansiyeli dışı bölge.");

            #endregion

            #region using kullanımı

            SqlConnection con;

            using (con = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True"))
            {
                con.Open();
                Console.WriteLine("Bağlantı açıldı.");
            }

            con = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            con.Open();
            Console.WriteLine("Bağlantı kapandı.");

            #endregion
        }
    }
}
