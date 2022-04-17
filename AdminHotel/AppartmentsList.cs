using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminHotel
{

    internal static class AppartmentsList
    {
        public static Appartment[] app { get; set; }

        public static void InitArr()
        {
            app = new Appartment[3];

            for (int i = 0; i < 3; i++)
            {
                app[i] = new Appartment(i, "free", i + 198, 2, false);
            }
        }
    }
}
