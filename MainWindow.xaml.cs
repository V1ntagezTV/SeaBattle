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
using WarShips.GameObject;

namespace WarShips
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Pages.EditPage editPage = new Pages.EditPage();
            Pages.FightPage fightPage = new Pages.FightPage();
            Pages.RegPage regPage = new Pages.RegPage();
            frame.Navigate(editPage);
            //Player Insur = new Player("Insur", "Black");
            //Player Alexandr = new Player("Leha", "Red");

            //Alexandr.map.SetShip(5, 4, "right", 3);
            //Insur.map.SetShip(2, 1, "right", 3);

            //Alexandr.Ready = true;
            //Insur.Ready = true;

            //Insur.PlayerAtack(Alexandr, 3, 3);
            //Alexandr.PlayerAtack(Insur, 4, 4);
            //Insur.PlayerAtack(Alexandr, 6, 3);

            //MapShow(Insur, TextBlock);
            //MapShow(Alexandr, TextBlock1);
        }
    }
}
