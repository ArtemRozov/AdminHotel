using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminHotel
{

    internal static class AppartmentsList
    {
        private static List<string> names = new List<string>();
        public static Appartment[] app { get; set; }

        public static void InitArr()
        {
            app = new Appartment[3];

            for (int i = 0; i < 3; i++)
            {
                app[i] = new Appartment(i, "free", i + 198, 2, false, "", "", DateTime.Now, DateTime.Now);
            }
        }

        public static List<string> getNames()
        {
            return names;
        }
        public static void setNames(string name)
        {
            names.Add(name);
        }
    }
}
