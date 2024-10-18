namespace PassByReferenceRefKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 19;
            PlayWithOut(out x);
            Console.WriteLine("x = " + x);

            PlayWithOut(out int y);
            Console.WriteLine("y = " + y);

            //xài ref
            int z = 6969;
            PlayWithRef(ref z); //vì hàm không hứa nên z phải có giá trị sẵn để đảm bảo tính logic: gọi hàm thì phải có value hàm là xử lí info
            Console.WriteLine("z = " + z);

            //PlayWithRef(ref int zzz); ko hỗ trợ inline với ref, do inline chỉ mang ý nghĩa khai báo biến, ko gán value
        }
        static void PlayWithRef(ref int n)
        {
            //trong hàm thay đổi, bên ngoài thay đổi
            //ref: ko hứa sẽ có value trả ra, nhưng nếu có bên ngoài sure bị đổi theo
            n = 10;

        }
        static void PlayWithOut(out int n)
        {
            //out: Hàm hứa chắc kèo sẽ có 1 n được tạo ra, được gán giá trị
            //trong hàm thay đổi, bên ngoài đổi theo
            n = 3979;
        }
        //out, ref là 2 keyword sẽ biến tham số đầu vào trở thành con trỏ, pointer, reference, tham chiếu bất chấp biến này là primitive hay là biến object
        //biến object Student s, bản chất đa là reference rồi!!!

    }
}
