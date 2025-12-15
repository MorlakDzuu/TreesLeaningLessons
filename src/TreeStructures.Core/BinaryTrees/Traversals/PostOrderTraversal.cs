namespace TreeStructures.Core.BinaryTrees.Traversals;

/// <summary>
/// Обход дерева в порядке Post-order (левое → правое → корень).
/// </summary>
public static class PostOrderTraversal
{
    /// <summary>
    /// Обходит дерево рекурсивно в порядке Post-order.
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="root">Корень дерева</param>
    /// <param name="action">Действие, выполняемое для каждого узла</param>
    public static void TraverseRecursive<T>(BinaryTree<T>.Node? root, Action<T> action)
    {
        // TODO: Реализовать рекурсивный обход Post-order
        throw new NotImplementedException();
    }

    /// <summary>
    /// Обходит дерево итеративно в порядке Post-order (используя стек).
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="root">Корень дерева</param>
    /// <param name="action">Действие, выполняемое для каждого узла</param>
    public static void TraverseIterative<T>(BinaryTree<T>.Node? root, Action<T> action)
    {
        // TODO: Реализовать итеративный обход Post-order
        throw new NotImplementedException();
    }
}

