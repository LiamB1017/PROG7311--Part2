namespace PROG7311_Part2.Models
{
    public class Farmer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
