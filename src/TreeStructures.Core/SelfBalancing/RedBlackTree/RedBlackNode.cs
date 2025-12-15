namespace TreeStructures.Core.SelfBalancing.RedBlackTree;

/// <summary>
/// Цвет узла в красно-чёрном дереве.
/// </summary>
public enum NodeColor
{
    /// <summary>
    /// Красный цвет.
    /// </summary>
    Red,

    /// <summary>
    /// Чёрный цвет.
    /// </summary>
    Black
}

/// <summary>
/// Узел красно-чёрного дерева.
/// Красно-чёрное дерево - самобалансирующееся бинарное дерево поиска
/// с дополнительными свойствами для поддержания баланса.
/// </summary>
/// <typeparam name="T">Тип значений узла, должен реализовывать IComparable&lt;T&gt;</typeparam>
public class RedBlackNode<T> where T : IComparable<T>
{
    /// <summary>
    /// Значение узла.
    /// </summary>
    public T Value { get; set; } = default!;

    /// <summary>
    /// Левый потомок.
    /// </summary>
    public RedBlackNode<T>? Left { get; set; }

    /// <summary>
    /// Правый потомок.
    /// </summary>
    public RedBlackNode<T>? Right { get; set; }

    /// <summary>
    /// Родительский узел.
    /// </summary>
    public RedBlackNode<T>? Parent { get; set; }

    /// <summary>
    /// Цвет узла.
    /// </summary>
    public NodeColor Color { get; set; }

    /// <summary>
    /// Проверяет, является ли узел красным.
    /// </summary>
    public bool IsRed => Color == NodeColor.Red;

    /// <summary>
    /// Проверяет, является ли узел чёрным.
    /// </summary>
    public bool IsBlack => Color == NodeColor.Black;
}

