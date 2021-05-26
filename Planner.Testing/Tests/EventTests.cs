using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Planner.Domain.Abstracts;
using Planner.Domain.Interfaces;
using Planner.Domain.Models;

namespace Planner.Testing
{
  public class UnitTest1
  {
    [Fact]
    public void EventTest1()
    {
      Event ev1 = new Event();
      Assert.NotNull(ev1);

      ev1.Title = "Wake-up";
      ev1.Description = "Times time to wake up friend.";
      ev1.StartDate = DateTime(2021, 10, 17, 8, 00, 00);
      ev1.EndDate = DateTime(2021, 10, 17, 9, 00, 00);

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
      Assert.InRange(ev.Title.Length, 5, 25);
    }

    [Theory]
    [InlineData("Times time to wake up friend.")]
    [InlineData("Dinner with parents, do not forget to reschedule soon")]
    public void EventTestDescrip(string descrip)
    {
      Event ev1 = new Event() { Description = descrip };
      Assert.NotNull(ev1.Description);
      Assert.InRange(ev1.Description.Length, 10, 50);
    }

  }
}
