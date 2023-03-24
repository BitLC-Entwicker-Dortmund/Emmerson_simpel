using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmerson_simpel {
    internal class BestellPosition {
        private Artikel artikel;
        private int menge;

        public void SetArtikel(Artikel artikel) {
            this.artikel = artikel;
        }
        public Artikel GetArtikel() {
            return artikel;
        }
        public void SetMenge(int menge) {
            this.menge = menge;
        }
        public int GetMenge() {  
            return menge;
        }

    }
}
