//'imports'
const model = require('./check');
const controller = require('./discount_controller');

//Check and controller instantiation
var check = new model.Check();
var discountController = new controller.DiscountController();

//Adding items to the check
check.pushItem(new model.Item('Item A', 100.0));
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