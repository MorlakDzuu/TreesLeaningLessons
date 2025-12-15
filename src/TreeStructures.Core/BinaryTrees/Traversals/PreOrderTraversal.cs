namespace TreeStructures.Core.BinaryTrees.Traversals;

/// <summary>
/// Обход дерева в порядке Pre-order (корень → левое → правое).
/// </summary>
public static class PreOrderTraversal
{
    /// <summary>
    /// Обходит дерево рекурсивно в порядке Pre-order.
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="root">Корень дерева</param>
    /// <param name="action">Действие, выполняемое для каждого узла</param>
    public static void TraverseRecursive<T>(BinaryTree<T>.Node? root, Action<T> action)
    {
        // TODO: Реализовать рекурсивный обход Pre-order
        throw new NotImplementedException();
    }

    /// <summary>
    /// Обходит дерево итеративно в порядке Pre-order (используя стек).
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="root">Корень дерева</param>
    /// <param name="action">Действие, выполняемое для каждого узла</param>
    public static void TraverseIterative<T>(BinaryTree<T>.Node? root, Action<T> action)
    {
        // TODO: Реализовать итеративный обход Pre-order
        throw new NotImplementedException();
    }
}

