namespace TreeStructures.Core.SelfBalancing.AvlTree;

/// <summary>
/// Узел AVL дерева.
/// AVL дерево - самобалансирующееся бинарное дерево поиска,
/// где разница высот левого и правого поддеревьев не превышает 1.
/// </summary>
/// <typeparam name="T">Тип значений узла, должен реализовывать IComparable&lt;T&gt;</typeparam>
public class AvlNode<T> where T : IComparable<T>
{
    /// <summary>
    /// Значение узла.
    /// </summary>
    public T Value { get; set; } = default!;

    /// <summary>
    /// Левый потомок.
    /// </summary>
    public AvlNode<T>? Left { get; set; }

    /// <summary>
    /// Правый потомок.
    /// </summary>
    public AvlNode<T>? Right { get; set; }

    /// <summary>
    /// Высота узла в дереве.
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Баланс-фактор узла: высота правого поддерева - высота левого поддерева.
    /// Для AVL дерева должен быть в диапазоне [-1, 1].
    /// </summary>
    public int BalanceFactor => GetHeight(Right) - GetHeight(Left);

    private static int GetHeight(AvlNode<T>? node) => node?.Height ?? -1;
}

