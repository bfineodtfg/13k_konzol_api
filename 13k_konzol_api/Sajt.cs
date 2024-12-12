using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13k_konzol_api
{
    class Sajt
    {
        public int id { get; set; }
        public string termek { get; set; }
        public int ar { get; set; }
        public int keszlet { get; set; }
        public int beszallito { get; set; }
        public override string ToString()
        {
            return $"{id} - {termek} - {ar} - {keszlet} - {beszallito}";
        }
    }
}
