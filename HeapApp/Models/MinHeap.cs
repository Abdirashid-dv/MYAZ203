namespace HeapApp.Models;

public class MinHeap : Heap
{
    public override double Extract()
    {
        Employee min = list
        .OrderBy(c => c.Salary).First();

        list.Remove(min);

        return min.Salary;
    }
}
