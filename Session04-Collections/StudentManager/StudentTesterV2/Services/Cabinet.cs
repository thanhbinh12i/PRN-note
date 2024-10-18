using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Services
{
    //T: Type 
    //value là tham số F(int x)
    //Data type là tham số F(T x)
    //Cabinet<Student> tuSE = new Cabinet<Student>();
    //Cabinet<Lecturer> tuLSE = new Cabinet<Lecturer>();
    public class Cabinet<T>
    {
        //private Lecturer[] _arr;
        //private Student[] _arr1; 
        private T[] _arr;
        private int _count = 0;
        public Cabinet(int size) 
        {
            _arr = new T[size];
        }
        public void Add(T item) 
        {
            _arr[_count++] = item;
        }

    }
}
//bài tập vn 3: Hoàn tất nốt class và code main thử nghiệm