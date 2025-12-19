namespace TreeStructures.Core.BinaryTrees;

/// <summary>
/// Базовое бинарное дерево (без инварианта поиска).
/// Используется для представления произвольного бинарного дерева.
/// </summary>
/// <typeparam name="T">Тип элементов дерева</typeparam>
public class BinaryTree<T>
{
    /// <summary>
    /// Узел бинарного дерева.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Значение узла.
        /// </summary>
        public T Value { get; set; } = default!;

        /// <summary>
        /// Левый потомок.
        /// </summary>
        public Node? Left { get; set; }

        /// <summary>
        /// Правый потомок.
        /// </summary>
        public Node? Right { get; set; }

        /// <summary>
        /// Создаёт новый узел с указанным значением.
        /// </summary>
        public Node(T value)
        {
            Value = value;
        }

        public int Height()
        {
            if (Left == null && Right == null) return 0;
            int leftHeight = Left?.Height() ?? -1;
            int rightHeight = Right?.Height() ?? -1;
            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public int CountLeaves()
        {
            if (Left == null && Right == null) return 1;
            int leftLeaves = Left?.CountLeaves() ?? 0;
            int rightLeaves = Right?.CountLeaves() ?? 0;
            return leftLeaves + rightLeaves;
        }
    }

    /// <summary>
    /// Корень дерева.
    /// </summary>
    public Node? Root { get; set; }

    /// <summary>
    /// Вычисляет высоту дерева.
    /// Сложность: O(n), где n - количество узлов.
    /// </summary>
    /// <returns>Высота дерева, -1 для пустого дерева</returns>
    public int Height()
    {
        if (Root == null) return -1;
        return Root.Height();
    }

    /// <summary>
    /// Подсчитывает количество листьев в дереве.
    /// Сложность: O(n), где n - количество узлов.
    /// </summary>
    /// <returns>Количество листьев</returns>
    public int CountLeaves()
    {
        if (Root == null) return 0;
        return Root.CountLeaves();
    }
}

