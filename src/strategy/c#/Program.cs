using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ISS taxer1 = new ISS();
            ICMS taxer2 = new ICMS();

            TaxCalculator calculator = new TaxCalculator(taxer1);
            Check check = new Check();

            //adding items to check
            check.pushItem(new Item("Item A", 100.0));
            check.pushItem(new Item("Item B", 50.0));
            check.pushItem(new Item("Item C", 400.0));

            //calculating TAX
            double tax = calculator.calculate(check);

            //printing
            System.Console.WriteLine("STRATEGY 1");
            System.Console.WriteLine("---Check---");

            foreach (Item item in check.items)
            {
                System.Console.WriteLine("{0} {1}", item.name, item.value);
            }


            System.Console.WriteLine("-------");

            System.Console.WriteLine("TOTAL: {0}", check.getTotal());
            System.Console.WriteLine("tax: {0}", tax);
            System.Console.WriteLine("Final Value: {0}", check.getTotal() + tax);

            //calculating tax
            calculator = new TaxCalculator(taxer2);
            tax = calculator.calculate(check);
            
            //printing
            System.Console.WriteLine("\nSTRATEGY 2");
            System.Console.WriteLine("---Check---");

            foreach (Item item in check.items)
            {
                System.Console.WriteLine("{0} {1}", item.name, item.value);
            }


            System.Console.WriteLine("-------");

            System.Console.WriteLine("TOTAL: {0}", check.getTotal());
            System.Console.WriteLine("tax: {0}", tax);
            System.Console.WriteLine("Final Value: {0}", check.getTotal() + tax);

       
        }
    }
}
