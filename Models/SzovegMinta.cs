using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzovegMintaProject.Models
{
    public class SzovegMinta
    {
        private string elsoTag, masodikTag;
        private byte ismetlodesSzam;

        private bool vanZaroTag = false;

        public SzovegMinta(string elsoTag, string masodikTag, byte ismetlodesSzam, bool vanZaroTag)
        {
            this.elsoTag = elsoTag;
            this.masodikTag = masodikTag;
            this.ismetlodesSzam = ismetlodesSzam;
            this.vanZaroTag = vanZaroTag;
        }

        public SzovegMinta(string elsoTag, string masodikTag, byte ismetlodesSzam)
        {
            this.elsoTag = elsoTag;
            this.masodikTag = masodikTag;
            this.ismetlodesSzam = ismetlodesSzam;
        }
    }
}
