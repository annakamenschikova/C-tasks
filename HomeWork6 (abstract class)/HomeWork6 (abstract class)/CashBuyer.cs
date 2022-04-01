using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6__abstract_class_
{
    class CashBuyer: Buyer
    {
        public string Cash = "Cash";
        public override string Pay()
        {
            return System.String.Format("Payment method is {0}", Cash);
        }
    }
}
