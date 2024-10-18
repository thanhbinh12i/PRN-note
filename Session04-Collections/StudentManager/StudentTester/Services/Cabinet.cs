using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    //1 cái tủ thì chứa nhiều hồ sơ, có thể bổ sung thêm, bớt đi, sắp xếp -> crud method
    //Muốn chứa nhiều hồ sơ, ta cần 1 mảng....
    //Mảng đi kèm biến count để biết tủ đầy chưa
    //Giống như anh chàng ở quầy dịch vụ giữ giỏ, nhìn số chìa khóa cắm trên tủ, biết tủ full chưa
    public class Cabinet
    {
        private Student[] _arr = new Student[365];
        private int _count = 0;
        //_count tăng dần ++ khi thêm từng hồ sơ vào vị trí thứ count của mảng, ban đầu là 0, 1, 2,... đến khi mảng full
        //Tại sao k làm property
        //Mảng này fix 365, ở ngoài đời đóng tủ đa dạng kích thước, có thể theo yêu cầu, vậy tui phải làm sao để tủ đóng theo yêu cầu

        //public Cabinet(int size) 
        //{
        //    if(size < 0) size = 365;
        //    _arr = new Student[size];
        //}
        public Cabinet(int size)
        {
            if (size < 0) throw new ArgumentOutOfRangeException("Invalid size! Size must be >=1"); // ko cho tạo
            _arr = new Student[size]; // new bth nếu size từ 1, 2, 3
        }

        //mở rộng: có constructor là new vô tận object
        //         constructor ném ra ngoại lệ thì tình huống đó ko new được object, ko tạo được object 

        //         nếu muốn trong ram chỉ có object được tạo ra
        //         ko nhiều hơn 1 vùng new => singleton (phải hiều static)
        //design patterns - các mẫu, kĩ thuật thiết kế class - sách của GoF - Gang Of Four

        //coi như cái tử đã đóng xong qua việc new Cabinet(500)
        //Ta đang có mảng 500/ hoặc size phần tử
        //Student[] _arr = new Student[500/size]
        //giờ là lúc _arr[i] = new Student(){...};
        //hàm add student, cái tử mở cánh cửa ra nhận hồ sơ sv
        //UI Console, Web, Form/Window có mấy ô nhập ID, Name, Yob, Gpa, Có nút nhấn, new Student() {} đẩy xuống hàm
        public void AddStudent(Student student)
        {
            _arr[_count] = student; 
            _count++;
        }
        public void AddStudent(string id, string name, int yob, double gpa)
        {
            //todo: check mảng có full k
            _arr[_count++] = new Student() { Id = id, Name = name, Yob = yob, Gpa = gpa };
        } //có thể viết thành expression body

        //Đã có danh sách student, có thể chưa full, in danh sách

        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} student(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        //Hàm xóa và sửa
        //Xóa tại vị trí thứ I, xóa theo ID là 1 cách khác
        //mảng có nhược điểm: fix kích thước khi đã new
        //nghĩa là mảng 500 sẽ là 500, xóa k đc
        //vậy xóa làm sao: xóa là lừa đảo, xóa là dồn chỗ lên
        //giảm count-- nhưng kích thước mảng vẫn như cũ
        //vị trí  [0]    [1]    [2]     [3]     [4]
        //         5      10     15      20      25
        public void DeleteStudent(string id)
        {
            int? pos = SearchStudentById(id);

            if (pos.HasValue)
            {
                for (int i = (int)pos; i < _count; i++)
                {
                    _arr[i] = _arr[i + 1];
                }
                _arr[_count - 1] = null;
                _count--;
            }
        }

        public void UpdateStudent(string id, string? newName, int? newYob, double? newGpa)
        {
            int? pos = SearchStudentById(id);
            if (pos.HasValue) //if (pos != null)
            {
                if (newName != null) _arr[(int)pos].Name = newName;
                if (newYob.HasValue) _arr[(int)pos].Yob = (int)newYob;
                if (newGpa.HasValue) _arr[(int)pos].Gpa = (double)newGpa;
                //To do at home: thêm câu if để check nếu ta đưa vào null của gpa, yob, name, giữ như cũ ko đổi [pos], khác null thì mới đổi
            }
        }
        //biến chuỗi trỏ vùng new String s1 = "HELLO"
        //thì s1 chắc chắn khác s2 do 2 con trỏ trỏ vào 1 vùng new khác nhau
        //ko bao giờ hiểu s1 == s2 hay ko do đang so sánh 2 địa chỉ, 2 con trỏ
        //c# cho phéo dùng == để so sánh 2 chuỗi do nó đã override lại toán == của số cho biến object
        //khi so sánh ta hay đổi về cùng hoa, cùng thường để so
        public int? SearchStudentById(string id)
        {
            //quét mảng từ đầu đến count coi mỗi đứa [i].Id có bằng id đang tìm không nếu có trả về vị trí, nếu ko thấy trả về
            if (_count == 0) return null;
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower()) return i;
            }
            return null;
        }

    }
}
//Bài tập về nhà: Viết ra giấy, thứ 2 tuần sau (14/10/2024) nộp bài

//1. hoàn tất nốt hàm xóa 1 phần tử mảng

//2. hoàn tất nốt hàm update 1 phần tử của mảng (if nốt thôi)

//3. 