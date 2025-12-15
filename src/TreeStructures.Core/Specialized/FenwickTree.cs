namespace TreeStructures.Core.Specialized;

/// <summary>
/// Дерево Фенвика (Fenwick Tree, Binary Indexed Tree, BIT) - структура данных
/// для эффективных запросов суммы на префиксе.
/// Более простая в реализации альтернатива Segment Tree для запросов суммы.
/// Поддерживает обновление элемента и запрос суммы на префиксе за O(log n).
/// </summary>
public class FenwickTree
{
    private int[] _tree;
    private int _n;

    /// <summary>
    /// Создаёт дерево Фенвика из массива.
    /// Сложность построения: O(n log n).
    /// </summary>
    /// <param name="array">Исходный массив</param>
    public FenwickTree(int[] array)
    {
        // TODO: Реализовать построение дерева Фенвика
        throw new NotImplementedException();
    }

    /// <summary>
    /// Запрашивает сумму на префиксе [0, index].
    /// Сложность: O(log n).
    /// </summary>
    /// <param name="index">Правая граница префикса (включительно)</param>
    /// <returns>Сумма элементов на префиксе</returns>
    public int Query(int index)
    {
        // TODO: Реализовать запрос суммы на префиксе
        throw new NotImplementedException();
    }

    /// <summary>
    /// Запрашивает сумму на диапазоне [left, right].
    /// Сложность: O(log n).
    /// </summary>
    /// <param name="left">Левая граница диапазона</param>
    /// <param name="right">Правая граница диапазона</param>
    /// <returns>Сумма элементов на диапазоне</returns>
    public int QueryRange(int left, int right)
    {
        // TODO: Реализовать запрос суммы на диапазоне
        throw new NotImplementedException();
    }

    /// <summary>
    /// Обновляет элемент по индексу, добавляя delta к текущему значению.
    /// Сложность: O(log n).
    /// </summary>
    /// <param name="index">Индекс элемента</param>
    /// <param name="delta">Изменение значения</param>
    public void Update(int index, int delta)
    {
        // TODO: Реализовать обновление элемента
        throw new NotImplementedException();
    }
}

