using BCDemoApplicationVer1.Models;

namespace BCDemoApplicationVer1.Services
{
    public class ShoppingItemService
    {
        public double GetPricePerKg(ShoppingItem item)
        {
            return item.Price / item.Weight;
        }
    }
}
