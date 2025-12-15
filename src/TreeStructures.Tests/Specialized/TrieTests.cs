using TreeStructures.Core.Specialized.Trie;
using Xunit;

namespace TreeStructures.Tests.Specialized;

public class TrieTests
{
    [Fact]
    public void Insert_ShouldAddWord()
    {
        // Arrange
        var trie = new Trie();

        // Act
        trie.Insert("hello");

        // Assert
        Assert.True(trie.Search("hello"));
    }

    [Fact]
    public void StartsWith_ShouldReturnTrueForPrefix()
    {
        // Arrange
        var trie = new Trie();
        trie.Insert("hello");

        // Act & Assert
        Assert.True(trie.StartsWith("hel"));
    }

    // TODO: Добавить больше тестов
}

