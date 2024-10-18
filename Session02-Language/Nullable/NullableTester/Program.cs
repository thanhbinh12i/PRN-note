namespace NullableTester
{
    //trong khuôn viên namespace chỉ chứa các class và những thằng ngang cơ class: interface, delegates

    //có thể khai báo class gộp chung trong 1 tập tin vật lý như bài này hoặc tách riêng mỗi class 1 tập tin .cs riêng 
    //nhưng chung hay riêng thì đều phải khai báo hộ khẩu - nhà/ class ở hộ khẩu - namespace nào
    //nha sĩ khuyên dùng: trừ tình huống đặc biệt, thì nên tách mỗi class 1 tập tin .cs cho dễ dàng quản lí source code
    //và khai báo chung namespace
    //1 project có thể có nhiều namespace
    //DAO, Dao, DTO, Dto
    interface Comparable
    {

    }
    public class Student
    { //Phá OOP 1 chút, k dùng encapsulation
        //mặc áo xuyên thấu
        public string id;
        public string name;
        public int yob;
        public double gpa;

        //ko che giấu thông tin, public là ai cũng thấy ~ bài viết public, biography public
        public void FlexProfile()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine($"Yob: {yob}");
            Console.WriteLine($"GPA: {gpa}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student student = new Student();
            //biến obj            object: vùng ram chứa info của object 
            //                new: xin vùng ram bự ~ malloc() bên C
            student.id = "SE181532";
            student.name = "Binh day neeeee";
            student.yob = 2004;
            student.gpa = 8.6;

            student.FlexProfile();

            student = null;
            //student.FlexProfile();
            //biến object = null nghĩa là trở vào đáy ram, ko có code ở đó, chấm 1 cái gì đó, gọi hàm của class sẽ bị Null Reference Exception do đáy ram ko có code để mà chạy
            //Dùng Null để làm j
            //1. Hủy vùng object đã new, do biến đã trỏ vùng khác diều đứt dây
            //2. Dùng để nói biến ko đang trỏ object nào
            //2.1 khi bạn search 1 object trong list, tìm 1 sinh viên trong 500 ae
            //tìm ko thấy thì trả về null
            //s = null, return s    
            //dùng toán tử is null, == null, != null để check biến có đang trỏ vào ai hay không
            if( student is null)
            {
                Console.WriteLine("No student is specified. No thing to print");
            }
            else
            {
                student.FlexProfile();
            }
            //trong db có khái niệm null trên cell (hàng cột giao nhau), cột điểm pe, điểm te
            //null mang ý nghĩa rằng cột/cell đó có value nhưng chưa biết chính xác là value gì, từ từ sẽ cóm chưa xác định rồi sẽ có
            //có 1 cái gì đó diễn tả trạng thái tạm thời bỏ trống, sau đó điền vào sau
            //null là 1 trạng thái, tình trạng của cột dữ liệu chưa xác định được value!!!
            //ánh xác ngược lên code (code class student được map thành dòng trong table) làm sao để diễn tả cột điểm chưa xác định trong lập trình
            /*double pe = null;*/ // biến primitive - giá trị đơn ko có khái niệm null - giá trị phải là con số, cái chữ nào đó !!! ko diễn tả được trạng thái em chưa có gì, em chưa xác định
            //java: int -> Integer mang null (wrapper class)
            //long Long, double Double, char Character
            //C#: dùng toán tử/ keyword/ kí hiệu ? đi kèm primitive/value-type giúp mở rộng primitive cho phép mang thêm giá trị null
            double? pe = null; //y chang double, chỉ thêm value null. Ta sài is null == null != null như truyền thống để check điểm
            pe = 10;
            if (pe is null)
            {
                Console.WriteLine("Điểm chưa có em ơi, chờ đi ...");

            }
            else
            {
                Console.WriteLine("Điểm nè em: " + pe);
            }
            //? Gắn với các datatype primitive/ value-type giúp các biến của loại datatype mời này được mang ý nghĩa biến chưa xác định chính xác value, từ từ sẽ có
            //Ta có: int? long? float? double? char? bool?
            //đám này được gọi là nullable data type
            //em có mang giá trị null ngoài giá trị truyền thống
            //Vậy Student? s; Lecturer? l; Product? p 
            //    Student  s; Lecturer  l; Product  p
            //? ko là vấn đề, vì biến object sinh ra đã sẵn được mang null
            //đôi khi mình cần Student? vì IDE hay warning khi mình gán s = null;
            //hàm search hay dùng null để nói rằng chưa biết ko tìm thấy
            //value = null để nói rằng thông tin của biến tạm thời chưa xác định    
        }
    }
}
