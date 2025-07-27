using RandomRotateSort;

namespace xUnitTests;

public class RandomRotateSortTests
{
    [Fact]
    public void RandomRotateSort_EmptyList_ReturnsEmptyList()
    {
        List<int> toSortList = [];
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(sortedList is []);
    }
    
    [Fact]
    public void RandomRotateSort_OneElement_ReturnsSameElement()
    {
        List<int> toSortList = [10];
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(sortedList is [10]);
    }
    
    [Fact]
    public void RandomRotateSort_TwoElements_ReturnsSwappedElementsSorted()
    {
        List<int> toSortList = [10, 2];
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(sortedList is [2, 10]);
    }
    
    [Fact]
    public void RandomRotateSort_ThreeElements_ReturnsSortedList()
    {
        List<int> toSortList = [ 4, 1, 2];
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(sortedList is [1, 2, 4]);
    }
    
    [Fact]
    public void RandomRotateSort_FourElements_ReturnsSortedList()
    {
        List<int> toSortList = [10, 4, 1, 2];
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(sortedList is [1, 2, 4, 10]);
    }
    
    [Fact]
    public void RandomRotateSort_TenElements_ReturnsSortedList()
    {
        List<int> toSortList = [10, 4, 1, 2, 9, 23, 213, 321, 421, 21];
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(sortedList is [1, 2, 4, 9, 10, 21, 23, 213, 321, 421]);
    }
    
    [Fact]
    public void RandomRotateSort_TwentyFiveElements_ReturnsSortedList()
    {
        const int numberOfElementsToInsert = 25;   
        List<int> toSortList = [];
        Random randomGenerator = new();

        for (var i = 0; i < numberOfElementsToInsert; i++)
        {
            toSortList.Add(randomGenerator.Next());
        }
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        toSortList.Sort();
        
        Assert.True(sortedList == toSortList);
    }
    
    [Fact]
    public void RandomRotateSort_FiftyElements_ReturnsSortedList()
    {
        const int numberOfElementsToInsert = 50;   
        List<int> toSortList = [];
        Random randomGenerator = new();

        for (var i = 0; i < numberOfElementsToInsert; i++)
        {
            toSortList.Add(randomGenerator.Next());
        }
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        toSortList.Sort();
        
        Assert.True(sortedList == toSortList);
    }
    
    [Fact]
    public void RandomRotateSort_OneHundredElements_ReturnsSortedList()
    {
        const int numberOfElementsToInsert = 100;   
        List<int> toSortList = [];
        Random randomGenerator = new();

        for (var i = 0; i < numberOfElementsToInsert; i++)
        {
            toSortList.Add(randomGenerator.Next());
        }
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        toSortList.Sort();
        
        Assert.True(sortedList == toSortList);
    }
    
    [Fact]
    public void RandomRotateSort_OneThousandElements_ReturnsSortedList()
    {
        const int numberOfElementsToInsert = 1000;   
        List<int> toSortList = [];
        Random randomGenerator = new();

        for (var i = 0; i < numberOfElementsToInsert; i++)
        {
            toSortList.Add(randomGenerator.Next());
        }
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        toSortList.Sort();
        
        Assert.True(sortedList == toSortList);
    }
    
    [Fact]
    public void RandomRotateSort_TenThousandElements_ReturnsSortedList()
    {
        const int numberOfElementsToInsert = 10000;   
        List<int> toSortList = [];
        Random randomGenerator = new();

        for (var i = 0; i < numberOfElementsToInsert; i++)
        {
            toSortList.Add(randomGenerator.Next());
        }
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        toSortList.Sort();
        
        Assert.True(sortedList == toSortList);
    }
    
    [Fact]
    public void RandomRotateSort_OneHundredThousandElements_ReturnsSortedList()
    {
        const int numberOfElementsToInsert = 100000;   
        List<int> toSortList = [];
        Random randomGenerator = new();

        for (var i = 0; i < numberOfElementsToInsert; i++)
        {
            toSortList.Add(randomGenerator.Next());
        }
       
        var sortedList = RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        toSortList.Sort();
        
        Assert.True(sortedList == toSortList);
    }
}