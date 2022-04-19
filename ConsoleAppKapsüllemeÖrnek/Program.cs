using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKapsüllemeÖrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            p.setIsım("Ahmet");
            string gelen = p.getIsim();
            p.setUnvan("Müdür");
            string gelen2 = p.getUnvan();



            if(gelen == "Ahmet" && gelen2 == "Müdür")
            {
                Console.WriteLine("Başarılı");
            }
            else

            {
                Console.WriteLine("Başarısız");
            }
            Console.ReadKey();
        }
    }
}
