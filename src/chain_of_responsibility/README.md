Chain of Responsibility pattern
=====

Javascript :coffee:
-------
Since by default Javascript does not support import from multiple files, these examples are made using Node.js framework.

make sure Node is installed:

.. code-block:: console
    $ node --version
    v7.x.x

Testing
--------

Here's our test code on file ```test.js```:

.. code-block:: javascript
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

The output must be like that:

.. code-block::console
    ---Check---
    Item A 10
    Item B 50
    Item C 400
    -------
    TOTAL:  460
    discount: 0
    Final Value:  460
