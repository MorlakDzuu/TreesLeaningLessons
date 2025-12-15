using TreeStructures.Core.SelfBalancing.RedBlackTree;
using Xunit;

namespace TreeStructures.Tests.SelfBalancing;

public class RedBlackTreeTests
{
    [Fact]
    public void Insert_ShouldMaintainRedBlackProperties()
    {
        // Arrange
        var tree = new RedBlackTree<int>();

        // Act
        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(7);

        // Assert
        Assert.False(tree.IsEmpty);
        // TODO: Добавить проверки свойств красно-чёрного дерева после реализации
    }

    // TODO: Добавить больше тестов
}

