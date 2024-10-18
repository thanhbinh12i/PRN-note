using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Services
{
    //class cabinet nếu design chỉ chơi Student hoặc Lecturer hoặc Pet... -> gọi là Tight Coupling
    //Tuy nhiên code của chúng tương đồng nhau, vậy tại sao phải làm nhiều class mà code tương đồng nhau, hãy để class cabinet ko chơi với class cụ thể nào, hãy buông các class cụ thể ra, mà nên hứa hẹn là: Tui cabinet sẽ chơi được với nhiều class khác nhau -> ko gắn kết chặt chẽ thì gọi là loose coupling -> giúp cho class hoạt động linh hoạt, dễ dàng mở rộng, dễ dàng thích ứng với nhiều tình huống
    public class Cabinet<T>
    {
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
        public void PrintList()
        {
            if (_count == 0)
            {
                Console.WriteLine("There is no item in the box");
                return;
            }
            Console.WriteLine($"There is/are {_count} item(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }

        }
    }
}