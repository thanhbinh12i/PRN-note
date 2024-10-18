using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV5.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        //Kĩ thuật code kiểu này là kĩ thuật giấu cái backing field đi
        //Runtime tự sinh ra _backing field tương ứng với mỗi property để dev đỡ phải gõ code nhiều, những đoạn code nhàm chán
        //Phía hậu trường runtime tự sinh ra _backing field tương ứng
        //kĩ thuật này gọi alf auto-generated property
        //Đôi khi quên cú pháp auto thì làm sao
        //Gõ prop tab tab

    }
}


//khi nào xài kĩ thuật property: Full property (Backing field chủ động) và auto-implemented property (giấu backing field)
//Thường ta hay xài với class mà nó sẽ map data xuống table
//Table là nơi set data và get data, xử lí để ở câu query, trong ram ở class khác

//ko ai cấm bạn xài property dạng full hoặc dạng auto ở các class khác bất kỳ