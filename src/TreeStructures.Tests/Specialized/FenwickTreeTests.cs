using TreeStructures.Core.Specialized;
using Xunit;

namespace TreeStructures.Tests.Specialized;

public class FenwickTreeTests
{
    [Fact]
    public void Query_ShouldReturnPrefixSum()
    {
        // Arrange
        var array = new int[] { 1, 2, 3, 4, 5 };
        var tree = new FenwickTree(array);

        // Act & Assert
        // TODO: Реализовать тест после реализации FenwickTree
        Assert.True(true);
    }

    // TODO: Добавить больше тестов
}

