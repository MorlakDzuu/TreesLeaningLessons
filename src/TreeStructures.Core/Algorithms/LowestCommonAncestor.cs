using TreeStructures.Core.BinaryTrees;

namespace TreeStructures.Core.Algorithms;

/// <summary>
/// Алгоритмы поиска наименьшего общего предка (Lowest Common Ancestor, LCA) в дереве.
/// </summary>
public static class LowestCommonAncestor
{
    /// <summary>
    /// Находит наименьшего общего предка двух узлов наивным способом.
    /// Сложность: O(n) на запрос, где n - количество узлов.
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="root">Корень дерева</param>
    /// <param name="node1">Первый узел</param>
    /// <param name="node2">Второй узел</param>
    /// <returns>Наименьший общий предок или null, если не найден</returns>
    public static BinaryTree<T>.Node? FindNaive<T>(
        BinaryTree<T>.Node? root,
        BinaryTree<T>.Node? node1,
        BinaryTree<T>.Node? node2)
    {
        // TODO: Реализовать наивный алгоритм LCA
        throw new NotImplementedException();
    }

    /// <summary>
    /// Находит наименьшего общего предка двух узлов используя бинарный подъём.
    /// Сложность: O(log n) на запрос после предобработки O(n log n), где n - количество узлов.
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="root">Корень дерева</param>
    /// <param name="node1">Первый узел</param>
    /// <param name="node2">Второй узел</param>
    /// <returns>Наименьший общий предок или null, если не найден</returns>
    public static BinaryTree<T>.Node? FindBinaryLifting<T>(
        BinaryTree<T>.Node? root,
        BinaryTree<T>.Node? node1,
        BinaryTree<T>.Node? node2)
    {
        // TODO: Реализовать LCA через бинарный подъём
        throw new NotImplementedException();
    }
}

