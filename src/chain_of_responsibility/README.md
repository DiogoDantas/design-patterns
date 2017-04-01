Chain of Responsibility pattern
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
    //'imports'
    const model = require('./check');
    const controller = require('./discount_controller');

    //Check and controller instantiation
    var check = new model.Check();
    var discountController = new controller.DiscountController();

    //Adding items to the check
    check.pushItem(new model.Item('Item A', 10.0));
    check.pushItem(new model.Item('Item B', 50.0));
    check.pushItem(new model.Item('Item C', 400.0));

    //Calculating the discount using the chain
    var discount = discountController.calculate(check);

    //printing the discount and the value
    console.log('---Check---')
    for (item of check.getItems()) {
        console.log(item.getName(), item.getValue());
    }
    console.log('-------')
    console.log('TOTAL: ',check.getTotal());
    console.log('discount:', discount);
    console.log("Final Value: ", check.getTotal() - discount);
```

The output must be like that:

```console
    ---Check---
    Item A 10
    Item B 50
    Item C 400
    -------
    TOTAL:  460
    discount: 0
    Final Value:  460
```

If we change the code for:

```javascript
    check.pushItem(new model.Item('Item A', 100.0));
```

the output is going to be:

```console
---Check---
Item A 100
Item B 50
Item C 400
-------
TOTAL:  550
discount: 38.50000000000001
Final Value:  511.5
```
