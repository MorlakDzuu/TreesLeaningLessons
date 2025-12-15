using TreeStructures.Core.BinaryTrees;

namespace TreeStructures.Core.Algorithms;

/// <summary>
/// Алгоритмы для работы с диаметром дерева.
/// Диаметр дерева - длина самого длинного пути между любыми двумя узлами.
/// </summary>
public static class TreeDiameter
{
    /// <summary>
    /// Вычисляет диаметр дерева используя два BFS (или DFS).
    /// Сложность: O(n), где n - количество узлов.
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="root">Корень дерева</param>
    /// <returns>Диаметр дерева (длина самого длинного пути)</returns>
    public static int Calculate<T>(BinaryTree<T>.Node? root)
    {
        // TODO: Реализовать вычисление диаметра дерева (2 BFS/DFS)
        throw new NotImplementedException();
    }
}

