using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace EauSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    [DisplayName("Client Name:")]
    public string Name { get; set; }
    [DisplayName("Preferred Appointment Days:")]
    public int PreferredDays { get; set; }
    [DisplayName("Would the client like to be contacted about last minute openings:")]
    public Notice ShortNotice { get; set; }
    public virtual Stylist Stylist { get; set; }
  }

  public enum Notice
  {
    No,
    Yes
  }
}