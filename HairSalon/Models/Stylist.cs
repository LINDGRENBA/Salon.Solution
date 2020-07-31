using System.Collections.Generic;
using System.ComponentModel;

namespace EauSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    [DisplayName("Stylist's Name:")]
    public string Name { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}