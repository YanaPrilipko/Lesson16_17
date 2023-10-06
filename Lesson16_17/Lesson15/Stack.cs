using System.Collections;
using System.Xml.Linq;


public class Stack<T> 
{
    private List<T> student = new List<T>();

    public void Push(T obj)//додає obj на вершині стека
    {
        student.Add(obj);
    }

    public T Pop()//повертає верхній елемент стека та видаляє його
    {
        var item = Peek();
        student.Remove(item);
        return item;
    }

    public void Clear()// очистити стек
    {
        student.Clear();
    }

    public int Count// властивість повертає кількість елементів
    {
        get { return student.Count; }
    }

    public T Peek()//  повертає верхній елемент, але не видаляє його
    {
        if (student.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return student[student.Count - 1];
    }

    public void CopyTo(T[] array, int arrayIndex)//копіює стек в масив
    {
        student.CopyTo(array, arrayIndex);
    }

}
