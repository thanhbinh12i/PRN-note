namespace NumbersTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumOddsAndEvens();
        }

        static void PlayWithVariables()
        {
            //biến là vùng ram được đặt tên, chiếm 1 số byte, dùng để chứa dữ liệu: số, chữ, đối tượng
            int a = 10, b = 20; //vừa khai báo vừa gán value - declare & assign
            int c;  //khai báo trước
            c = 30; //gán value sau

            var d = 40;
            //var: chưa chỉ ra, không thèm khai báo data type
            //nhưng biến bắt buộc phải thuộc về data type nào đó
            //ở đây có sự suy luận, nhìn value biết data type
            //TYPE INFERENCEC - SUY LUẬN KIỂU - DATA TYPE ĐC SUY LUẬN TRÊN VALUE
            //var e = 50, f = 60; cấm
            //từng biến lẻ thì ok
            //var g;
            //g = 100;
            //khai báo biến var phải gán ngay value thì mới bố trí đc ram, khác cách khai báo truyền thống
        }

        static int SumOddsAndEvensV2()
        {
            var sumOdds = 0;
            var sumEvens = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    sumEvens += i;
                else
                    sumOdds += i;
            }
            return sumOdds; //return là trả về giá trị đồng thời thoát hàm, dừng hầm ngay và luôn
            //hàm truyền thống chỉ trả về 1 value
            //C có hàm nhận vào pointer, con trỏ, truyền thái y style tham chiếu!!! pass by refenrence
        }

        //CHANLENGE #1: tính tổng của các số chẵn, tính tổng các số lẻ từ 1...10, sau đó nâng cấp hàm trả về kết quả
        //1 3 5 7 9  -> expected value = 25
        //2 4 6 8 10 -> expected value = 30

        static void SumOddsAndEvens()
        {
            var sumOdds = 0;
            var sumEvens = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    sumEvens += i;
                else
                    sumOdds += i;
            }
            //if, else, for không cần {} nếu chỉ có 1 lệnh
            Console.WriteLine($"Sum odds: {sumOdds}");
            Console.WriteLine($"Sum evens: {sumEvens}");
        }

        //CHANLENGE #1: viết hàm in ra các số in ra các số từ 1 đến 100 và tính tống của chúng và in luôn
        static void SumIntegerList()
        {
            //bài toán con heo đất
            var sum = 0;

            //in dãy rồi cộng sau, hoặc vừa in vừa cộng, hoặc cộng rồi in
            Console.WriteLine("The list of numbers from 1...100");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of numbers from 1...100 is: {sum}");
            //màn hình hy vọng sẽ in ra 5050 -> expected value
            //thực tế lúc run hàm, chạy app -> actual value
            //nếu expected == actual -> code ngon
            //nếu expected != actual -> bug rồi
            //swt301: unit testing
        }
    }
}