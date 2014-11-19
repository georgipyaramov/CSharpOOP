using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GenericList<T>
    where T: struct, IComparable<T>
{
    private T[] list;
    private int currentIndex;

    public GenericList(int capacity)
    {
        this.list = new T[capacity];
        currentIndex = 0;
    }
    public int Count
    {
        get
        {
            return currentIndex;
        }
    }
    public T this [int index]
    {
        get
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return this.list[index];
        }
        set
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
            this.list[index] = value;
        }
    }
    public void Add(T value)
    {
        if (currentIndex == list.Length)
        {
            Resize();
        }
        list[currentIndex] = value;
        currentIndex++;
    }
    public void InsertAt(T value, int position)
    {
        currentIndex++;
        for (int i = this.Count; i > position; i--)
        {
            list[i] = list[i - 1];
        }
        list[position] = value;        
    }
    public void RemoveAt(int position)
    {
        for (int i = position; i < this.Count - 1; i++)
        {
            list[i] = list[i + 1];            
        }
        currentIndex--;  // = this.Count - 1;
    }
    public void Clear()
    {
        currentIndex = 0;
    }
    private void Resize()
    {
        T[] newList = new T[list.Length * 2];
        for (int i = 0; i < currentIndex; i++)
        {
            newList[i] = list[i];
        }
        list = newList;
    }
    public T GetMax<Type>() where Type : IComparable<T>, IComparable
    {
        dynamic max;
        return max = this.list.Max();
    }
    public T GetMin<Type>() where Type : IComparable<T>, IComparable
    {
        dynamic min;
        return min = this.list.Min();
    }
    public override string ToString()
    {
        StringBuilder toBePrinted = new StringBuilder(); 
        for (int i = 0; i < this.Count; i++)
        {
            toBePrinted.Append(this.list[i] + " ");
        }
        return toBePrinted.ToString();
    }
    
}

