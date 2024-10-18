using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        public Student()
        {

        }

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        //get va set
        //id là 1 thứ lai giữa biến và hàm, bao get/set lại
        //nhưng xài get/set qua style gán giá trị cho biến
        //cw(.Id) ~~~ cw(getId()) return _id
        //.Id = "SE181532", value = SE181532, _id = SE181532
        //chơi biến nhưng là gọi hàm => tự nhiên trong viết code
        //thay đổi giá trị biến là set, gọi tên biến là get
        //getName() setName() ko tự nhiên
        //Name = ... tự nhiên
        //Property of a class
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        //.Id sẽ là get value của Id
        //.Id = "SE123456" -> set Id
        public string Name 
        { 
            get 
            { 
                return _name; 
            } 
            set 
            { 
                _name = value; 
            } 
        }
        public int Yob 
        { 
            get => _yob; 
            set => _yob = value; 
        }
        public double Gpa 
        { 
            get => _gpa; 
            set => _gpa = value; 
        }

        public override string? ToString() => $"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}";
    }
}

//xài property nghĩa là ta chế ra 1 biến - lai với hàm, bao bên trong 2 hàm get() set() truyền thống, 2 hàm này thao tác trên _field để lưu trữ/thao tác các attribute
//_field được gọi là hậu phương của biến lai Id, Name, Yob, Gpa,...
//Đằng sau property là biến _field lo cho việc get/ set
//                          _field được gọi tên mới: Backing Field
//                          _id, _name, _yob, _gpa: Backing Field
