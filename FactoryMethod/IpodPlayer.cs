using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class IpodPlayer : Product
    {
        private decimal _purchase_price; // цена закупки  
        private decimal _price; // цена продажи  
                                // масив форматов, которые поддерживет Ipod  
        private string _description;

        public IpodPlayer() : this(null) { }
        public IpodPlayer(string _description)
           : this(_description, 0) { }
        public IpodPlayer(string _description, decimal _purchase_price)
           : this(_description, _purchase_price, 0) { }

        public IpodPlayer(string _description,
            decimal _purchase_price, decimal _price)
        {
            this._description = _description;
            this._purchase_price = _purchase_price;
            this._price = _price;
        }

        public override string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override decimal PurchasePrice
        {
            get { return _purchase_price; }
            set { _purchase_price = value; }
        }
    }
}
