using System;
using Planner.Domain.Abstracts;
using Planner.Domain.Models;

namespace Planner.Domain.Models
{
  public class Planner : Entity
  {
    public Customer customer { get; set; }
    public int Month { get; set; }
    public List<Event> Events { get; set; }

    public void MakeEvent(DateTime start, DateTime end, string title, string descrip)
    {
      var newest = new Event() { StartDate = start, EndDate = end, Description = descrip, Title = title };
      Events.add(newest);
    }

    public void DeleteEvent()
    {
      DisplayEvents();
      Console.WriteLine("Which event would you like to remove?");
      var valid = int.TryParse(Console.ReadLine(), out int input);

      if (!valid)
      {
        return null;
      }

      Events.remove((input + 1));
    }

    public void ChangeEvent()
    {
      DisplayEvents();
      var valid = int.TryParse(Console.ReadLine(), out int input);

      if (!valid)
      {
        return null;
      }
      var toChange = Events[input];
      Console.WriteLine(toChange.Title + "\n " + toChange.Description);

      Console.WriteLine("Change name ");
      toChange.Title = Console.ReadLine();

      Console.WriteLine("Change description ");
      string newDescrip = Console.ReadLine();

      Console.WriteLine("Change start date ");
      string newStart = Console.ReadLine();

      Console.WriteLine("Change end date ");
      string newEnd = Console.ReadLine();
    }

    public void DisplayEvents()
    {
      int i = 1;
      foreach (var item in Events)
      {
        Console.Write(i + " " + item.Title);
      }
    }

  }
}