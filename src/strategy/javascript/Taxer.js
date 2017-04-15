var ISS = function() {
    this.calculate = function(check){
        return check.getTotal() * 0.1;
    }
}

var ICMS = function() {
    this.calculate = function(check){
        return check.getTotal() * 0.06;
    }
}

module.exports = {ICMS:ICMS, ISS:ISS}