using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    public class LecturerCabinet
    {
        private Lecturer[] _arr;
        private int _count;
        public LecturerCabinet(int size)
        {
            if (size < 1) throw new ArgumentOutOfRangeException("size"); 
            _arr = new Lecturer[size];
        }

        //Crud
        public void AddLecture(Lecturer lecturer) 
        {
            _arr[_count++] = lecturer;
        }// Todo: check 
        
        public void AddLecture(string id, string name, int yob, double salary) { }
        public int? SearchLectureById(string id)
        {
            if (_count == 0) return null;
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower()) return i;
            }
            return null;
        }
        
    }
}
