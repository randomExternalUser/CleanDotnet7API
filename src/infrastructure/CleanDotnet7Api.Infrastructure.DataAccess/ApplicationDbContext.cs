using CleanDotnet7API.Domain.Model;

namespace CleanDotnet7Api.Infrastructure.DataAccess
{
    public class ApplicationDbContext
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public ApplicationDbContext()
        {
            SeedItems();
        }

        private void SeedItems()
        {
            Items.Add(new Item
            {
                Id = Guid.NewGuid(),
                Description = "Spoon",
                Price = 2
            });

            Items.Add(new Item
            {
                Id = Guid.NewGuid(),
                Description = "Fork",
                Price = 3
            });

            Items.Add(new Item
            {
                Id = Guid.NewGuid(),
                Description = "Table",
                Price = 15
            });

            Items.Add(new Item
            {
                Id = Guid.NewGuid(),
                Description = "Chair",
                Price = 10
            });
        }
    }
}