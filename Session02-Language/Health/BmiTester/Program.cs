using Bmi;
//import Bmi
namespace BmiTester
{
    internal class Program
    {
        //trong class chứa: fields/ attributes và method => gọi chung là members of a class
        //fields /attributes: có 2 dạng method cũng vậy
        //static                   non-static
        //class-level variable     instance variable
        static void Main(string[] args) //svm tab ~ psvm bên J
        {
             Console.WriteLine($"BMI: {BmiCalculator.GetBmi(62, 1.67)}"); 
        }
        //static void Main(string[] args)
        //{
        //    //PrintBmiV2(62, 1.67);
        //    double bmi = GetBmi(62, 1.67);
        //    Console.WriteLine("BMI: " + bmi);
        //    Console.WriteLine("BMI: {0}", bmi);
        //    Console.WriteLine($"BMI: {bmi}");
        //    Console.WriteLine("BMI: " + GetBmi(62, 1.67));
        //    Console.WriteLine($"BMI: {GetBmi(62, 1.67)}");
        //}
        //Challeng #1: Viết hàm tính và in ra chỉ số BMI - Body Mass Index - Chỉ số khối của cơ thể - Đo tình trạng mập ốm của ai đó theo cân nặng, chiều cao
        //bmi = weight kg/ (height m) ^2
        //bmi [18.5....24.9] => ổn

        //triết lý thiết kế hàm: 1 hàm được thiết kế tốt thì hàm đó nên thuộc style
        //hàm nhận đầu vào và trả ra kết quả. hàm không nên có lệnh nhập và in trong code hàm
        //lý do thiết kế hàm style nhận vào và trả ra, hàm sẽ được dùng trong các biểu thức khác

        //vi dụ, lúc ta viết hàm kiềm tra n có là số nguyên tố không
        //for (int i=2; i<n; i++)
        //giang hồ chứng minh chỉ cần for đến căn bậc 2
        //for (int i=2; i<=Math.sqrt(n); i++)

        //Kĩ thuật cái dây nịt
        //GetBmi: tên hàm - signature of a method
        //{... code của hàm - body of a method}
        //{ thân hàm, implementation of method}
        //nếu 1 hàm chỉ có duy nhất 1 lệnh thì ta có thể áp dụng quy tắc rút gọn để hàm chỉ còn cái dây nịt mức tối thiểu
        //ta dẹp bỏ {, return, } chỉ còn tên hàm nối với code thân hàm qua kí tự =>
        //tên hàm => thân hàm
        //kĩ thuật rút gọn hàm chỉ có 1 lệnh được gọi là expression bodied, expression body
        //thân hàm viết giống như biểu thức !!!
        //cấm tuyệt đối ko được nhầm lẫn => với 1 khái niệm khác - biểu thức lambda - lambda expression
        //cũng xài chung 1 kí hiệu => học sau!!! 

        static double GetBmiV2(double weight, double height) => weight / Math.Pow(height, 2);
        
        static double GetBmi(double weight, double height)
        {
            return weight / Math.Pow(height, 2);
        }
        static void PrintBmi(double weight, double height)
        {
            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine($"BMI (w: {weight}; h: {height}) = {bmi}");
        }
        static void PrintBmiV2(double weight, double height)
        {
            double bmi = weight / (height * height);
            Console.WriteLine($"BMI (w: {weight}; h: {height}) = {bmi}");
        }
    }
}
