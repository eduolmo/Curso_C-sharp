using System.Globalization;

namespace Heranca_Polimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{this.Name} (used) ${this.Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {this.ManufactureDate.ToString("dd/MM/yyyy")})";
        }

    }
}
