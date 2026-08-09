using Xunit;

namespace TimeWallpaper.Platform.Tests;

public class SmokeTests
{
    [Fact]
    public void TestFrameworkDiscoverySmokeTest()
    {
        Assert.Equal(2, 1 + 1);
    }
}
