using TreeStructures.Core.Specialized;
using Xunit;

namespace TreeStructures.Tests.Specialized;

public class SegmentTreeTests
{
    [Fact]
    public void Query_ShouldReturnSumOnRange()
    {
        // Arrange
        var array = new int[] { 1, 2, 3, 4, 5 };
        var tree = new SegmentTree(array);

        // Act & Assert
        // TODO: Реализовать тест после реализации SegmentTree
        Assert.True(true);
    }

    // TODO: Добавить больше тестов
}

