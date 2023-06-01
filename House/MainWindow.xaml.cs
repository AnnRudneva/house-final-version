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
using RoomLibrary1;

namespace House
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room = new Room();
        LivingRoom livingRoom = new LivingRoom();
        Office office= new Office();
        List<Room> lstRooms = new List<Room>();//создание списка комнат
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BaddRoom_Click(object sender, RoutedEventArgs e)
        {
            Room room = new Room();
            room.RoomLenght = Convert.ToDouble(TBLenghtR.Text);
            room.RoomWidth = Convert.ToDouble(TBWidthR.Text);
            lstRooms.Add(room); //добавление в список
        }

        private void BaddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            LivingRoom livingRoom = new LivingRoom();
            livingRoom.RoomLenght = Convert.ToDouble(TBLenghtL.Text);
            livingRoom.RoomWidth = Convert.ToDouble(TBWidthL.Text);
            livingRoom.NumWin = Convert.ToInt32(TBNumW.Text);
            lstRooms.Add(livingRoom); //добавление в список
        }

        private void BaddOffice_Click(object sender, RoutedEventArgs e)
        {
            Office office = new Office();
            office.RoomLenght = Convert.ToDouble(TBLenghtO.Text);
            office.RoomWidth = Convert.ToDouble(TBWidthO.Text);
            office.NumSocket = Convert.ToInt32(TBNumS.Text);
            lstRooms.Add(office); //добавление в список
        }

        private void BGetList_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = "";
            //вывод информации из списка
            foreach (Room r in lstRooms)
                ListRooms.Content += r.Info() + "\n";
        }
    }
}
