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
        private bool vanZaroTag;

        public SzovegMinta(string elsoTag, string masodikTag, byte ismetlodesSzam, bool vanZaroTag = false)
        {
            if (ismetlodesSzam == 0 || elsoTag == "" || masodikTag == "") 
            {
                throw new ArgumentException();
            }

            this.elsoTag = elsoTag;
            this.masodikTag = masodikTag;
            this.ismetlodesSzam = ismetlodesSzam;
            this.vanZaroTag = vanZaroTag;
        }

        public string Minta()
        {
            string eredmeny = "";

            for (int i = 0; i < ismetlodesSzam; i++)
            {
                eredmeny += elsoTag;
                if (i == ismetlodesSzam-1 && !vanZaroTag)
                {
                    break;
                }
                eredmeny += masodikTag;

            }

            return eredmeny;
        }
        public string ForditottMinta()
        {
            string eredmeny = "";

            for (int i = 0; i < ismetlodesSzam; i++)
            {
                eredmeny += masodikTag;
                if (i == ismetlodesSzam - 1 && !vanZaroTag)
                {
                    break;
                }
                eredmeny += elsoTag;

            }

            return eredmeny;
        }
    }
}
