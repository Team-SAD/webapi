using Xunit;
using Planner.Domain.Models;
using System.Collections.Generic;
using System;

namespace Planner.Testing
{
  public class PlannerTests
  {
    public int MAX_LENGTH = 12;
    public int MIN_LENGTH = 1;
    public int MAX_EVENTS = 30;
    public int LISTING = 15;

    public static IEnumerable<object[]> eventList = new List<object[]>()
    {
      new object[] { new Event(){Title = "Dave's Birthday", Description = "Its someone's person today"} },
      new object[] { new Event(){Title = "Ted & Ned's Anniversy", Description = "Its tmime for the party, the poarty of the two people that we all know."} },
    };

    public static IEnumerable<object[]> customerList = new List<object[]>()
    {
      new object[] { new Customer(){Name = "Rebecca Algoeth"}},
      new object[] { new Customer(){Name = "Ash Ketyup"}},
      new object[] { new Customer(){Name = "Megodola Euimun"}}
    };

    [Fact]
    public void PlannerTest1()
    {
      Plan planner = new Plan();
      Assert.NotNull(planner);
      Assert.Empty(planner.Events);
      Assert.NotNull(planner.Customer);
      Assert.IsType<int>(planner.Month);

      planner.Customer.Name = "First Last";
      planner.Month = 03;
    }

    [Theory]
    // [InlineData("LeePenguin")]
    [MemberData(nameof(eventList))]

    public void PlannerTestEvents(Event ev)
    {
      Plan planner = new Plan();
      planner.Events.Add(ev);
      Assert.NotEmpty(planner.Events);
      for (int i = 0; i < LISTING; i++)
      {
        planner.Events.Add(ev);
      }
      Assert.InRange(planner.Events.Count, MIN_LENGTH, MAX_EVENTS);
    }

    [Theory]
    [InlineData(07)]
    [InlineData(03)]
    [InlineData(12)]
    public void PlannerTestMonthPass(int mnth)
    {
      Plan planner = new Plan() { Month = mnth };
      Assert.InRange(planner.Month, MIN_LENGTH, MAX_LENGTH);
    }

    [Theory]
    [InlineData(43)]
    [InlineData(99)]
    [InlineData(14)]
    public void PlannerTestMonthFail(int mnth)
    {
      Plan planner = new Plan() { Month = mnth };
      Assert.NotInRange(planner.Month, MIN_LENGTH, MAX_LENGTH);
    }

    [Theory]
    [InlineData("2021-11-4 14:25 PM", 11)]
    [InlineData("2021-10-12 10:25 PM", 10)]
    [InlineData("2021-03-22 06:25 PM", 3)]

    public void PlannerTestMonthEventPass(string d1, int mnth)
    {
      var start = DateTime.Parse(d1);

      Plan planner = new Plan() { Month = mnth };
      Event ev = new Event { StartDate = start };

      planner.Events.Add(ev);

      foreach (Event item in planner.Events)
      {
        Assert.Equal(item.StartDate.Month, planner.Month);
      }
    }

    [Theory]
    [InlineData("2021-01-4 14:25 PM", 11)]
    [InlineData("2021-08-12 10:25 PM", 10)]
    [InlineData("2021-12-22 06:25 PM", 6)]

    public void PlannerTestMonthEventFail(string d1, int mnth)
    {
      var start = DateTime.Parse(d1);

      Plan planner = new Plan() { Month = mnth };
      Event ev = new Event { StartDate = start };

      planner.Events.Add(ev);

      foreach (Event item in planner.Events)
      {
        Assert.NotEqual(item.StartDate.Month, planner.Month);
      }
    }

    [Theory]
    [MemberData(nameof(customerList))]

    public void PlannerTestCustomers(Customer cs)
    {
      Plan planner = new Plan();
      planner.Customer = cs;
      Assert.NotNull(planner.Customer);
    }

  }
}
