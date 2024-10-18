namespace PassByValue
{
    internal class Program
    {
        //vercel, netlify, aws, azure
        static void Main(string[] args)
        {
            int n = 10;
            PowerByTwo(n);
            Console.WriteLine("In main, after calling method, n now is " + n);
        }
        //Truyền thái y style tham trị, giống C, Java -- Pass By Value
        //Ta dùng trong tình huống datatype là kiểu
        //primitive (java): int, long, float, double, char, boolean...
        //value-type (C#): int, long, float, double, char, bool...
        //trong hàm mà sửa, bên ngoài vẫn giữ nguyên
        //CHALLENGEL: Viết hàm nhận vào 1 con số, bình phương nó lên
        static void PowerByTwo(int n)
        {                     //nhận vào n và bình phương n
            Console.WriteLine("in method, before changing, n is " + n);
            n = n * n; //Math.Pow(n,2)
            Console.WriteLine("in method, after changing, n now is {0}", n);
        }
        static void PowerByTwoV2(in int n)
        {            
            //in mang ý nghĩa làm cho biến đầu vào trở thành read only, cấm sửa giá trị đầu vào, chỉ được dùng

            //CHANGLLENGE Ở NHÀ: Điều gì xảy ra nếu tham số đầu vào là (in Student x), biến đầu vào là object thì in sẽ mang ý nghĩa gì, readonly ntn.
            //In cấm biến = 1 giá trị khác; = giá trị khác là thay đổi value in cấm thay đổi value

            //n = n * n;
        }
    }
}
