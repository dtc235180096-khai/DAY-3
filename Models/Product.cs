namespace thuchanh3.Models
{
    public class Product
    {
        public int Id { get; set; }  

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;
        //foreign key to Category
        public string CategoryId { get; set; }

        //navigation property Category
        public Category Category { get; set; }

    }
}
