namespace TreeStructures.Core.Specialized;

/// <summary>
/// Дерево отрезков (Segment Tree) - структура данных для эффективных запросов на диапазоне.
/// Поддерживает запросы суммы/минимума/максимума на отрезке за O(log n)
/// и обновление одного элемента за O(log n).
/// </summary>
public class SegmentTree
{
    private int[] _tree;
    private int _n;

    /// <summary>
    /// Создаёт дерево отрезков из массива.
    /// Сложность построения: O(n).
    /// </summary>
    /// <param name="array">Исходный массив</param>
    public SegmentTree(int[] array)
    {
        // TODO: Реализовать построение дерева
        throw new NotImplementedException();
    }

    /// <summary>
    /// Запрашивает сумму на диапазоне [left, right].
    /// Сложность: O(log n).
    /// </summary>
    /// <param name="left">Левая граница диапазона (включительно)</param>
    /// <param name="right">Правая граница диапазона (включительно)</param>
    /// <returns>Сумма элементов на диапазоне</returns>
    public int Query(int left, int right)
    {
        // TODO: Реализовать запрос суммы на диапазоне
        throw new NotImplementedException();
    }

    /// <summary>
    /// Обновляет элемент по индексу.
    /// Сложность: O(log n).
    /// </summary>
    /// <param name="index">Индекс элемента</param>
    /// <param name="value">Новое значение</param>
    public void Update(int index, int value)
    {
        // TODO: Реализовать обновление элемента
        throw new NotImplementedException();
    }
}

