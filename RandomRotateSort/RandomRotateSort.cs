using System;

namespace RandomRotateSort;

public abstract class RandomRotateSort
{
    public static List<int> Sort(List<int> unsortedList)
    {
        while (IsListNotSorted(unsortedList))
        {
            var numberOfIndicesToRotate = RandomNumberOfIndices(unsortedList.Count);
            Console.WriteLine($"Rotating {numberOfIndicesToRotate} indices...");

            var elementsToRotate = RandomListOfElementsToRotate(numberOfIndicesToRotate, unsortedList.Count);
            var numberOfRotations = RandomNumberOfRotations(numberOfIndicesToRotate);
            Console.WriteLine($"Rotating numbers at {elementsToRotate} {numberOfRotations} times...");

            unsortedList = RotateUnsortedList(unsortedList, elementsToRotate, numberOfRotations);
        }
        return unsortedList;
    }

    private static List<int> RotateUnsortedList(List<int> listToRotate, List<int> elementsToRotate, int numberOfRotations)
    {
        List<int> indexValuesToRotate = [];
        indexValuesToRotate.AddRange(elementsToRotate.Select(indexNumber => listToRotate[indexNumber]));

        for (var i = 0; i < indexValuesToRotate.Count ; i++)
        {
            var indexValueToInsert = indexValuesToRotate[i];
            var newElementToRotateIndex = (i + numberOfRotations) % elementsToRotate.Count;
            var insertionIndex = elementsToRotate[newElementToRotateIndex];
            listToRotate[insertionIndex] = indexValueToInsert;
        }
        
        return listToRotate;
    }

    private static int RandomNumberOfRotations(int numberOfIndicesToRotate)
    {
        Random randomGenerator = new();
        return randomGenerator.Next(numberOfIndicesToRotate);
    }

    private static List<int> RandomListOfElementsToRotate(int numberOfIndices, int lengthOfList)
    {
        List<int> indicesToRotate = [];
        Random randomGenerator = new();
        var numberAddedIndices = 0;
        while (numberAddedIndices < numberOfIndices)
        {
            var randomIndex = randomGenerator.Next(lengthOfList);

            if (indicesToRotate.Contains(randomIndex)) continue;
            
            indicesToRotate.Add(randomIndex);
            numberAddedIndices += 1;
        }

        return indicesToRotate;
    }

    private static int RandomNumberOfIndices(int lengthOfList)
    {
        Random randomGenerator = new();
        return randomGenerator.Next(lengthOfList + 1);
    }

    private static bool IsListNotSorted(List<int> listToCheck)
    {
        int? previousNumber = null;
        foreach (var currentNumber in listToCheck)
        {
            if (previousNumber is null)
            {
                previousNumber = currentNumber;
                continue;
            }

            if (previousNumber > currentNumber)
            {
                return true;
            }
            
            previousNumber = currentNumber;
        }
        return false;
    }
}