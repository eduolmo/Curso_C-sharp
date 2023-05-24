using System.Globalization;

namespace Heranca_Polimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name,price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{this.Name} ${TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: ${this.CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public Double TotalPrice()
        {
            return this.Price + this.CustomsFee;
        }

    }
}
