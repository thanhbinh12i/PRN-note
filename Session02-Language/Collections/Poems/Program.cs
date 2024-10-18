namespace Poems
{
	//Mỗi tập tin source code sẽ phải thuộc về 1 thư mục nào đó - gọi là xuất thân từ đâu, hay là đang ở căn phòng nào. căn phòng nayfm thư mục đang ở được gọi là package(java), C# gọi là namespace - không gian đặt tên, nơi chứa các class / tập tinh source code
	// ~ package java.util;
	// ~ package poems

	//Tại sao cần có package, namespace: giúp cho việc quản lí nhiều tập tin source code tốt hơn, chia source code về các thư mục theo nhóm chức năng
	//Giúp trong 1 project có nhiều source code, nhiều class có quyền trùng tên nhau, miễn là khác thư mục, khác namespace
	internal class Program
	{
		//field/ attribute/ property và method
	    //static and non-static
		//instance variable & class variable & method
		static void Main(string[] args)
		{
			PrintSongXuanQuynhV6();
			//PrintPath();
			//Console.ReadLine();
		}
		static void PrintSongXuanQuynhV6()
		{
			int year = 1967;
            Console.WriteLine("So'ng " + year); //ghép chuỗi dùng +

			Console.WriteLine("So'ng " + year + " " + (2024 - year) + " na(m");

            Console.WriteLine("So'ng {0} {1} na(m", year, (2024 - year));
			//placeholder, kĩ thuật điền vào chỗ trống trong chuỗi
			//{0} {1}... các biến bắt đầu đếm từ 0

			Console.WriteLine($"So'ng {year} {2024-year} na(m");
			//interpolation: phép nội suy, nhìn sâu vào chuỗi
			//coi có chỗ nào là biến không, nếu có thì thay thế và điền vào
			Console.WriteLine(@"Sóng 1967
Sóng bắt đầu từ gió
Gió bắt đầu từ đâu?
Em cũng không biết nữa
Khi nào ta yêu nhau"); //cw tab ~ sout  in java
		}
		//Challenge #2: In ra đường dẫn tập tin sau
		//C:\Program Files\dotnet
		//C:\news\showbiz
		static void PrintPath()
		{
            Console.WriteLine("C:\\Program Files\\dotnet");
            Console.WriteLine(@"C:\Program Files\dotnet");
            Console.WriteLine(@"C:\news\showbiz");
        }
		//có câu: static chơi với static
		//Challenge #1: In ra bài thơ Sóng của Xuân Quỳnh
		static void PrintSongXuanQuynh()
		{
            Console.WriteLine("So'ng ba('t -da^`u tu+` gio'"); //cw tab ~ sout  in java
			Console.WriteLine("Gió bắt đầu từ đâu");
			Console.WriteLine("Em cũng không biết nữa");
			Console.WriteLine("Khi nào ta yêu nhau");
		}
		static void PrintSongXuanQuynhV3()
		{
			Console.WriteLine("So'ng ba('t -da^`u tu+` gio' \n" +
				"Gió bắt đầu từ đâu \n" +
				"Em cũng không biết nữa\n" +
				"Khi nào ta yêu nhau"); //cw tab ~ sout  in java

			// \n mỗi khi xh trong chuỗi "" thì được hiểu theo nghĩa không phải là in \n mà là in xuống hàng - kí tự đặc biệt
			// kí tự \ đi kèm \n \r \t \a mang 1 ý nghĩa nào đó .. bị biến dạng không còn là in \
			//+ được gọi là toán tử - operator để nối các chuỗi - string concatenation
		}
		static void PrintSongXuanQuynhV2()
		{
			Console.WriteLine("So'ng ba('t -da^`u tu+` gio' \nGió bắt đầu từ đâu \nEm cũng không biết nữa\nKhi nào ta yêu nhau"); //cw tab ~ sout  in java

		}
		static void PrintSongXuanQuynhV4()
		{
            Console.WriteLine("Ôi con sóng ngày xưa\r\nVà ngày sau vẫn thế\r\nNỗi khát vọng tình yêu\r\nBồi hồi trong ngực trẻ\r\n\r\nTrước muôn trùng sóng bể\r\nEm nghĩ về anh, em\r\nEm nghĩ về biển lớn\r\nTừ nơi nào sóng lên?\r\n\r\nSóng bắt đầu từ gió\r\nGió bắt đầu từ đâu?\r\nEm cũng không biết nữa\r\nKhi nào ta yêu nhau");
        }
		//@ đứng trước 1 cái chuỗi sẽ phế võ công tất cả các ký tự đặc biệt trong chuỗi trở lại ký tự bình thường
		//\n sẽ in ra \n thay vì xuống hàng
		//@ biến chuỗi thành có sao in vậy, wysiwyg
		//@ gọi là kĩ thuật chuỗi nguyên bản - raw string
		//@ gọi là verbatim string
		//có bên java luôn
		
		//khi nào dùng verbatim
		//1. phế võ công kí tự đặc biệt trong chuỗi
		//2. dùng để lưu tên của các đường dẫn tập tin, thư mục, chuỗi kết nối csdl do tên server hay kèm theo kí tự đặc biệt -> trả chuỗi về nguyên bản thì chuỗi không bị lỗi sai ý nghĩa
		static void PrintSongXuanQuynhV5()
		{
			Console.WriteLine(@"Ôi con sóng ngày xưa
				<html>
					<head>
						 <title>Xin chào </title>
					</head>
					<body>
					</body>
				</html>
				Và ngày sau vẫn thế
				Nỗi khát vọng tình yêu
				Bồi hồi trong ngực trẻ

				Trước muôn trùng sóng bể
				Em nghĩ về anh, em
				Em nghĩ về biển lớn
				Từ nơi nào sóng lên?

				Sóng bắt đầu từ gió
				Gió bắt đầu từ đâu?
				Em cũng không biết nữa
				Khi nào ta yêu nhau");
		}
	}
}
