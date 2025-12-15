namespace TreeStructures.Core.Applications;

/// <summary>
/// Узел дерева выражений (Expression Tree).
/// Используется для представления арифметических выражений в виде дерева.
/// </summary>
public class ExpressionNode
{
    /// <summary>
    /// Тип узла: число или операция.
    /// </summary>
    public ExpressionNodeType Type { get; set; }

    /// <summary>
    /// Значение числа (если Type == Number).
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// Операция (если Type == Operator): +, -, *, /, etc.
    /// </summary>
    public char? Operator { get; set; }

    /// <summary>
    /// Левый потомок (операнд или подвыражение).
    /// </summary>
    public ExpressionNode? Left { get; set; }

    /// <summary>
    /// Правый потомок (операнд или подвыражение).
    /// </summary>
    public ExpressionNode? Right { get; set; }
}

/// <summary>
/// Тип узла дерева выражений.
/// </summary>
public enum ExpressionNodeType
{
    /// <summary>
    /// Число (лист дерева).
    /// </summary>
    Number,

    /// <summary>
    /// Операция (внутренний узел).
    /// </summary>
    Operator
}

/// <summary>
/// Дерево выражений для представления и вычисления арифметических выражений.
/// </summary>
public class ExpressionTree
{
    private ExpressionNode? _root;

    /// <summary>
    /// Строит дерево выражений из строки (инфиксная нотация с поддержкой скобок).
    /// </summary>
    /// <param name="expression">Арифметическое выражение в виде строки</param>
    public void BuildFromString(string expression)
    {
        // TODO: Реализовать построение дерева из строки (парсинг выражений)
        throw new NotImplementedException();
    }

    /// <summary>
    /// Вычисляет значение выражения путём обхода дерева.
    /// Сложность: O(n), где n - количество узлов.
    /// </summary>
    /// <returns>Результат вычисления выражения</returns>
    public double Evaluate()
    {
        // TODO: Реализовать вычисление значения выражения
        throw new NotImplementedException();
    }
}

