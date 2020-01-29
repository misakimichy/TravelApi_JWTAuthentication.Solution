namespace TravelApi.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Review { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}