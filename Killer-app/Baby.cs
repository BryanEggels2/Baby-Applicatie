using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Killer_app
{
    class Baby
    {
        Query query = new Query();
        public int leeftijd;
        public string voornaam;
        public string achternaam;
        public char geslacht;
        public int id;
        public void Insert()
        {
            query.Insert_baby(voornaam, achternaam, geslacht, leeftijd);
        }
        public override string ToString()
        {
            return voornaam;
        }

    }
}
