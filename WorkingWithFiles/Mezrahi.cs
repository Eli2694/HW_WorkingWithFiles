using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    internal class Mezrahi : Bank
    {
        public Mezrahi(string bank_code) : base(bank_code)
        {

        }

        private int clubMembersCount;

        public int ClubMembersCount
        {
            get { return clubMembersCount; }
            set { clubMembersCount = value; }
        }

    }
}
