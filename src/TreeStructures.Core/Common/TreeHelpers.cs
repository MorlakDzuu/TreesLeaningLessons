using TreeStructures.Core.BinaryTrees;

namespace TreeStructures.Core.Common;

/// <summary>
/// Вспомогательные методы для работы с деревьями.
/// </summary>
public static class TreeHelpers
{
    /// <summary>
    /// Вычисляет высоту дерева.
    /// Сложность: O(n), где n - количество узлов.
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="node">Корень дерева (или поддерева)</param>
    /// <returns>Высота дерева, -1 для null</returns>
    public static int CalculateHeight<T>(BinaryTree<T>.Node? node)
    {
        // TODO: Реализовать вычисление высоты
        throw new NotImplementedException();
    }

    /// <summary>
    /// Подсчитывает количество узлов в дереве.
    /// Сложность: O(n), где n - количество узлов.
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="node">Корень дерева (или поддерева)</param>
    /// <returns>Количество узлов</returns>
    public static int CountNodes<T>(BinaryTree<T>.Node? node)
    {
        // TODO: Реализовать подсчёт узлов
        throw new NotImplementedException();
    }

    /// <summary>
    /// Проверяет, является ли дерево полным бинарным деревом.
    /// Полное бинарное дерево: все уровни заполнены полностью, кроме последнего,
    /// который заполняется слева направо.
    /// </summary>
    /// <typeparam name="T">Тип значений узлов</typeparam>
    /// <param name="node">Корень дерева</param>
    /// <returns>True, если дерево полное, иначе False</returns>
    public static bool IsCompleteTree<T>(BinaryTree<T>.Node? node)
    {
        // TODO: Реализовать проверку полноты дерева
        throw new NotImplementedException();
    }
}

