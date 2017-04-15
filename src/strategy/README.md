Strategy Pattern
=====

Javascript :coffee:
-------
Since by default Javascript does not support import from multiple files, these examples are made using Node.js framework.

make sure Node is installed:

```console
    $ node --version
    v7.x.x
```

Testing
--------

To test, open your terminal in your project file and run:

```console
    node test.js
```

Here's our test code on file ```test.js```:

``` javascript
    //imports
    var TaxCalculator = require('./TaxCalculator');
    var ICMS = require('./Taxer').ICMS;
    var ISS = require('./Taxer').ISS;
    var Check = require('./check').Check;
    var Item = require('./check').Item;

    //Two types of taxes
    var taxer1 = new ICMS();
    var taxer2 = new ISS();

    //The tax calculator using strategy 1
    var calculator = new TaxCalculator(taxer1);

    //the check
    var check = new Check();

    //Adding items to the check
    check.pushItem(new Item('Item A', 100.0));
    check.pushItem(new Item('Item B', 50.0));
    check.pushItem(new Item('Item C', 400.0));

    //Calculating the discount using the calculator (strategy 1)
    var tax = calculator.calculate(check);

    //printing the tax and the value
    console.log('STRATEGY 1')
    console.log('---Check---')
    for (item of check.getItems()) {
        console.log(item.getName(), item.getValue());
    }
    console.log('-------')
    console.log('TOTAL: ',check.getTotal());
    console.log('tax:', tax);
    console.log("Final Value: ", check.getTotal() + tax);

    //changing to the strategy 2
    calculator = new TaxCalculator(taxer2);

    //now using the second taxer to calculate
    tax = calculator.calculate(check);

    //printing the tax and the value
    console.log('\nSTRATEGY 2')
    console.log('---Check---')
    for (item of check.getItems()) {
        console.log(item.getName(), item.getValue());
    }
    console.log('-------')
    console.log('TOTAL: ',check.getTotal());
    console.log('tax:', tax);
    console.log("Final Value: ", check.getTotal() + tax);

```

The output must be like that:

```console
    STRATEGY 1
    ---Check---
    Item A 100
    Item B 50
    Item C 400
    -------
    TOTAL:  550
    tax: 33
    Final Value:  583

    STRATEGY 2
    ---Check---
    Item A 100
    Item B 50
    Item C 400
    -------
    TOTAL:  550
    tax: 55
    Final Value:  605

```

C# :hash:
-------

C# can be compiled and runned in linux by using .NET Core, so make sure it's installed:

```console
    $ dotnet --version
    1.x.x
```

Testing
--------

To test, open your terminal in your project file and run:

```console
    dotnet restore
    dotnet run
```

Here's our test code on file ```Program.cs```:

``` csharp
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
```

The output must be like that:

```console
    STRATEGY 1
    ---Check---
    Item A 100
    Item B 50
    Item C 400
    -------
    TOTAL: 550
    tax: 55
    Final Value: 605

    STRATEGY 2
    ---Check---
    Item A 100
    Item B 50
    Item C 400
    -------
    TOTAL: 550
    tax: 33
    Final Value: 583

```
