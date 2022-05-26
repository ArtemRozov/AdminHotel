using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminHotel
{
    public class Appartment
    {
        public int Number { get; }
        public int Price { get;}
        public int CountRooms { get; }
        public bool Bron { get; set; }
        public string Free { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        public DateTimeOffset CheckIn { get; set; }
        public DateTimeOffset CheckOut { get; set; }

        public Appartment(int number, string free, int price, int countRooms, bool bron, string name, string inn, DateTimeOffset checkIn, DateTimeOffset checkOut)
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
