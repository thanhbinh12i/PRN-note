using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV4.Entities
{
    internal class Student
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
        public string Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Yob { get { return _yob; } set { _yob = value; } }
        public double Gpa { get { return _gpa; } set { _gpa = value; } }

        //get set kiểu mới dù dễ thương, dùng tự nhiên
        //Theo style biến = (set) biến (get) nhưng vẫn là boiler plate do lặp lại thứ đã quen


    }
}
