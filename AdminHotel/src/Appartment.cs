using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminHotel
{
    public class Appartment
    {
        // Номер апартаменту
        public int Number { get; }
        // Ціна апартаменту
        public int Price { get;}
        // Кількість кімнат апартаменту
        public int CountRooms { get; }
        // Заброньовані ці апартаменти або ні
        public bool Bron { get; set; }
        // Вільні ці апартаменти або ні
        public string Free { get; set; }
        // ПІБ людини на яку знято апартаменти
        public string Name { get; set; }
        // Інн людини на яку знято апартаменти
        public string Inn { get; set; }
        // Дата в'їзду людини в апартамент 
        public DateTimeOffset CheckIn { get; set; }
        // Дата виселення людини із апартаментів
        public DateTimeOffset CheckOut { get; set; }

        // Конструктор для майбутніх змінних типу Appartment 
        public Appartment(int number, string free, int price, int countRooms,
            bool bron, string name, string inn,
            DateTimeOffset checkIn, DateTimeOffset checkOut)
        {
            Number = number;
            Price = price;
            CountRooms = countRooms;
            Bron = bron;
            Free = free;
            Name = name;
            Inn = inn;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}
