using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        //Arrange
        int[] array = null;

        //Act + Assert

        Assert.That(() => LongestIncreasingSubsequence.GetLis(array), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        //Arrange
        int[] Array = new int[] { };

        //Act
        string result = LongestIncreasingSubsequence.GetLis(Array);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        //Arrange
        int[] Array = new int[] { 5 };
        

        //Act
        string result = LongestIncreasingSubsequence.GetLis(Array);

        //Assert
        Assert.That(result, Is.EqualTo("5"));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        //Arrange
        int[] Array = new int[] { 1, 3, 4, 8, 3, 2, 1 };


        //Act
        string result = LongestIncreasingSubsequence.GetLis(Array);

        //Assert
        Assert.That(result, Is.EqualTo("1 3 4 8"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        //Arrange
        int[] Array = new int[] { 1, 3, 4, 8 };


        //Act
        string result = LongestIncreasingSubsequence.GetLis(Array);

        //Assert
        Assert.That(result, Is.EqualTo("1 3 4 8"));
    }
}
