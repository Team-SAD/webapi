using Xunit;
using Planner.Domain.Models;

namespace Planner.Testing
{
  public class PlannerTests
  {
    public int MAX_LENGTH = 100;
    public int MIN_LENGTH = 5;

    [Fact]
    public void PlannerTest1()
    {
      Plan planner = new Plan();
      Assert.NotNull(planner);
    }

    public void PlannerTest2()
    {
      Plan planner = new Plan();
      Assert.NotNull(planner);
    }

  }
}
