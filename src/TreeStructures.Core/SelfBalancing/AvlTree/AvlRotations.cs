namespace TreeStructures.Core.SelfBalancing.AvlTree;

/// <summary>
/// Операции поворота для балансировки AVL дерева.
/// </summary>
public static class AvlRotations
{
    /// <summary>
    /// Выполняет правый поворот (Right Rotation).
    /// Используется при дисбалансе типа LL (Left-Left).
    /// </summary>
    /// <typeparam name="T">Тип значений узла</typeparam>
    /// <param name="node">Узел, вокруг которого выполняется поворот</param>
    /// <returns>Новый корень после поворота</returns>
    public static AvlNode<T>? RotateRight<T>(AvlNode<T>? node) where T : IComparable<T>
    {
        // TODO: Реализовать правый поворот
        throw new NotImplementedException();
    }

    /// <summary>
    /// Выполняет левый поворот (Left Rotation).
    /// Используется при дисбалансе типа RR (Right-Right).
    /// </summary>
    /// <typeparam name="T">Тип значений узла</typeparam>
    /// <param name="node">Узел, вокруг которого выполняется поворот</param>
    /// <returns>Новый корень после поворота</returns>
    public static AvlNode<T>? RotateLeft<T>(AvlNode<T>? node) where T : IComparable<T>
    {
        // TODO: Реализовать левый поворот
        throw new NotImplementedException();
    }

    /// <summary>
    /// Выполняет двойной поворот: левый-правый (Left-Right Rotation).
    /// Используется при дисбалансе типа LR (Left-Right).
    /// </summary>
    /// <typeparam name="T">Тип значений узла</typeparam>
    /// <param name="node">Узел, вокруг которого выполняется поворот</param>
    /// <returns>Новый корень после поворота</returns>
    public static AvlNode<T>? RotateLeftRight<T>(AvlNode<T>? node) where T : IComparable<T>
    {
        // TODO: Реализовать двойной поворот Left-Right
        throw new NotImplementedException();
    }

    /// <summary>
    /// Выполняет двойной поворот: правый-левый (Right-Left Rotation).
    /// Используется при дисбалансе типа RL (Right-Left).
    /// </summary>
    /// <typeparam name="T">Тип значений узла</typeparam>
    /// <param name="node">Узел, вокруг которого выполняется поворот</param>
    /// <returns>Новый корень после поворота</returns>
    public static AvlNode<T>? RotateRightLeft<T>(AvlNode<T>? node) where T : IComparable<T>
    {
        // TODO: Реализовать двойной поворот Right-Left
        throw new NotImplementedException();
    }
}

