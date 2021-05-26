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
  public class CustomerTests
  {
    public int MAX_LENGTH = 100;
    public int MIN_LENGTH = 5;

    [Fact]
    public void EventTest1()
    {
      Customer cs1 = new Customer();
      Assert.NotNull(cs1);
      cs1.
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
      Assert.InRange(ev1.Description.Length, 5, MAX_LENGTH);
    }
    // End date cant before start date
    // Start date cannot be after end date


  }
}
