using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class IpodCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new IpodPlayer();
        }

        public override Product FactoryMethod(string _description)
        {
            return new IpodPlayer(_description);
        }

        public override Product FactoryMethod(string _description,
            decimal _purchase_price)
        {
            return new IpodPlayer(_description, _purchase_price);
        }

        public override Product FactoryMethod(string _description,
            decimal _purchase_price, decimal _price)
        {
            return new IpodPlayer(_description, _purchase_price, _price);
        }
    }
}
