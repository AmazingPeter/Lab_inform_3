﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem4_3
{
    class Drink:Food
    {
        bool isAlcoholic;
        int amount;//объём

        public Drink(string name, List<string> listOfIngredients, double price, bool isAlcoholic, int amount):base(name,listOfIngredients,price)
        {
            this.isAlcoholic = isAlcoholic;
            this.amount = amount;
        }

        public override double UnitPrice()
        {
            return price / amount;
        }

        public override bool IsAlcoholic()
        {
            return isAlcoholic;
        }

        public override string ToString()
        {
            return base.ToString() + isAlcoholic + " " + amount;
        }
    }
}
