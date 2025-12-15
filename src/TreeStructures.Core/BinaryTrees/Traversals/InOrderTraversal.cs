namespace TreeStructures.Core.BinaryTrees.Traversals;

/// <summary>
/// Обход дерева в порядке In-order (левое → корень → правое).
/// Для BST даёт отсортированную последовательность.
/// </summary>
public static class InOrderTraversal
{
    /// <summary>
    /// Обходит дерево рекурсивно в порядке In-order.
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="root">Корень дерева</param>
    /// <param name="action">Действие, выполняемое для каждого узла</param>
    public static void TraverseRecursive<T>(BinaryTree<T>.Node? root, Action<T> action)
    {
        // TODO: Реализовать рекурсивный обход In-order
        throw new NotImplementedException();
    }

    /// <summary>
    /// Обходит дерево итеративно в порядке In-order (используя стек).
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="root">Корень дерева</param>
    /// <param name="action">Действие, выполняемое для каждого узла</param>
    public static void TraverseIterative<T>(BinaryTree<T>.Node? root, Action<T> action)
    {
        // TODO: Реализовать итеративный обход In-order
        throw new NotImplementedException();
    }
}

