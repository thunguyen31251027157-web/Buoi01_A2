/*
 * Bài: Buoi01_A2 - Thẻ giới thiệu bản thân
 * Sinh viên: Nguyễn Minh Thư - MSSV: [31251027157]
 * Ngày: 14/10/2026
 */
namespace Buoi01_A2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Phần đầu thẻ
            Console.WriteLine("==============================");
            Console.WriteLine("        THẺ SINH VIÊN");
            Console.WriteLine("==============================");

            // Nhãn in bằng Write (không xuống dòng), giá trị in bằng WriteLine
            Console.Write("Họ tên  : ");
            Console.WriteLine("Nguyễn Minh Thư");
            Console.Write("MSSV    : ");
            Console.WriteLine("[31251027157]");
            Console.Write("Lớp     : ");
            Console.WriteLine("[26C1INF50900502]");
            Console.Write("Sở thích: ");
            Console.WriteLine("xem phim, ngủ nướng");

            // Phần cuối thẻ
            Console.WriteLine("==============================");
        }
    }
}