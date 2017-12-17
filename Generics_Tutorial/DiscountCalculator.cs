namespace Generics_Tutorial
{

    /// <summary>
    /// Examples of constraint to reference type?
    /// </summary>
    /// <typeparam name="TProduct"></typeparam>
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}
