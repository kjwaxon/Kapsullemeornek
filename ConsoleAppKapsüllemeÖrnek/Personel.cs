using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKapsüllemeÖrnek
{
    class Personel
    {
        public string isim;
        public string unvan;

        public void setIsım(string _isim)
        {
            isim = _isim;
        }

        public string getIsim()
        {
            return isim;
        }
        public void setUnvan(string _unvan)
        {
            unvan = _unvan;

        }
        public string getUnvan()
        {
            return unvan;
        }
    }
}
