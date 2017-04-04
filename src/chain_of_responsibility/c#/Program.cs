using System;

namespace ChainOfResp
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing controller and check
            DiscountController controller = new DiscountController();
            Check check = new Check();

            //adding items to check
            check.pushItem(new Item("Item A", 100.0));
            check.pushItem(new Item("Item B", 50.0));
            check.pushItem(new Item("Item C", 400.0));

            //calculating discount
            double discount = controller.calculate(check);

            //printing
            System.Console.WriteLine("---Check---");

            foreach (Item item in check.items)
            {
                System.Console.WriteLine("{0} {1}", item.name, item.value);
            }


            System.Console.WriteLine("-------");

            System.Console.WriteLine("TOTAL: {0}", check.getTotal());
            System.Console.WriteLine("discount: {0}", discount);
            System.Console.WriteLine("Final Value: {0}", check.getTotal() - discount);

        }
    }
}