namespace ChainOfResp
{
    class DiscountController
    {
        public double calculate(Check check)
        {
            return new FiveOrMoreDiscount(
                new MoreThan500Discount(
                    new NoDiscount(null)
                )
            ).calculate(check);
        }
    }
}