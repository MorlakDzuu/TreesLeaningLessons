namespace TreeStructures.Core.Optimization;

/// <summary>
/// Представление дерева через массив (heap-like структура).
/// Эффективно для полных бинарных деревьев и обеспечивает лучшее использование кэша процессора.
/// Индексация: для узла с индексом i: левый потомок = 2*i+1, правый = 2*i+2, родитель = (i-1)/2
/// </summary>
/// <typeparam name="T">Тип элементов дерева</typeparam>
public class ArrayBasedTree<T>
{
    private T?[] _array;
    private int _size;

    /// <summary>
    /// Создаёт дерево на основе массива заданного размера.
    /// </summary>
    /// <param name="capacity">Максимальная ёмкость дерева</param>
    public ArrayBasedTree(int capacity)
    {
        // TODO: Реализовать инициализацию
        throw new NotImplementedException();
    }

    /// <summary>
    /// Получает значение узла по индексу.
    /// </summary>
    /// <param name="index">Индекс узла</param>
    /// <returns>Значение узла</returns>
    public T? GetValue(int index)
    {
        // TODO: Реализовать получение значения
        throw new NotImplementedException();
    }

    /// <summary>
    /// Устанавливает значение узла по индексу.
    /// </summary>
    /// <param name="index">Индекс узла</param>
    /// <param name="value">Значение узла</param>
    public void SetValue(int index, T value)
    {
        // TODO: Реализовать установку значения
        throw new NotImplementedException();
    }

    /// <summary>
    /// Получает индекс левого потомка.
    /// </summary>
    /// <param name="parentIndex">Индекс родителя</param>
    /// <returns>Индекс левого потомка</returns>
    public static int GetLeftChildIndex(int parentIndex) => 2 * parentIndex + 1;

    /// <summary>
    /// Получает индекс правого потомка.
    /// </summary>
    /// <param name="parentIndex">Индекс родителя</param>
    /// <returns>Индекс правого потомка</returns>
    public static int GetRightChildIndex(int parentIndex) => 2 * parentIndex + 2;

    /// <summary>
    /// Получает индекс родителя.
    /// </summary>
    /// <param name="childIndex">Индекс потомка</param>
    /// <returns>Индекс родителя</returns>
    public static int GetParentIndex(int childIndex) => (childIndex - 1) / 2;
}

