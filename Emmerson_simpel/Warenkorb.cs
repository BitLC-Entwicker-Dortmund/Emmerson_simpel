using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmerson_simpel {
    internal class Warenkorb {
        private List<BestellPosition> bestellpositionen = new List<BestellPosition>();

        internal void AddBestellPosition(BestellPosition bp) {
            bestellpositionen.Add(bp);
        }

        public void ZeigMal() {
            foreach (BestellPosition einePosition in bestellpositionen) {
                Console.WriteLine(einePosition.GetArtikel().GetBezeichnung());
            }
        }
    }
}
