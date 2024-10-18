using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //Một class có bao nhiêu Constructor: Vô số, bạn muốn fill data kiểu nào: _id only; _id _name (*),...
        //Điều gì xảy ra nếu ko tạo constructor => Runtime sẽ tạo cho bạn 1 constructor default/ empty constructor
        //Khi xài constructor default, thông tin được đổ thế nào???
        //Ngoài đời giống tình huống: Cô giao dịch viên đưa cho mình cái form trắng (Photo, In từ form gốc)
        //Mình chưa điền, fill Info, nhưng nó là của mình
        //Ta vẫn nêu được 1 object nhưng info bỏ trống, default 
        //string -> empty
        //số -> 0

        //Tuy nhiên ta có thể chủ động tạo sẵn 1 cst default (explicit empty constructor - tường minh rõ ràng)
        //Ngầm tạo giúp mình gọi là implicit empty constructor - ko tường minh


        //Tạo siêu nhanh CTOR Tab
        public Student() //explicit empty cst
        {
            
        }

        //Có bao nhiêu cst, có bấy nhiêu new object
        //nếu class đã có sẵn 1 cst nào đó thì runtime ko tạo giúp empty cst nữa, trừ khi bạn chủ động tạo explicit nó
        //Mục tiêu cuối: Class cần có ít nhất 1 cst để đúc object
        //Tạo CST empty và các cst khác:

        //Đúc xong thì có object, ta sẽ xem get() và sửa set() xem tất cả flexprofile
        
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }
        public void FlexProfile() => Console.WriteLine($"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}");

        public override string? ToString() => $"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}";
            //return base.ToString();

        //get và set: Thay đổi info của object, lấy từng miếng info của object
        //tostring() flex() là lấy hết
        //Lý thuyết: Có n fields thì có n x 2 hàm get() set() 
        //4 fields = 8 hàm
        public string GetId() => _id;
        public string GetName() => _name;
        public int GetYob() => _yob;
        public double GetGpa() => _gpa;
        //Mọi hàm Set luôn cần 1 value đưa vào
        public void SetId(string id) {  _id = id; }
        public void SetName(string name) { _name = name; }
        public void SetYob(int yob) { _yob = yob; }
        public void SetGpa(double gpa) { _gpa = gpa; }
        //Đoạn code get/set viết theo style này rất nhàm chán, quen thuộc, nhưng vẫn phải làm, vì nó giúp object có tương tác: cung cấp info, tiếp nhận info
        //bắt buộc phải làm, lặp đi lặp lại và nhàm chán
        //người ta gọi là boiler plate
        //C# sẽ giúp bạn 1 style mới (java chưa có) tránh code boiler plate

        //1 Biến bất kỳ
        int yob = 2004;
        //ta muốn get value của nó, tên biến là đủ
        //xài tên biến là get() get() là lấy info
        //cw(yob); // lấy value và in ra

        //ta muốn set value cho biến
        //tên biến = value;
        //yob = 2006; set value 2006 cho yob

        //Bản thân 1 biến đã mang 2 ý nghĩa: get và set
        //có cần phải cái hàm bao hành động này lại hay không?
    }

}
