using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    internal class Laomi : Bank
    {
        public Laomi(string bank_code) : base(bank_code)
        {

        }

        private string giftForNewCustumers;

        public string GiftForNewCustumers
        {
            get { return giftForNewCustumers; }
            set { giftForNewCustumers = value; }
        }
    }
}
