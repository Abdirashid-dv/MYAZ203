namespace HeapApp.Models;

public abstract class Heap
{
    protected List<Employee> list;

    public int count => list.Count();
    public Heap()
    {
        list = new List<Employee>();
    }

    public void Insert(Employee value)
    {
        list.Add(value);
    }

    public abstract double Extract();

}

