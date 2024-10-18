using ObjectArray.Entities;

namespace ObjectArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentListV4();
        }
        static void PlayWithStudentListV4()
        {
            //vừa khai báo mảng (nhiều biến Student) và gán ngay giá trị cho các biến sinh viên
            //Student[] arr = { new Student(), new Student(), new Student() { } };

            Student[] arr = { new () { Id = "SE1", Name = "Student 1", Yob = 2004, Gpa = 8.6 },
                              new () { Id = "SE2", Name = "Student 2", Yob = 2004 },
                              new Student() { Id = "SE3", Name = "Student 3", Yob = 2004 }
                            };
            Console.WriteLine("The List of Student");
            foreach (var x in arr)
            {
                //mỗi x thuộc arr (arr là 1 đống biến Student khác)
                Console.WriteLine(x);
            }
        }
        static void PlayWithStudentListV3()
        {
            Student[] arr = new Student[500];
            arr[0] = new Student() { Id = "SE1", Name = "Student 1", Yob = 2004, Gpa = 8.6 };
            arr[1] = new Student() { Id = "SE2", Name = "Student 2", Yob = 2004 };
            arr[2] = new Student() { Id = "SE3", Name = "Student 3", Yob = 2004 };
            arr[3] = new Student() { Id = "SE4", Name = "Student 4", Yob = 2004 };
            arr[4] = new Student() { Id = "SE5", Name = "Student 5", Yob = 2004, Gpa = 8.6 };
            arr[5] = arr[4]; // 2 chàng 1 nàng

            //chứng minh 5 và 4 là 1 sv, 1 sv cụ thể được đến 2 lần, đưa vào danh sách 2 lần
            Console.WriteLine("The List of 6 Students");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(arr[i]);
            }
            arr[5].Name = "Binh day neee";
            Console.WriteLine("The List of 6 Students after changing");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void PlayWithStudentListV2()
        {
            //Lưu trữ hồ sơ của 500 sinh viên; khai báo lẻ chết chắc
            Student[] arr = new Student[500];
            //Có sinh viên nào chưa???, mới có 500 biến th mà ~s1 s2 s3 ~ 500 ghế 500 chỗ ngồi nhưng chưa trỏ, chưa có Student
            //Console.WriteLine(arr[0].Name); null reference
            //mặc định các biến trong mảng nếu k được gán value thì sẽ mang default. mảng object thì default null cho các biến thứ [i]
            //[i].Name lấy đâu Name ở đáy ram
            //Gán giá trị cho vùng ram
            //có 500 biến Student, vậy mỗi biến sẽ trỏ vùng new Student(){}
            arr[0] = new Student() { Id = "SE1", Name = "Student 1", Yob = 2004, Gpa = 8.6 };
            arr[1] = new Student() { Id = "SE2", Name = "Student 2", Yob = 2004 };
            arr[2] = new Student() { Id = "SE3", Name = "Student 3", Yob = 2004 };
            arr[3] = new Student() { Id = "SE4", Name = "Student 4", Yob = 2005, Gpa = 8.6 };
            arr[4] = new Student() { Id = "SE5", Name = "Student 5", Yob = 2006 };
            Console.WriteLine("The List of Students: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine("The List of 500 Names: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i].Name); //[i] là student, trỏ 1 vùng new
            //}
            //Chốt hạ: Cấm tuyệt đối for đến hết mảng của mảng object vì phần còn lại của mảng chưa được trỏ vào vùng new Student()
            //Khi gọi hàm của biến [i] sẽ đi đến đáy ram (null) để tìm hàm mà chạy sẽ bị exception, null reference

            //khi chơi với mảng, ko for hết mà chỉ for đến số phần tử được gán vùng new!! với mảng, for đến biến count, count chính là số phần tử của mảng khi đã được gán giá trị
            //Khi chơi với mảng, luôn có biến count ban đầu = 0, gán 1 phần tử, count++ và gán từ từ đầy mảng
            //arr[count] = new Student(){}
            //count++

            //cấm tuyệt đối for each, vì cũng quét hết mảng, chấm cái public thứ [i] coi chừng toang null reference
            foreach (Student item in arr) // item là biến Student và có thể =
            {                             //item = arr[0], item = arr[1], với mọi   
                Console.WriteLine(item.Name);
            }//chết ở những thằng phía sau do đang là null



        }
        static void PlayWithStudentListV1()
        {
            //Lưu trữ hồ sơ của 5 sinh viên
            //Dùng truyền thống, khai báo lẻ từng biến
            Student s1, s2, s3, s4, s5; //khai báo biến trước, rồi trỏ vùng new sau, gán value sau

            //s1 = null;
            //Console.WriteLine(s1);
            //Console.WriteLine(s1.Name);//trỏ đáy ram, code đâu mà chạy, Exception
            //khai báo trước, gán value sau

            s1 = new Student() { Id = "SE1", Name = "Student 1", Yob = 2004, Gpa = 8.6 };
            s2 = new Student() { Id = "SE2", Name = "Student 2", Yob = 2004 };
            s3 = new Student() { Id = "SE3", Name = "Student 3", Yob = 2004 };
            s4 = new Student() { Id = "SE4", Name = "Student 4", Yob = 2004 };
            s5 = new Student() { Id = "SE5", Name = "Student 5", Yob = 2004, Gpa = 8.6 };
            //thích gọi hàm set nào thì gọi
            //in danh sách sinh viên
            Console.WriteLine("The List of 5 students:");
            Console.WriteLine(s1); //gọi thầm tên em
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            //Khai báo lẻ, dễ làm, dễ hiểu
            //nhưng tốn nhiều lệnh, 5 lệnh nhưng bản chất giống nhau
            //Mảng sẽ giúp khai báo nhiều biến, giúp giảm bớt số lệnh mà đạt cùng kết quả





        }
    }
}
