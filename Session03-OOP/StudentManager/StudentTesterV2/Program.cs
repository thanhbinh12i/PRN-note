using StudentTesterV2.Entities;

namespace StudentTesterV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            //toàn bộ info bên trong là default
            //chuỗi -> empty, số -> 0, bool -> false
            student.FlexProfile();
            student.SetId("SE181532");
            student.SetName("Binhdaynee");
            student.SetYob(2004);
            student.SetGpa(8.6);
            Console.WriteLine(student.ToString());
            Console.WriteLine(student);
            //Khi bạn quyết định in biến object, bên C in ra địa chỉ con trỏ
            //Bên java c# nó đi tìm hàm TOSTRING() để chạy
            //Java: in ra mã băm của vùng RAM nếu class mình làm ko có hàm tostring(), đi gọi hàm của cha
            //C#: Ko in mã băm của vùng RAM của class nếu class mình không có hàm tostring(), trả về data type của vùng new - tình huống nãy trả về chữ student
            //Vậy nếu mình cố tình sửa lại code tostring() đươc ko -> được, thì mới gọi là override phủ quyết, qua mặt cha, cha ngồi đó, để con lo
        }
    }
}
