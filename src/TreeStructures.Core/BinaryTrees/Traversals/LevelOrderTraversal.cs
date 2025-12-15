namespace TreeStructures.Core.BinaryTrees.Traversals;

/// <summary>
/// Обход дерева в порядке Level-order (BFS - по уровням).
/// Использует очередь для обхода дерева по уровням.
/// </summary>
public static class LevelOrderTraversal
{
    /// <summary>
    /// Обходит дерево в порядке Level-order (BFS).
    /// Сложность: O(n), где n - количество узлов.
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="root">Корень дерева</param>
    /// <param name="action">Действие, выполняемое для каждого узла</param>
    public static void Traverse<T>(BinaryTree<T>.Node? root, Action<T> action)
    {
        // TODO: Реализовать обход Level-order (BFS с использованием очереди)
        throw new NotImplementedException();
    }
}

