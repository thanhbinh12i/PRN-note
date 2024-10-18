using PrimitiveList.Entities;
using System.Collections;

namespace PrimitiveList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentList();
        }
        static void PlayWithStudentList()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { });
            students.Add(new Student() { });
            foreach (var x in students)
            {
                Console.WriteLine(x);
            }
        }
        static void PlayWithPrimitiveListV2()
        {
            //Hàng chuẩn, chơi list<generic> để ko lộn xộn trong vùng new
            List<int> arr = new List<int>();
            arr.Add(1);
            arr.Add(20);
            arr.Add(-200);
            //arr.Add("Hello");

            Console.WriteLine("The size: " + arr.Count); //3 biến 3 value
            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine(arr.ElementAt(i)); // giống .get(i)
            }
        }
        static void PlayWithPrimitiveList()
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(1709);
            arr.Add("Bình");
            arr.Add(true);
            arr.Add(new Student() { });
            //ArrayList<Student> arr = new ArrayList<Student>();
            //Array List ko hỗ trợ generic như bên Java
            Console.WriteLine($"There is/are {arr.Count} in list: ");
            //for each thẳng tiến nếu mún, for count cuối mảng thẳng tiến
            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
}

//để lưu nhiều dữ liệu (primitive, object) trong ram, ta dùng nhóm class thay cho mảng để fix cho những hạn chế của mảng
//những class này khi nó được new thì bên trong vùng new này sẽ dự định chứa nhiều biến khác
//Y chang vùng new mảng sẽ chứa nhiều biến bên trong
//Khác mảng: Vùng nhớ này co giãn chứa nhiều thì nở ra, chứa ít thì hẹp lại, xóa thì mất luôn cái xóa... co giãn linh hoạt
//Nồi cơm thạch sanh, túi anh em cây khế
//Chúng sẽ gồm nhiều interface, nhiều abstract class        nhiều class cụ thể
//ko new được, vì chứa hàm ko code                          new được, concrete class
//abstract class, interface: List                Set                       Map
//concrete class, new được: ArrayList         HashSet, TreeSet        HashMap, TreeMap
//                         vào thứ tự        ngẫu nhiên có sắp xếp    
//                         ra thứ tự nấy

//khai báo: List<Student> arr = new List<Student>(); //vỡ mặt, vì sẽ sinh ra cỡ 20 hàm ko code, yêu cầu code tiếp, implement -> annoymous class 1 câu chuyện khác

//Khai cha new con
//List<Student> arr = new ArrayList<>();
//Khai con new con, chuyện quá quen
//ArrayList<Student> arr = new ArrayList<>();
//ArrayList ko bà con gì với Lít
//ArrayList chứa cái gì bên trong cũng oke, new đc, concrete class nhưng nó ko generic, thoải mái add bên trong data nào cũng đc
//List Concrete class luôn, tức là new đc ngay và luôn, và xài generic, tức là chỉ add 1 loại data type ~ y chang cabinet<> nhà mình
//List<Student> List<Lecture> okie
//Nha sĩ khuyên dùng: Dùng list, ko dùng ArrayList, thằng ArrayList ko ép đc data type đưa vào cùng 1 style