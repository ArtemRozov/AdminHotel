using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminHotel.src
{
    public class ContrAgent
    {
        // ПІБ людини яка колись знімала апартаменти
        public string Name { get; set; }
        // Інн людини яка колись знімала апартаменти
        public string Inn { get; set; }
        // Номер в якому була людина яка знімала апартаменти
        public int Number { get; set; }
        // Два конструктори з перевонтаженням
        public ContrAgent(string name, string inn, int number)
        {
            Name = name;
            Inn = inn;
            Number = number;
        }

        public ContrAgent(string name, string inn)
        {
            Name = name;
            Inn = inn;
        }
    }
}
