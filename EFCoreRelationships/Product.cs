using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreRelationships
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [Column(TypeName = "Decimal(10, 2)")]
        public decimal Price { get; set; }

        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public Size? Size { get; set; }

        public IEnumerable<Color>? Colors { get; set; }
    }
}
