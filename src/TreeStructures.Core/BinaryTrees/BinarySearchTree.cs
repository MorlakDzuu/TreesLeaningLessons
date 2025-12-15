namespace TreeStructures.Core.BinaryTrees;

/// <summary>
/// Бинарное дерево поиска (Binary Search Tree, BST).
/// Инвариант: для каждого узла все значения в левом поддереве меньше значения узла,
/// а все значения в правом поддереве больше значения узла.
/// </summary>
/// <typeparam name="T">Тип элементов дерева, должен реализовывать IComparable&lt;T&gt;</typeparam>
public class BinarySearchTree<T> where T : IComparable<T>
{
    private class Node
    {
        public T Value { get; set; } = default!;
        public Node? Left { get; set; }
        public Node? Right { get; set; }
    }

    private Node? _root;

    /// <summary>
    /// Количество элементов в дереве.
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Проверяет, пусто ли дерево.
    /// </summary>
    public bool IsEmpty => _root == null;

    /// <summary>
    /// Вставляет элемент в дерево.
    /// Сложность: O(h), где h - высота дерева. В среднем O(log n), в худшем случае O(n).
    /// </summary>
    /// <param name="value">Значение для вставки</param>
    public void Insert(T value)
    {
        // TODO: Реализовать вставку
        throw new NotImplementedException();
    }

    /// <summary>
    /// Ищет элемент в дереве.
    /// Сложность: O(h), где h - высота дерева. В среднем O(log n), в худшем случае O(n).
    /// </summary>
    /// <param name="value">Значение для поиска</param>
    /// <returns>True, если элемент найден, иначе False</returns>
    public bool Contains(T value)
    {
        // TODO: Реализовать поиск
        throw new NotImplementedException();
    }

    /// <summary>
    /// Удаляет элемент из дерева.
    /// Сложность: O(h), где h - высота дерева. В среднем O(log n), в худшем случае O(n).
    /// </summary>
    /// <param name="value">Значение для удаления</param>
    /// <returns>True, если элемент был удалён, иначе False</returns>
    public bool Delete(T value)
    {
        // TODO: Реализовать удаление (3 случая: лист, один потомок, два потомка)
        throw new NotImplementedException();
    }
}

