using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Entities
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }                                     

        public override string? ToString() => $"{Id} {Name} {Yob} {Gpa}";
    }
}
//Ta cần lưu trữ nhiều hồ sơ sinh viên
//Lưu trữ nhiều hồ sơ sinh viên thì cần khai báo mảng
//Student[] arr = new Student[500];
//int count = 0; //count++ theo dần những hồ sơ được sv cất vào
//Câu hỏi: Mảng và biến count khai báo ở đâu
//Nguyên lý S trong SOLID: Mỗi class chỉ làm đúng việc của mình
//Student đã làm tròn việc: Lưu hồ sơ từng bạn, tức new student () có trong ram
//chỗ nào cất nhiều hồ sơ -> ko phải câu chuyện của class Student

//nó có đủ cái khái crud hồ sơ: create/insert
//                              retrieve/read lấy toàn bộ, in sao kê
//                              update
//                              delete

//Tủ đựng hồ sơ, tủ đựng balo, giỏ sách ở siêu thị -> quầy gọi tên là dịch vụ khách hàng

