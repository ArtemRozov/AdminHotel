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

        public Appartment(int number, string free, int price, int countRooms, bool bron)
        {
            this.number = number;
            this.free = free;
            this.price = price;
            this.countRooms = countRooms;
            this.bron = bron;
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
    }
}
