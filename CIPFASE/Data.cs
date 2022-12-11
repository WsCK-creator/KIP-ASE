using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIP_ASE
{
    public class Data
    {
        public string IP { get; set; }
        public string Mask { get; set; }
        public string Gateway { get; set; }
        public string DNS1 { get; set; }
        public string DNS2 { get; set; }

        public bool btDHCP { get; set; }
        public bool btIP { get; set; }
        public bool btAuto { get; set; }
        public bool btSave { get; set; }

        public List<string> Cards { get; set; }
        public int CardID { get; set; }

    }
}
