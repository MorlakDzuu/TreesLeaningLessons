namespace TreeStructures.Core.Specialized.Trie;

/// <summary>
/// Узел префиксного дерева (Trie).
/// </summary>
public class TrieNode
{
    /// <summary>
    /// Дочерние узлы, индексированные по символам.
    /// </summary>
    public Dictionary<char, TrieNode> Children { get; set; }

    /// <summary>
    /// Указывает, является ли этот узел концом слова.
    /// </summary>
    public bool IsEndOfWord { get; set; }

    /// <summary>
    /// Создаёт новый узел Trie.
    /// </summary>
    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
        IsEndOfWord = false;
    }
}

