using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyCV
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string userName = UserNameTextBox.Text;
            MessageBox.Show("UserName: " + userName);

            // Gọi cửa sổ MainWindow lên, cừa sổ này là 1 class, do đó ta dùng biến object, new và .show như mọi class bình thường
            MainWindow myCV = new MainWindow(); // tốn vùng ram nhưng chưa render
            //myCV. đổi các info của object, của cửa sổ , đổi màu, đổi chữ, title, vị trí
            //myCV.Show(); //show kiểu này thì có thể mở cùng lúc nhiều cửa sổ
            //cứ bấm nút là mở
            //nếu mở nhiều cửa sổ giống nhau ta khó kiếm soát dữ liệu
            //ví dụ nếu đây là màn hình add mới 1 user, cùng lúc ta mở 50 màn hình add mới, khó kiểm soát, ta quyết định tại 1 thời điểm
            //mở 1 cửa sổ , chế độ 1 cửa sổ
            //gọi là show theo style giao tiếp - lắng nghe - DIALOG
            myCV.ShowDialog();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult ans = MessageBox.Show("Bạn có muốn thoát không?", "Xin chào!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ans == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
