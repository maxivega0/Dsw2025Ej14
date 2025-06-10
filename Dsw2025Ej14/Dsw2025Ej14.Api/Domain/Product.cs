namespace Dsw2025Ej14.Api.Domain
{
    public class Product
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public decimal CurrentUnitPrice { get; set; }
        public bool IsActive { get; set; }

        public Product(string sku, string name, decimal currentUnitPrice, bool isActive)
        {
            SKU = sku;
            Name = name;
            CurrentUnitPrice = currentUnitPrice;
            IsActive = isActive;
        }
    }
}