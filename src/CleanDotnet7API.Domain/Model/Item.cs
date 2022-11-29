namespace CleanDotnet7API.Domain.Model
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}