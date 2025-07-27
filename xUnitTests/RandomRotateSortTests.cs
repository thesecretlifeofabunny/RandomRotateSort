using RandomRotateSort;

namespace xUnitTests;

public class RandomRotateSortTests
{
    [Fact]
    public void RandomRotateSort_EmptyList_ReturnsEmptyList()
    {
        List<int> toSortList = [];
       
        RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(toSortList is []);
    }
    
    [Fact]
    public void RandomRotateSort_OneElement_ReturnsSameElement()
    {
        List<int> toSortList = [10];
       
        RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(toSortList is [10]);
    }
    
    [Fact]
    public void RandomRotateSort_TwoElements_ReturnsSwappedElementsSorted()
    {
        List<int> toSortList = [10, 2];
       
        RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(toSortList is [2, 10]);
    }
    
    [Fact]
    public void RandomRotateSort_ThreeElements_ReturnsSortedList()
    {
        List<int> toSortList = [ 4, 1, 2];
       
        RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(toSortList is [1, 2, 4]);
    }
    
    [Fact]
    public void RandomRotateSort_FourElements_ReturnsSortedList()
    {
        List<int> toSortList = [10, 4, 1, 2];
       
        RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(toSortList is [1, 2, 4, 10]);
    }
    
    [Fact]
    public void RandomRotateSort_TenElements_ReturnsSortedList()
    {
        List<int> toSortList = [10, 4, 1, 2, 9, 23, 213, 321, 421, 21];
       
        RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(toSortList is [1, 2, 4, 9, 10, 21, 23, 213, 321, 421]);
    }
    
    [Fact]
    public void RandomRotateSort_TwentyFiveElements_ReturnsSortedList()
    {
        const int numberOfElementsToInsert = 25;
        List<int> toSortList = [];
        List<int> inBuiltSortedList = [];
        Random randomGenerator = new();

        for (var i = 0; i < numberOfElementsToInsert; i++)
        {
            var randomNumberToAdd = randomGenerator.Next();
            toSortList.Add(randomNumberToAdd);
            inBuiltSortedList.Add(randomNumberToAdd);
        }
        
        inBuiltSortedList.Sort();
        
        RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(toSortList == inBuiltSortedList);
    }
    
    [Fact]
    public void RandomRotateSort_FiftyElements_ReturnsSortedList()
    {
        const int numberOfElementsToInsert = 50;
        List<int> toSortList = [];
        List<int> inBuiltSortedList = [];
        Random randomGenerator = new();

        for (var i = 0; i < numberOfElementsToInsert; i++)
        {
            var randomNumberToAdd = randomGenerator.Next();
            toSortList.Add(randomNumberToAdd);
            inBuiltSortedList.Add(randomNumberToAdd);
        }
        
        inBuiltSortedList.Sort();
        
        RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(toSortList == inBuiltSortedList);
    }
    
    [Fact]
    public void RandomRotateSort_OneHundredElements_ReturnsSortedList()
    {
        const int numberOfElementsToInsert = 100;
        List<int> toSortList = [];
        List<int> inBuiltSortedList = [];
        Random randomGenerator = new();

        for (var i = 0; i < numberOfElementsToInsert; i++)
        {
            var randomNumberToAdd = randomGenerator.Next();
            toSortList.Add(randomNumberToAdd);
            inBuiltSortedList.Add(randomNumberToAdd);
        }
        
        inBuiltSortedList.Sort();
        
        RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(toSortList == inBuiltSortedList);
    }
    
    [Fact]
    public void RandomRotateSort_OneThousandElements_ReturnsSortedList()
    {
        const int numberOfElementsToInsert = 1000;
        List<int> toSortList = [];
        List<int> inBuiltSortedList = [];
        Random randomGenerator = new();

        for (var i = 0; i < numberOfElementsToInsert; i++)
        {
            var randomNumberToAdd = randomGenerator.Next();
            toSortList.Add(randomNumberToAdd);
            inBuiltSortedList.Add(randomNumberToAdd);
        }
        
        inBuiltSortedList.Sort();
        
        RandomRotateSort.RandomRotateSort.Sort(toSortList);
        
        Assert.True(toSortList == inBuiltSortedList);
    }
}