namespace TreeStructures.Core.Specialized.Trie;

/// <summary>
/// Префиксное дерево (Trie, Prefix Tree) - структура данных для эффективной работы со строками.
/// Используется для автодополнения, поиска по префиксу, проверки наличия слова.
/// Вставка, поиск и удаление выполняются за O(m), где m - длина строки.
/// </summary>
public class Trie
{
    private readonly TrieNode _root;

    /// <summary>
    /// Создаёт новое пустое префиксное дерево.
    /// </summary>
    public Trie()
    {
        _root = new TrieNode();
    }

    /// <summary>
    /// Вставляет слово в Trie.
    /// Сложность: O(m), где m - длина слова.
    /// </summary>
    /// <param name="word">Слово для вставки</param>
    public void Insert(string word)
    {
        // TODO: Реализовать вставку слова
        throw new NotImplementedException();
    }

    /// <summary>
    /// Ищет слово в Trie.
    /// Сложность: O(m), где m - длина слова.
    /// </summary>
    /// <param name="word">Слово для поиска</param>
    /// <returns>True, если слово найдено, иначе False</returns>
    public bool Search(string word)
    {
        // TODO: Реализовать поиск слова
        throw new NotImplementedException();
    }

    /// <summary>
    /// Проверяет, существует ли хотя бы одно слово с данным префиксом.
    /// Сложность: O(m), где m - длина префикса.
    /// </summary>
    /// <param name="prefix">Префикс для проверки</param>
    /// <returns>True, если существует слово с таким префиксом, иначе False</returns>
    public bool StartsWith(string prefix)
    {
        // TODO: Реализовать проверку префикса
        throw new NotImplementedException();
    }

    /// <summary>
    /// Удаляет слово из Trie.
    /// Сложность: O(m), где m - длина слова.
    /// </summary>
    /// <param name="word">Слово для удаления</param>
    /// <returns>True, если слово было удалено, иначе False</returns>
    public bool Delete(string word)
    {
        // TODO: Реализовать удаление слова
        throw new NotImplementedException();
    }
}

