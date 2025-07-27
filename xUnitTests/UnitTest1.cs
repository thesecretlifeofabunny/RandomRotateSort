using RandomRotateSort;

namespace xUnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        List<int> toSortList = [10, 4, 1, 2];
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(sortedList is [1, 2, 4, 10]);
    }
}