
var TaxCalculator = function(Taxer){
    
    this.calculate = function(check){
        var tax = Taxer.calculate(check);
        return tax;
    } 
}

module.exports = TaxCalculator;