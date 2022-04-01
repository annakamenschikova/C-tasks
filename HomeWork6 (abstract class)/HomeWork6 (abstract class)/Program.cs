using System;

namespace HomeWork6__abstract_class_
{
    /*1. Создать абстрактный класс Покупатель, у которого есть абстрактный метод Оплатить. 
2. Создать наследников от этого класса- Покупатель за наличные, покупатель с дебетовой картой, и покупатель с кредитной картой. 
3. Реализовать в них метод Оплатить (пусть просто выводит на экран способ оплаты) 
4. Создать массив из 5 покупателей разного типа, и в цикле вызвать метод Оплатить. Проверить что каждый оплатил своим способом (сообщения на экране) */

    class Program
    {
        static void Main(string[] args)
        {
            Buyer buyer1 = new CashBuyer();

            Buyer buyer2 = new CreditCardBuyer();

            Buyer buyer3 = new DebitCardBuyer();

            Buyer buyer4 = new CashBuyer();

            Buyer buyer5 = new CreditCardBuyer();

            Buyer[] buyers = { buyer1, buyer2, buyer3, buyer4, buyer5 };

            foreach (Buyer item in buyers)
            {
                Console.WriteLine(item.Pay());          
            }
        }
    }
}
