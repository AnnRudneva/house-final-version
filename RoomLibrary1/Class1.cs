using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary1
{
    public class Room
    {
        double roomLenght; //длина комнатыв
        double roomWidth; //ширина комнаты

        public double RoomLenght
        {
            get { return roomLenght; }
            set { roomLenght = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// Метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLenght + roomWidth);
        }
        /// <summary>
        /// Метод вычисляет площадь комнаты 
        /// </summary>
        /// <returns>Возвращает значение площади</returns>
        public double RoomArea()
        {
            return roomLenght * roomWidth;
        }
        public double PersonalArea(int np)
        {
            return RoomArea() / np;
        }
        /// <summary>
        /// Информация о комнате
        /// </summary>
        /// <returns>Возвращаеь строку</returns>
        public virtual string Info()//virtual - при необходимости может быть переопределен
        {
            return "Комната площадью " + RoomArea() + " кв.м";
        }
    }
    /// <summary>
    /// Класс жилая комната
    /// </summary>
    public class LivingRoom : Room
    {
        int numWin; //число окон
        public int NumWin
        { get { return numWin; } set { numWin = value; } }

        /// <summary>
        /// Метод возвращает информацию о коинате
        /// </summary>
        /// <returns>Возвращвет строку с информацией</returns>
        public  override string Info()   //override-метод производного класса преобладает над методом базового
        {
            return "Жилая комната площадью " + RoomArea() + " кв.м , с " + numWin + " окнами";
        }
    }
    public class Office : Room
    {
        int numSocket; //число розеток
        public int NumSocket
        { get { return numSocket; } set { numSocket = value; } }
        /// <summary>
        /// Возвращает максимально возможное число рабочих мест
        /// </summary>
        /// <returns>Возвращает число мест</returns>
        public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5)) ;//число возможных раб. мест без учета розеток
            return Math.Min(numSocket, num);
        }
        /// <summary>
        /// Метод возвращает информацию об офисе
        /// </summary>
        /// <returns>Возвращается строка с информацией</returns>
        public override string Info()
        {
            return "Офис на " + NumWorkplaces() + " рабочих мест";
        }
    }
}
