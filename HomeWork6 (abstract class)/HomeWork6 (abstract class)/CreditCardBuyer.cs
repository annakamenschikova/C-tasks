using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6__abstract_class_
{
    class CreditCardBuyer : Buyer
    {
        public string CreditCard = "Credit Card";
        public override string Pay()
        {
            return System.String.Format("Payment method is {0}", CreditCard);
        }
    }
}