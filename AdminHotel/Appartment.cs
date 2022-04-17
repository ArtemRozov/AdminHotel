using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminHotel
{
    public class Appartment
    {
        private int number;
        private string free;
        private int price;
        private int countRooms;
        private bool bron;
        private string name;
        private string inn;
        private DateTimeOffset checkIn;
        private DateTimeOffset checkOut;

        public Appartment(int number, string free, int price, int countRooms, bool bron, string name, string inn, DateTimeOffset checkIn, DateTimeOffset checkOut)
        {
            this.number = number;
            this.free = free;
            this.price = price;
            this.countRooms = countRooms;
            this.bron = bron;
            this.name = name;
            this.inn = inn;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        public int getNumber()
        {
            return number;
        }
        public string getFree()
        {
            return free;
        }
        public int getPrice()
        {
            return price;
        }
        public int getCountRooms()
        {
            return countRooms;
        }

        public bool getBron()
        {
            return bron;
        }

        public string getName()
        {
            return name;
        }

        public string getInn()
        {
            return inn;
        }

        public DateTimeOffset getCheckIn()
        {
            return checkIn;
        }

        public DateTimeOffset getCheckOut()
        {
            return checkOut;
        }
    }
}
