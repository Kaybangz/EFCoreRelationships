namespace EFCoreRelationships
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public IEnumerable<Product>? Products { get; set; }
    }
}
