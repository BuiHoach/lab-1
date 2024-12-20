using System.Text;

namespace lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ++++++++            ++++        ++++");
            Console.WriteLine("++++++++++++      +++++++++++++++++++++");
            Console.WriteLine("++++    ++++     +++++++++++++++++++++");
            Console.WriteLine("++++               ++++        ++++");
            Console.WriteLine("++++              ++++        ++++");
            Console.WriteLine("++++    ++++   +++++++++++++++++++++");
            Console.WriteLine("++++++++++++  +++++++++++++++++++++");
            Console.WriteLine("  ++++++++     ++++        ++++");
            // bài 1.2
            // Khai báo các biến
            Console.InputEncoding = Encoding.UTF8;
            string maNhanVien = "NV001";
            string hoTen = "Nguyen Van A";
            string ngaySinh = "01/01/1990";
            string diaChi = "123 Nguyen Trãi, Hà Nội";
            string dienThoai = "0123456789";
            string email = "nguyenvana@example.com";

            // Hiển thị thông tin nhân viên
            Console.OutputEncoding = Encoding .UTF8;
            Console.WriteLine("Thông tin nhân viên:");
            Console.WriteLine($"Mã nhân viên: {maNhanVien}");
            Console.WriteLine($"Họ tên: {hoTen}");
            Console.WriteLine($"Ngày sinh: {ngaySinh}");
            Console.WriteLine($"Địa chỉ: {diaChi}");
            Console.WriteLine($"Điện thoại: {dienThoai}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
