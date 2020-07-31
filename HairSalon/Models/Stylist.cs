using System.Collections.Generic;
using System.ComponentModel;
using System;

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
    [DisplayName("Hire Date:")]
    public DateTime HireDate { get; set; }
    [DisplayName("Scheduled Work Day:")]
    public WorkDay ScheduledWorkDays { get; set; }

    public virtual ICollection<Client> Clients { get; set; }
  }

  public enum WorkDay
  {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
  }
}