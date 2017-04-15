namespace Strategy
{
    class TaxCalculator
    {
        public ITaxer _taxer { get; set; }
        
        public TaxCalculator(ITaxer taxer){
            this._taxer = taxer;
        }

        public double calculate(Check check){
            return this._taxer.calculate(check);
        }
        
    }
}