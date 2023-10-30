namespace HeapApp.Models;

public class MaxHeap : Heap
{
    public override double Extract()
    {
        Employee max = list
        .OrderByDescending(c => c.Salary).First();
        list.Remove(max);
        return max.Salary;
    }
}