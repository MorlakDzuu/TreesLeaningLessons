namespace TreeStructures.Core.Common;

/// <summary>
/// Базовый интерфейс для узла дерева.
/// </summary>
/// <typeparam name="T">Тип значения узла</typeparam>
public interface INode<out T>
{
    /// <summary>
    /// Значение узла.
    /// </summary>
    T Value { get; }

    /// <summary>
    /// Левый потомок.
    /// </summary>
    INode<T>? Left { get; }

    /// <summary>
    /// Правый потомок.
    /// </summary>
    INode<T>? Right { get; }
}

