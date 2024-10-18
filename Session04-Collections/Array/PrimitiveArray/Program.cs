namespace PrimitiveArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithPrimitiveListV3();
        }
        static void PlayWithPrimitiveListV3()
        {
            //int[] arr = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //new mà k cần chỉ kích thước mảng, số biến bên trong mảng nhưng ép phải gán sẵn value cho các biến trong mảng
            //do đó kích thước mảng bằng số value đưa vào
            Console.WriteLine("The List of numbers:");

            //với mọi biến x, x là 1 con số int, x mang giá trị của từng phần tử trong arr, arr là 1 nhóm trong 10 biến int
            //x là con int mang giá trị arr[0], arr[1], arr[2]
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            //dùng foreach không bao giờ bị lo tràn mảng
            //nhưng... (qua tuần học)

            //chơi với mảng thì ta dùng cách khai báo nào???
            //xin mảng trước đi đã, từ từ gán value
            //ví dụ: ta cần lưu lượng mưa của 10 năm, 3650 
            //365 ngày x 10 = 3650
            double[] rainVolume = new double[3650];
            //từ từ gán lượng mưa mỗi ngày
            //dù mảng trừ hao nhiều biến nhập sau, nhưng vẫn là fixed kích thước -> ta cần sự linh hoạt thêm bớt kích thước mảng -> list/ arraylist và thứ tương đương... xuất hiện
            rainVolume[0] = 20.0;
        }
        static void PlayWithPrimitiveListV2()
        {
            //int arr; //biến lẻ; chỉ 1 biến
            int[] arr = new int[10] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //object initialization nhưng ép phải đủ các biến đã xin
            Console.WriteLine("The List of numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        static void PlayWithPrimitiveList()
        {
            int a, b, c, d, e, f, g, h;
            a = 5;
            //khai báo biến là gán luôn value
            //declare,      assign
            int a1 = 5, b1 = 10, c1 = 15, d1 = 20;
            //Console.WriteLine(a);
            //Console.WriteLine(b); biến ko đc gán giá trị trước đố cầm xài ở các câu lệnh, trừ lệnh gán giá trị cho biến
            //b = b + 5; // vỡ mặt
            //b = 5; // okie
            //Mỗi biến tốn 1 vùng ram, mỗi biến 4 byte
            //Khai báo mảng la khai báo sỉ
            //Khai báo mảng là khai báo nhiều biến, cùng lúc, cùng kiểu (data type), ở sát nhau trong ram và cùng chung 1 tên
            int[] arr = new int[500];

            //500 biến cùng tên arr
            //Các biến có tên như sau: arr[0], arr[1], arr[2], ...
            //Đây là các biến int như truyền thống int a, b, c
            //nhà có 500 đứa trùng tên nhau, thì phải có cách để phân biệt qua tên đệm, tên phụ
            //arr[index - tên đệm, tên phụ, tính từ 0]
            //Y chang bình[thứ 2]
            //            [thứ 1]
            //arr[i]

            //in thử các biến trong mảng
            //ta đang có 500 biến int đã được cấp trong ram
            Console.WriteLine("Var 1: " + arr[0]);
            Console.WriteLine("Var 2: " + arr[1]);
            Console.WriteLine("Var 3: {0}", arr[2]);
            Console.WriteLine("Var 4: " + arr[3]);
            Console.WriteLine($"Var 5: {arr[4]}");
            Console.WriteLine("Var 499: " + arr[498]);
            Console.WriteLine("Var 500: " + arr[499]);

            //mảng khi khai báo thì biến bên trong vùng new
            //còn gọi là các phần tử của mảng - element of array



            //arr.Length {get; ko có set vì giữ kích thước mảng cố định, xin ram ko dễ}
            Console.WriteLine("The List of 500 numbers");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            //Gán giá trị cho từng biến trong mảng
            arr[0] = 5; //int a = 5
            arr[1] = 10; //int b = 10
            arr[10] = 15; // arr[i] chằng qua là biến int
            arr[20] = 20; //Mảng là 1 đống các biến
            arr[100] = 25;
            arr[498] = 30;
            arr[499] = 35;
            Console.WriteLine();
            Console.WriteLine("The List of 500 numbers again");
            for (int i = 0; i < 500; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            //cấm vượt biên giới mảng nếu ko bị exception out of range (bound), runtime giết app ngay và luôn
        }
    }
}
//Nếu nói về cách lưu trữ info trong ram, ta có 2 kiểu dữ liệu: đơn giản và phức tạp
//đơn giản: chỉ 1 value đơn lưu trong ram, đủ info, đủ ý nghĩa. Trong java gọi là primitive data type, trong c# ta gọi là value-type
//Đó là: int, long , float, double, char, bool
//Tốn 1 vùng ram
//2. Phức tạp: Là nó chứa nhiều info hợp thành 1 thứ duy nhất gọi là object
//{"id" : "SE181532", "name": "Thanh Bình", "yob": 2004, "gpa": 8.6}
//Java và C# cùng gọi đám data phức tạp này là object data
//Đó là String/string, File, StringBuffer, String Tokenizer, Dog, Cat, Person, Bill, Order...
//Tốn 2 vùng

//1. Có biến là có vùng ram được cấp
//2. Có new là có vùng ram bự được cấp, chứa các info của object
//3. Biến primitive/value type chỉ tốn 1 vùng ram
//4. Biến object là con trỏ lưu tọa độ vùng new bự
//  Chấm để đi vào vùng new bự gọi hàm public của vùng new bự
//5. primitive ko chấm, vì vào vùng ram primitive là có value xài luôn
//     int yob      = 2004;
//     Student s    = new Student(...) {...};
//biến là tên gọi   cho value đơn giản hay phức tạp

//Ta đã học cơ bản xong về object để lưu trữ dữ liệu phức tạp - object
//Ta cần học thêm cách lưu trữ dữ liệu nhiều object

//discount là tên gọi cho 10% 
//pi là tên gọi cho 3.14
//Ta có 2 loại mảng: Mảng primitive và mảng object