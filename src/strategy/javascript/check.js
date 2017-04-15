exports.Check = function () {
    var _items = [];
    
    this.pushItem = function(item){
        _items.push(item);
    }

    this.getItems = function()
    {
        return _items; 
    }
    this.getTotal = function(){
        var total = 0.0;
        for (item of _items){
            total+=item.getValue();
        }
        return total;    
    }
}

exports.Item = function(name, value){
    var _name = name;
    var _value = value;

    this.getName = function(){
        return _name;
    }

    this.getValue = function(){
        return _value;
    }
}