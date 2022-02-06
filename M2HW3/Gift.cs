namespace M2HW3
{
    internal class Gift : ICountWeight
    {
        private Chocolate[] _chocolates1 = null;

        public Gift(Chocolate[] chocolates)
        {
            _chocolates1 = chocolates;
        }

        public double CountWeight()
        {
            double weight = 0;

            foreach (Chocolate v in _chocolates1)
            {
                weight += v.Weight;
            }

            return weight;
        }
    }
}
