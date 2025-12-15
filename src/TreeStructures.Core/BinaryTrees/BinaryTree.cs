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
        // TODO: Реализовать вычисление высоты
        throw new NotImplementedException();
    }

    /// <summary>
    /// Подсчитывает количество листьев в дереве.
    /// Сложность: O(n), где n - количество узлов.
    /// </summary>
    /// <returns>Количество листьев</returns>
    public int CountLeaves()
    {
        // TODO: Реализовать подсчёт листьев
        throw new NotImplementedException();
    }
}

