using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
    {
        public Stylist()
        {
            this.Customers = new HashSet<Customer>();
        }

        public int StylistId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}