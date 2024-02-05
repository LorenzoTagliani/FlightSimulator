namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        bool valore = true;
        Assert.True(valore);
    }

    [Fact]
    public void Test2()
    {
        Assert.True(true);
    }
}