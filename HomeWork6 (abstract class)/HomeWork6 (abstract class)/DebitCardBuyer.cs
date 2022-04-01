using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6__abstract_class_
{
    class DebitCardBuyer : Buyer
    {
        public string DebitCard = "Debit Card";
        public override string Pay()
        {
            return System.String.Format("Payment method is {0}", DebitCard);
        }
    }
}