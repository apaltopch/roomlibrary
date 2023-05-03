using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLength;
        double roomWidth;
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }  
        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }

        /// <summary>
        /// Метод вычисляет параметр комнаты
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2*(roomWidth+roomLength);
        }

        /// <summary>
        /// Метод вычисляет площадь комнаты
        /// </summary>
        /// <returns>Возвращает значение площади</returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }

        /// <summary>
        /// Метод вычисляет число квадратных метров
        /// на одного челвока
        /// </summary>
        /// <param name="np">Число человек</param>
        /// <returns>Возвращает число квадратных метров</returns>
        public double personArea(int np)
        {
            return RoomArea() / np;
        }
        public string Info()
        {
            return "Комната площадью "
        }
       /// <summary>
       /// Класс "жилая комната"
       /// </summary>
        public class LivingRoom : Room
        {
            int numWin; //число окон

            public int NumWin
            { get { return numWin; } set { numWin = value; } }

            /// <summary>
            /// метод возвращает информацию о комнате 
            /// </summary>
            /// <returns>возвращается строка с информацией</returns>
            public string Info()
            {
                return "Жилая комната площадью " + RoomArea() + "кв.м, с " + numWin + "окнами";
            }
            

        }


    }
}
