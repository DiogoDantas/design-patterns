using System;
using System.Collections.Generic;

namespace Strategy {
    class Check{
        public List<Item> items {get;}

        public Check(){
            items = new List<Item>();
        }

        public void pushItem(Item item){
            items.Add(item);
        }

        public double getTotal(){
            double total = 0.0;
            foreach (Item item in items)
            {
                total+=item.value;
            }
            return total;
        }
    }


    class Item
    {
        public Item(string name_, double value_){
            name = name_;
            value = value_;
        }
        public string name {get;set;}
        public double value {get;set;}

    }
}