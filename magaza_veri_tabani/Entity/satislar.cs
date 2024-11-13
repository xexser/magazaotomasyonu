using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaza_veri_tabani
{
    public class Satis
    {
        public int satisID { get; set; }
        public int musteriID { get; set; }
        public int urunID { get; set; }
        public DateTime satisTarihi { get; set; }
        public string satisFiyati { get; set; }
    }
}
