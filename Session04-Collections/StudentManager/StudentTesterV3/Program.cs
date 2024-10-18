using StudentTester.Entities;
using StudentTesterV2.Services;

namespace StudentTesterV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 5, 10, 15, 20, 25, 30, 35, 40 };

            a = b; // 2 chàng 1 nàng, mảng cũ của a gồm 1 2 3 4 5 bị mồ côi, bị CTMTDT dọn dẹp, bộ gom rác của runtime

            //tên mảng là biến tham chiếu trỏ vùng new
            //một lần nx 2 biến object bằng nhau nghĩa là trỏ trùng, 2 chàng 1 nàng
            //nếu tên mảng, tên biến object đưa qua tham số hàm, chẳng qua cũng là 2 chàng 1 nàng, trỏ cùng luôn
            //Search trả về object, ko phải, trỏ vào vùng new tìm thấy

        }
        static void PlayWithGeneric()
        {
            //Mua tủ đựng hồ sơ sinh viên, hồ sơ gv, mỗi nhóm 1 tủ khác nhau
            Cabinet<Student> tuSV = new Cabinet<Student>(500);
            Cabinet<Lecturer> tuGV = new Cabinet<Lecturer>(500);

            tuSV.Add(new Student() { Id = "SE181532", Name = "Thanh Bình", Yob = 2004, Gpa = 8.6 });
            tuSV.Add(new Student() { Id = "DE181532", Name = "Binh ne", Yob = 2004, Gpa = 8.6 });
            tuSV.PrintList();

            Student s = new Student() { Id = "HE181532", Name = "Binh hoc PRN212", Yob = 2004, Gpa = 8.7};
            tuSV.Add(s);

            // biến object này = biến object kia nghĩa là truyền thái y style tham chiếu
            //hàm nhận vào (Student item) item = s bên ngoài
            //arr[i] = item = s = new lẻ thằng SE
        }
    }
}
