using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        //class như 1 cái khuôn, template, form, biểu mẫu (để điền vào), blue-print (dàn khung, bản phác thảo, bản thiết kế)
        //là tên gọi chung cho 1 nhóm object chia sẻ chung nhiều đặc tính và hành vi (field, behavior/ method)

        //để có 1 object, để có 1 đối tượng, 1 hồ sơ sv nhập học, ta phải điền vào form ở trên, trước khi điền form, ta phải photo ra 1 form trắng - new (clone, photo)
        //sau đó ta fill info, đổ info vào (tham số hàm)
        //fill vào để tạo ra object - construct/ constructor (tham số vật liệu đưa vào)
        //new           Student           (...)
        //clone form    gọi phễu
        //xin ram       nhận vật liệu     vật liệu đưa vào
        //object này gọi tên là gì? Student binh = 
        //Phần code còn lại y chang java
        //Constructor để đúc object
        //Các hàm Get() Set() ToString() ~ FlexProfile

        //phễu
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }
        //các hàm truyền thống trong java here!! 100 giống
        public void FlexProfile() => Console.WriteLine($"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}"); //expression body

        //Console.Write("ID: " + _id);
        //Console.Write(" | Name: " + _name);
        //Console.Write(" | Yob: " + _yob);
        //Console.WriteLine(" | Gpa: " + _gpa);

        //object được sản xuất, tạo ra, tức là đã được đổ info vào 
        //giống như bạn vào ngân hàng làm phiếu rút điền, điền phiếu rút tiền, điền xong bạn ngắm nghĩa coi câu chữ rõ chưa, gọi là get() info
        //tôi biết bạn có tên, nhưng tên đang private
        //GetName() => return trả về name
        public string GetName() => _name;
        public int GetAge() => 2024 - _yob; //return 2024 - _yob
        //harded-code trong code có những giá trị cố định, con số cố định
        //gọi class rồi gọi hàm lấy ngày giờ hệ thống - _yob


        //đổi màn hình của đt, đổi avatar cover của tài khoản mxh
        //cần chuẩn bị 1 cái hình
        //nhấn nút, thay thế khung hình = hình mới chuẩn bị
        //đổi nền(hình mới)   set, setting, setter
        //{
        //    Khung-hình = cũ = hình-mới;
        //}
        //Setting không tạo ra object mới mà chỉ là tinh chỉnh, chỉnh sửa object cũ đang có
        //tui bạn đổ bình mực lên tay, không phai mực -> màu da mới được thiết lập tha-thu -> vẫn là ta mà
        //một sv có gpa, kì này có điểm mưới, phải được cập nhật
        public void SetGpa(double gpa) => _gpa = gpa;

        //hắc não: Hàm Set() giống và khác cái phếu constructor ntn???
        //Giống: Đều đổ info vào vùng ram, vùng nêu
        //Khác: Phễu constructor mỗi lần gọi, là 1 lần xin ram cho object, tạo mới object
        //      Hàm set() mỗi lần gọi, là đổ vào vùng ram cũ đã new trước đó, chỉnh sửa vùng ram đã có, ko tạo mới vùng ram object
        //thằng nào cũng được gọi nhiều lần
        //set() mà gọi giống mình make-up, xăm, nhuộm tóc

        //Hàm set() là của object mỗi người có nhu cầu độ khác nhau -> khi gọi đi kèm biến object, binh.setGpa(...)

    }
}

//coding convention - quy tắc đặt tên trong c#
//I. Tên của solution

//II. Tên của project


//III. Tên của namespace


//IV. Tên của class, interface, delegates
//1. Tên class
//- Danh từ, chữ hoa từng đầu từ - Pascal Case Notation -> Bắt chước theo ngôn ngữ lập trình Pascal
//* Ví dụ: Student, Lecturer, Dog, Cat, File, Console, ArrayList

//V. Tên biến (biến cục bộ trong hàm, biến ngoài hàm field)
//1. "Biến toàn cục" Field/ Attribute
//- Danh từ, Cú pháp con Lạc Đà, camel Case Notation Chữ Hoa Từng Đầu Từ, Từ đầu tiên viết chữ thường kèm _ đứng đầu
//Ví dụ: _id, _name, _yob, _salary, _gpa

//2. Property (Biến lai với hàm - làm get set theo kiểu mlem)
//* Property là kĩ thuật viết hàm get set gọn gàng qua style xài biến, ta độ thêm 1 biến và bao cái _field qua 2 hàm get set xài tự nhiên qua biến lai property
//tên "biến lai property phải là danh từ, chữ hoa từng đầu từ (Pascal Case), ko có động từ do động từ get set bị che bên trong property này
//Có nhiều kĩ thuật xài property, từ v3 trở đi

//2. Biến cục bộ - local variable - biến trong hàm, hoặc tham số hàm parameter
//- Danh từ, Cú pháp con Lạc Đà, từ đầu tiên viết chữ thường, các từ còn lại Chữ Hoa Từng Đầu Từ
//Ví dụ: salary, sum, count, yob, basicSalary



//VI. Tên hàm (method)
//- Verb + Object, Cú pháp Pascal, Pascal Case Notation
//Chữ Hoa Từng Đầu Từ, Từ Đầu Tiên Là Động Từ
//Ví dụ: GetName(), Student(), ToString(), Main(), Convert(), SetName()
