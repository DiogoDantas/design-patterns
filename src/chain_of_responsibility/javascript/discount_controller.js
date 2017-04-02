const dsc = require('./discounts');

exports.DiscountController = function(){
    
    this.calculate = function(check) {
        
        var discount =  new dsc.FiveItemsDiscount(
                        new dsc.MoreThan500Discount(
                        new dsc.NoDiscount()
                        )
                        ).calculate(check);    
        
        return discount;
    }

}