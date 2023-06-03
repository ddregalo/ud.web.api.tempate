using NSubstitute;

namespace UDWebAPITemplateApp.Application.Tests;

public class UnitTest1
{
    private readonly IMyFancyInterface _fancyInterface = Substitute.For<IMyFancyInterface>();
    [Fact]
    public void Test1()
    {
        Assert.True(false);
        _fancyInterface.GetNumber(Arg.Is<int>(x => x > 0), 123).Returns(420);
    }
}

public interface IMyFancyInterface
{
    public int GetNumber(int arg1, int arg2);
}
