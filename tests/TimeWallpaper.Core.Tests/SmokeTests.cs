using Xunit;

namespace TimeWallpaper.Core.Tests;

public class SmokeTests
{
    [Fact]
    public void TestFrameworkDiscoverySmokeTest()
    {
        Assert.Equal(2, 1 + 1);
    }
}
