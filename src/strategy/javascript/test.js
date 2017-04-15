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
