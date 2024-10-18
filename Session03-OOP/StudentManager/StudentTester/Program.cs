using StudentTester.Entities;

namespace StudentTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateStudentObject();
        }
        static void CreateStudentObject()
        {

            Student student = new Student("SE181532", "Thanh Binh", 2004, 8.7);
            //gọi cái phễu, đổ vật liệu vào, lấp vào bên trong cái khuôn, để đúc 1 object, 1 bức tượng
            //giống như đổ mực lên cái phôi đã được clone để thành 1 cmnd của bạn, của tôi, của ai 

            Student binh = new("SE1", "Binhdaynee", 2004, 8.6);
            //new kiểu mới, ko cần đi kèm dât type vì bên trái đã có khai báo rồi

            //var binhne = new("SE2", "Binh Nguyen", 2004, 8.6);
            //2 bên đều ko rõ hàng về data type, ERROR!
            var binhne = new Student("SE2", "Binh Nguyen", 2004, 8.6);

            //Student binhidol = new(8.6, 2004, "SE20", "Binh Idol ne");
            //khi gọi tham số hàm, phải gọi đúng thứ tự biến đã được xác định ở tên hàm. constructor cũng là 1 hàm, hàm đặc biệt để clone vùng RAM, fill info của object, cái phễu nhận vật liệu
            Student binhidol = new Student(gpa: 8.7, yob: 2004, name: "Binh Idol ne", id: "SE20");
            //Kĩ thuật gọi hàm ko theo thứ tự của biến, gọi lộn xộn thứ thự okie luôn, miễn là chỉ ra được biến nào ứng với value nào qua kí hiệu tên biến: value
            //kĩ thuật này giúp ta linh hoạt trong cách gọi hàm
            //kĩ thuật gọi là named-argument
            //gọi hàm đi kèm tên tham số
            //flex info 4 bạn
            //var binhne = new Student("SE2", "Binh Nguyen", 2004, 8.6);
            //    nickname        object
            //con người có xu hướng đặt tên gọi cho mọi thứ (đơn giản & phức tạp)
            //3.14 -> PI, 9.8 -> G, 300.000 -> price, total, c
            //10% 8% -> discount, vat


            student.FlexProfile();
            binh.FlexProfile();
            binhne.FlexProfile();
            binhidol.FlexProfile();

            Console.WriteLine("SE181532's Name: " + student.GetName());
            Console.WriteLine("SE1's Name: {0}", binh.GetName());
            Console.WriteLine($"SE2's Name: {binhne.GetName()}");

            //Các sinh viên học hành chăm chỉ
            //điểm trung bình được cập nhật

            binh.SetGpa(9.0);
            student.FlexProfile();
            binh.FlexProfile();
            binhne.FlexProfile();
            binhidol.FlexProfile();

            //Student s = new Student(...);
            Student s = binhne;
            s.FlexProfile();

            s.SetGpa(10.0);
            Console.WriteLine("binh's profile: ");
            binh.FlexProfile();

            //câu hỏi: 
            s = binh;
            s.FlexProfile();

            student = binh;

            student.FlexProfile();

            //System.GC Garbage Collector, module trong runtime
            //chuyên đi dọn dẹp vùng new mồ côi - ko có biến trỏ đến

        }
    }
}
