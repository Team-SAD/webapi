using Xunit;
using Planner.Domain.Models;

namespace Planner.Testing
{
  public class AppUserTests
  {
    public int MAX_LENGTH = 100;
    public int MIN_LENGTH = 5;

    [Fact]
    public void EventTest1()
    {
      AppUser cs1 = new AppUser();
      Assert.NotNull(cs1);
    }

    [Theory]
    [InlineData("JLO")]
    [InlineData("Carny Bople Davidson Jr")]
    public void EventTestName(string csName)
    {
      var cs = new AppUser() { Name = csName };
      Assert.NotNull(cs.Name);
      Assert.Equal(cs.Name, cs.ToString());
      Assert.InRange(cs.Name.Length, MIN_LENGTH, MAX_LENGTH);
    }

  }
}
