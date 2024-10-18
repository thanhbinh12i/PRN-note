namespace PassByReferenceOutKeyword
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int x = 2204;
        //    PlayWithOut(out x);
        //    Console.WriteLine("x = " + x);

        //    int y;
        //    PlayWithOut(out y);
        //    Console.WriteLine("y = " + y);

        //    //ChatGPT
        //    PlayWithOut(out int z); //inline style: khai báo biến ngay trong lời gọi hàm out cho tiện
        //    Console.WriteLine("z = " + z);
        //}
        static void Main(string[] args)
        {
            //                          inline declaration
            int sumA = SumIntegerListV2(out int sumO, out int sumE);
            Console.WriteLine("Sum all: " + sumA);
            Console.WriteLine("Sum odds: {0}", sumO);
            Console.WriteLine($"Sum evens: {sumE}");
        }
        //khi chơi hàm out, ko cần gán giá trị cho biến đầu vào, vì nó sẽ bị đè lên giá trị mới, do out hứa sẽ có giá trị trả về

        //out ~~~ return
        //hàm có từ khóa out ở tham số, sẽ biến hàm này có return
        //em hứa sẽ có 1 giá trị của n được tạo ra ở trong hàm, em hứa sẽ return n
        //hàm mà có out, thì biến trong hàm chính là con trỏ trỏ đến biến ngoài hàm
        //khi gọi hàm out, chính là đưa địa chỉ biến gốc cho hàm out sửa -> pass by reference
        //hàm out chiếu ra biến ngoài, thay đổi biến ngoài
        //trong hàm mà sửa, bên ngoài bị sửa theo

        //pass by reference xảy ra với: 
        //- Biến object, ví dụ Student s, Lecture l, Dog chiHuHu
        //Truyền thống xưa nay

        //- Biến primitive/ value-type: int long float double char bool/boolean đi kèm từ khóa out, ref
        //Khi nào dùng out???
        //Challenge: Viết hàm trả về: Tổng của các số từ 1..10 (Dễ ktra kết quả)
        //                    trả về: Tổng các sỗ chẵn, tổng các số lẻ, trả về có bao nhiêu số nguyên tố
        //Chỉ được viết 1 hàm
        static int SumIntegerList(out int sumOdds, out int sumEvens)
        {
            int sumA = 0;
            var sumO = 0;
            var sumE = 0;
            for (int i = 1; i <= 10; i++)
            {
                sumA += i;
                if (i % 2 == 0)
                {
                    sumE += i;

                }
                else
                {
                    sumO += i;
                }
            }
            sumOdds = sumO;
            sumEvens = sumE;
            return sumA;

        }
        static int SumIntegerListV2(out int sumOdds, out int sumEvens)
        {
            int sumA = 0;
            sumOdds = 0;
            sumEvens = 0;
            for (int i = 1; i <= 10; i++)
            {
                sumA += i;
                if (i % 2 == 0)
                {
                    sumEvens += i;

                }
                else
                {
                    sumOdds += i;
                }
            }
            return sumA;

        }
        static void PlayWithOut(out int n)
        {
            n = 6789; //sbtc hứa trả về qua ngả parameter
        }
    }
}
