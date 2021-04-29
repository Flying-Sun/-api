using Flying.Sun.Domain.Catalog;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Flying.Sun.Data{
    public static class DbInitializer
    {
        public static void Initializer(StoreContext context, ILogger logger)
        {
            if(!context.Items.Any())
            {
                var items = new Item[]
                {
                new Item("T-Shirt", "Ohio State Block O", "Nike", 39.99m),
                new Item("Shorts", "Casual shorts", "Nike", 49.99m)
                };
                context.Items.AddRange(items);
                context.SaveChanges();
            }
        }
    }
}
