using BenchmarkDotNet.Attributes;
using TreeStructures.Core.BinaryTrees;

namespace TreeStructures.Benchmarks;

[MemoryDiagnoser]
public class BinaryTreesBenchmarks
{
    private BinarySearchTree<int> _tree = null!;
    private const int ElementCount = 10000;

    [GlobalSetup]
    public void Setup()
    {
        _tree = new BinarySearchTree<int>();
        // TODO: Добавить элементы для тестирования после реализации
    }

    [Benchmark]
    public void Insert()
    {
        // TODO: Реализовать бенчмарк вставки после реализации
    }

    [Benchmark]
    public void Search()
    {
        // TODO: Реализовать бенчмарк поиска после реализации
    }
}

