using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmerson_simpel {
    internal class Artikel {
        private string bezeichnung;

        public void SetBezeichnung(string s) {
            bezeichnung = s;
        }

        public string GetBezeichnung() {  
            return bezeichnung;
        }

    }
}
