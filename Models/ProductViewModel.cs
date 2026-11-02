namespace thuchanh3.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public string CategoryId { get; set; }
        public String? CatogaoryName { get; set; }
    }
}
