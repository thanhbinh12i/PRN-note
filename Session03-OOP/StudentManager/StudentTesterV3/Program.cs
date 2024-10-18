using StudentTesterV3.Entities;

namespace StudentTesterV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("SE181532", "Binhdaynee", 2004, 8.6);
            Student student1 = new Student();
            Student student2 = new();
            Student student3 = new("SE181532", "Binhdaynee", 2004, 8.6);
            var student4 = new Student();

            Console.WriteLine("Student full info: " + student); //gọi thầm tên em
            Console.WriteLine("Student name: " + student.Name); //

            var binh = new Student(yob: 2004, gpa: 8.7, name: "Thanh Bình", id: "SE181532");
            Console.WriteLine($"Bình info: {binh}");
            //Sử dụng get set ngay khi new ~~~
            var binhne = new Student();
            Console.WriteLine("Bình info at first: {0}", binhne);
            //Điền info qua con đường set() kiểu mlem
            //.SetName() .SetYob()
            binhne.Id = "SE181532";
            binhne.Name = "Bình Nek";
            binhne.Gpa = 8.7;
            binhne.Yob = 2004;
            //get set trở nên tự nhiên hơn như đnag xài biến, biến bản chất bao hàm sẵn ý nghĩa set() get() rồi
            Console.WriteLine($"Binh nek full info after setting {binhne}");
            var binhidol = new Student()
            {
                Id = "SE181532",
                Name = "Bình Idol Nè",
                Yob = 2004,
                Gpa = 8.7
            };
            // new và set gọi cùng lúc thay vì gọi riêng
            //cú pháp này gọi là object initialization
            //tạo object đồng thời gán luôn các backing field qua ngả property
            Console.WriteLine("Binh Idol Info: " + binhidol);
        }
    }
}
