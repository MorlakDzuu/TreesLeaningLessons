using TreeStructures.Core.BinaryTrees;
using Xunit;

namespace TreeStructures.Tests.BinaryTrees;

public class BinaryTreeTests
{
    [Fact]
    public void Height_WhenTreeIsEmpty_ShouldReturnMinusOne()
    {
        // Arrange
        var tree = new BinaryTree<int>();

        // Act
        var height = tree.Height();

        // Assert
        Assert.Equal(-1, height);
    }

    [Fact]
    public void Height_WhenTreeHasSingleNode_ShouldReturnZero()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5);

        // Act
        var height = tree.Height();

        // Assert
        Assert.Equal(0, height);
    }

    [Fact]
    public void Height_WhenTreeHasTwoLevels_ShouldReturnOne()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5)
        {
            Left = new BinaryTree<int>.Node(3),
            Right = new BinaryTree<int>.Node(7)
        };

        // Act
        var height = tree.Height();

        // Assert
        Assert.Equal(1, height);
    }

    [Fact]
    public void Height_WhenTreeHasThreeLevels_ShouldReturnTwo()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5)
        {
            Left = new BinaryTree<int>.Node(3)
            {
                Left = new BinaryTree<int>.Node(2),
                Right = new BinaryTree<int>.Node(4)
            },
            Right = new BinaryTree<int>.Node(7)
            {
                Left = new BinaryTree<int>.Node(6),
                Right = new BinaryTree<int>.Node(8)
            }
        };

        // Act
        var height = tree.Height();

        // Assert
        Assert.Equal(2, height);
    }

    [Fact]
    public void Height_WhenTreeIsLeftSkewed_ShouldReturnCorrectHeight()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5)
        {
            Left = new BinaryTree<int>.Node(4)
            {
                Left = new BinaryTree<int>.Node(3)
                {
                    Left = new BinaryTree<int>.Node(2)
                }
            }
        };

        // Act
        var height = tree.Height();

        // Assert
        Assert.Equal(3, height);
    }

    [Fact]
    public void Height_WhenTreeIsRightSkewed_ShouldReturnCorrectHeight()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(1)
        {
            Right = new BinaryTree<int>.Node(2)
            {
                Right = new BinaryTree<int>.Node(3)
                {
                    Right = new BinaryTree<int>.Node(4)
                }
            }
        };

        // Act
        var height = tree.Height();

        // Assert
        Assert.Equal(3, height);
    }

    [Fact]
    public void Height_WhenTreeHasUnbalancedStructure_ShouldReturnMaxDepth()
    {
        // Arrange
        // Дерево, где левая ветвь глубже правой
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(10)
        {
            Left = new BinaryTree<int>.Node(5)
            {
                Left = new BinaryTree<int>.Node(3)
                {
                    Left = new BinaryTree<int>.Node(1),
                    Right = new BinaryTree<int>.Node(4)
                },
                Right = new BinaryTree<int>.Node(7)
            },
            Right = new BinaryTree<int>.Node(15)
        };

        // Act
        var height = tree.Height();

        // Assert
        // Высота должна быть максимальной глубиной (3 в данном случае)
        Assert.Equal(3, height);
    }

    [Fact]
    public void Height_WhenTreeHasOnlyLeftChild_ShouldReturnOne()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5)
        {
            Left = new BinaryTree<int>.Node(3)
        };

        // Act
        var height = tree.Height();

        // Assert
        Assert.Equal(1, height);
    }

    [Fact]
    public void Height_WhenTreeHasOnlyRightChild_ShouldReturnOne()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5)
        {
            Right = new BinaryTree<int>.Node(7)
        };

        // Act
        var height = tree.Height();

        // Assert
        Assert.Equal(1, height);
    }

    [Fact]
    public void CountLeaves_WhenTreeIsEmpty_ShouldReturnZero()
    {
        // Arrange
        var tree = new BinaryTree<int>();

        // Act
        var count = tree.CountLeaves();

        // Assert
        Assert.Equal(0, count);
    }

    [Fact]
    public void CountLeaves_WhenTreeHasSingleNode_ShouldReturnOne()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5);

        // Act
        var count = tree.CountLeaves();

        // Assert
        Assert.Equal(1, count);
    }

    [Fact]
    public void CountLeaves_WhenTreeHasTwoLevels_ShouldReturnTwo()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5)
        {
            Left = new BinaryTree<int>.Node(3),
            Right = new BinaryTree<int>.Node(7)
        };

        // Act
        var count = tree.CountLeaves();

        // Assert
        Assert.Equal(2, count);
    }

    [Fact]
    public void CountLeaves_WhenTreeHasThreeLevels_ShouldReturnFour()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5)
        {
            Left = new BinaryTree<int>.Node(3)
            {
                Left = new BinaryTree<int>.Node(2),
                Right = new BinaryTree<int>.Node(4)
            },
            Right = new BinaryTree<int>.Node(7)
            {
                Left = new BinaryTree<int>.Node(6),
                Right = new BinaryTree<int>.Node(8)
            }
        };

        // Act
        var count = tree.CountLeaves();

        // Assert
        Assert.Equal(4, count);
    }

    [Fact]
    public void CountLeaves_WhenTreeIsLeftSkewed_ShouldReturnOne()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5)
        {
            Left = new BinaryTree<int>.Node(4)
            {
                Left = new BinaryTree<int>.Node(3)
                {
                    Left = new BinaryTree<int>.Node(2)
                }
            }
        };

        // Act
        var count = tree.CountLeaves();

        // Assert
        Assert.Equal(1, count);
    }

    [Fact]
    public void CountLeaves_WhenTreeIsRightSkewed_ShouldReturnOne()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(1)
        {
            Right = new BinaryTree<int>.Node(2)
            {
                Right = new BinaryTree<int>.Node(3)
                {
                    Right = new BinaryTree<int>.Node(4)
                }
            }
        };

        // Act
        var count = tree.CountLeaves();

        // Assert
        Assert.Equal(1, count);
    }

    [Fact]
    public void CountLeaves_WhenTreeHasUnbalancedStructure_ShouldReturnCorrectCount()
    {
        // Arrange
        // Дерево, где левая ветвь глубже правой
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(10)
        {
            Left = new BinaryTree<int>.Node(5)
            {
                Left = new BinaryTree<int>.Node(3)
                {
                    Left = new BinaryTree<int>.Node(1),
                    Right = new BinaryTree<int>.Node(4)
                },
                Right = new BinaryTree<int>.Node(7)
            },
            Right = new BinaryTree<int>.Node(15)
        };

        // Act
        var count = tree.CountLeaves();

        // Assert
        // Листья: 1, 4, 7, 15 - всего 4 листа
        Assert.Equal(4, count);
    }

    [Fact]
    public void CountLeaves_WhenTreeHasOnlyLeftChild_ShouldReturnOne()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5)
        {
            Left = new BinaryTree<int>.Node(3)
        };

        // Act
        var count = tree.CountLeaves();

        // Assert
        Assert.Equal(1, count);
    }

    [Fact]
    public void CountLeaves_WhenTreeHasOnlyRightChild_ShouldReturnOne()
    {
        // Arrange
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(5)
        {
            Right = new BinaryTree<int>.Node(7)
        };

        // Act
        var count = tree.CountLeaves();

        // Assert
        Assert.Equal(1, count);
    }

    [Fact]
    public void CountLeaves_WhenTreeHasMixedStructure_ShouldReturnCorrectCount()
    {
        // Arrange
        // Дерево с разной глубиной ветвей
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(10)
        {
            Left = new BinaryTree<int>.Node(5)
            {
                Left = new BinaryTree<int>.Node(3),
                Right = new BinaryTree<int>.Node(7)
                {
                    Left = new BinaryTree<int>.Node(6)
                }
            },
            Right = new BinaryTree<int>.Node(15)
        };

        // Act
        var count = tree.CountLeaves();

        // Assert
        // Листья: 3, 6, 15 - всего 3 листа
        Assert.Equal(3, count);
    }

    [Fact]
    public void CountLeaves_WhenTreeHasSingleLeafAtDeepLevel_ShouldReturnOne()
    {
        // Arrange
        // Дерево, где все узлы имеют только одного потомка, кроме последнего
        var tree = new BinaryTree<int>();
        tree.Root = new BinaryTree<int>.Node(1)
        {
            Left = new BinaryTree<int>.Node(2)
            {
                Right = new BinaryTree<int>.Node(3)
                {
                    Left = new BinaryTree<int>.Node(4)
                }
            }
        };

        // Act
        var count = tree.CountLeaves();

        // Assert
        Assert.Equal(1, count);
    }
}

