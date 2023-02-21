using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Ientity
{
    class Yazar
    {
        public int yazarNo;
        public string yazarAd;
        public string yazarOzgecmis;


        public int yazarNoSet
        {
            get { return yazarNo; }
            set { yazarNo = value; }
        }

        public string yazarAdSet
        {
            get { return yazarAd; }
            set { yazarAd = value; }
        }

        public string yazarOzgecmisSet
        {
            get { return yazarOzgecmis; }
            set { yazarOzgecmis = value; }
        }

        public Yazar()
        {
            yazarNo = 0;
            yazarAd = "";
            yazarOzgecmis = "";

        }

    }
}
