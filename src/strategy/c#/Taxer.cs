namespace Strategy
{
    interface ITaxer
    {
        double calculate(Check check);
    }

    class ISS : ITaxer
    {
        double ITaxer.calculate(Check check){
            return check.getTotal() * 0.1;
        }
    }

    class ICMS : ITaxer
    {
        double ITaxer.calculate(Check check){
            return check.getTotal() * 0.06;
        }
    }
}