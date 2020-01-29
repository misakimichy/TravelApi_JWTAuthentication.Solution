using System.Collections.Generic;

namespace TravelApi.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public Author()
        {
            Locations = new HashSet<Location>();
        }

    }
}