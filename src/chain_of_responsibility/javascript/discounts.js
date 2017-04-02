exports.FiveItemsDiscount = function (nextDiscount) {
    var _nextDiscount = nextDiscount;

    this.calculate = function (check) {
        if (check.getItems().length > 5) {
            return check.getTotal() * 0.1;
        }
        else {
            return _nextDiscount.calculate(check);
        }
    }

}

exports.MoreThan500Discount = function (nextDiscount) {
    var _nextDiscount = nextDiscount;

    this.calculate = function (check) {
        if (check.getTotal() > 500)
            return check.getTotal() * 0.07;
        else {
           return _nextDiscount.calculate(check);
        }
    }

}


exports.NoDiscount = function () {
    this.calculate = function (check) {
        return 0;
    }
}