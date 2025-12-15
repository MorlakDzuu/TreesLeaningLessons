using TreeStructures.Core.SelfBalancing.AvlTree;
using Xunit;

namespace TreeStructures.Tests.SelfBalancing;

public class AvlTreeTests
{
    [Fact]
    public void Insert_ShouldMaintainBalance()
    {
        // Arrange
        var tree = new AvlTree<int>();

        // Act
        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(7);

        // Assert
        Assert.False(tree.IsEmpty);
        // TODO: Добавить проверки баланса после реализации
    }

    // TODO: Добавить больше тестов
}

