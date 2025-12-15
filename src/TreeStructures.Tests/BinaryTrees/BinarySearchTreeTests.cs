using TreeStructures.Core.BinaryTrees;
using Xunit;

namespace TreeStructures.Tests.BinaryTrees;

public class BinarySearchTreeTests
{
    [Fact]
    public void Insert_ShouldAddElement()
    {
        // Arrange
        var tree = new BinarySearchTree<int>();

        // Act
        tree.Insert(5);

        // Assert
        Assert.False(tree.IsEmpty);
        Assert.True(tree.Contains(5));
    }

    [Fact]
    public void Contains_WhenElementDoesNotExist_ShouldReturnFalse()
    {
        // Arrange
        var tree = new BinarySearchTree<int>();

        // Act & Assert
        Assert.False(tree.Contains(5));
    }

    // TODO: Добавить больше тестов
}

