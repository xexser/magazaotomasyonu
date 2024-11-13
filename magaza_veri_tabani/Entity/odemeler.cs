using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaza_veri_tabani
{
    public class Odeme
    {
        public int odemeID { get; set; }
        public int musteriID { get; set; }
        public DateTime odemeTarih { get; set; }
        public string odemeTutar { get; set; }
        public string odemeTur { get; set; }
    }
}
