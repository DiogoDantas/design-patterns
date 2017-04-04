namespace ChainOfResp
{
    abstract class DiscountAB
    {
        protected DiscountAB nextDiscount;

        public abstract double calculate(Check check);
    }

    class FiveOrMoreDiscount : DiscountAB
    {
        public FiveOrMoreDiscount(DiscountAB next)
        {
            nextDiscount = next;
        }

        public override double calculate(Check check)
        {
            if (check.items.Count > 5)
                return check.getTotal() * 0.1;
            else
                return nextDiscount.calculate(check);
        }

    }
    class MoreThan500Discount : DiscountAB
    {
        public MoreThan500Discount(DiscountAB next)
        {
            nextDiscount = next;
        }

        public override double calculate(Check check)
        {
            if (check.getTotal() > 500)
                return check.getTotal() * 0.07;
            else
                return nextDiscount.calculate(check);
        }

    }

    class NoDiscount : DiscountAB
    {
        public NoDiscount(DiscountAB next)
        {
            nextDiscount = null;
        }

        public override double calculate(Check check)
        {
            return 0;
        }

    }


}