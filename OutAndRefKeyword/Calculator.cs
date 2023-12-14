namespace OutAndRefKeyword
{
    internal class Calculator
    {
        public void Calculation(int fn,int sn, ref int sum, ref int product)
        {
            sum = fn + sn;
            product = fn * sn;
        }
    }
}
