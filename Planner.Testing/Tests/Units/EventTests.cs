using System;
using Xunit;
using Planner.Domain.Models;

namespace Planner.Testing
{
  public class EventTests
  {
    public int MAX_LENGTH = 100;
    public int MIN_LENGTH = 5;

    [Fact]
    public void EventTest1()
    {
      Event ev1 = new Event();
      Assert.NotNull(ev1);

      ev1.Title = "Wake-up";
      ev1.Description = "Times time to wake up friend.";
      ev1.StartDate = new DateTime(2021, 10, 17, 8, 00, 00);
      ev1.EndDate = new DateTime(2021, 10, 17, 9, 00, 00);
      Assert.NotNull(ev1);
    }

    [Theory]
    [InlineData("Lunch with President")]
    [InlineData("Dinner with parents")]
    public void EventTestName(string eventName)
    {
      var ev = new Event() { Title = eventName };
      Assert.NotNull(ev.Title);
      Assert.Equal(ev.Title, ev.ToString());
      Assert.InRange(ev.Title.Length, MIN_LENGTH, MAX_LENGTH);
    }

    [Theory]
    [InlineData("Times time to wake up friend.")]
    [InlineData("Dinner with parents, do not forget to reschedule soon")]
    public void EventTestDescrip(string descrip)
    {
      Event ev1 = new Event() { Description = descrip };
      Assert.NotNull(ev1.Description);
      Assert.InRange(ev1.Description.Length, MIN_LENGTH, MAX_LENGTH);
    }


    [Theory]
    [InlineData("2021-11-4 14:25 PM", "2021-11-7, 9:15 AM")]
    [InlineData("2021-10-12 10:25 PM", "2021-10-12, 9:15 AM")]
    [InlineData("2021-03-22 06:25 PM", "2021-03-22, 7:15 PM")]

    public void EventTestDate(string d1, string d2)
    {
      var start = DateTime.Parse(d1);
      var end = DateTime.Parse(d2);

      Event ev1 = new Event() { StartDate = start, EndDate = end };
      Assert.NotEqual(ev1.StartDate, ev1.EndDate);
      int v1 = DateTime.Compare(ev1.StartDate, ev1.EndDate);
      Assert.True(v1 < 0, end + " is earlier than start time");


      Event ev2 = new Event() { StartDate = end, EndDate = start };
      Assert.NotEqual(ev1.StartDate, ev1.EndDate);
      int v2 = DateTime.Compare(ev1.StartDate, ev1.EndDate);
      Assert.False(v2 < 0, end + " is earlier than start time");

    }


  }
}
