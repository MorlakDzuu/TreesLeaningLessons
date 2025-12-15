namespace TreeStructures.Core.BinaryTrees.Traversals;

/// <summary>
/// Обход Морриса (Morris Traversal) - обход дерева без использования стека и рекурсии.
/// Использует O(1) дополнительной памяти за счёт временного изменения структуры дерева.
/// </summary>
public static class MorrisTraversal
{
    /// <summary>
    /// Обходит дерево в порядке In-order используя алгоритм Морриса.
    /// Сложность: O(n), дополнительная память: O(1).
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="root">Корень дерева</param>
    /// <param name="action">Действие, выполняемое для каждого узла</param>
    public static void InOrder<T>(BinaryTree<T>.Node? root, Action<T> action)
    {
        // TODO: Реализовать обход Морриса In-order
        throw new NotImplementedException();
    }
}

