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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WarShips.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        Frame frame;
        EditPage editPage;
        public RegPage(Frame frame, EditPage editPage)
        {
            this.editPage = editPage;
            this.frame = frame;
            InitializeComponent();
        }

        private void Tb_nickname_MouseEnter(object sender, MouseEventArgs e)
        {
            if (tb_nickname.Text == "Введите никнейм!")
                tb_nickname.Text = "";
            return;
        }

        private void B_start_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(editPage);
        }
    }
}
