#region 1-masala
public class MyQueue
{
    Stack<int> main = new();
    Stack<int> temp = new();

    public MyQueue()
    {

    }

    public void Push(int x)
    {
        while (main.Count > 0) temp.Push(main.Pop());
        main.Push(x);
        while (temp.Count > 0) main.Push(temp.Pop());
    }

    public int Pop()
    {
        return main.Pop();
    }

    public int Peek()
    {
        return main.Peek();
    }

    public bool Empty()
    {
        return main.Count == 0;
    }
}
#endregion


#region 2-masala
public class MyStack
{
    private Queue<int> q;

    public MyStack()
    {
        q = new Queue<int>();
    }

    public void Push(int x)
    {
        q.Enqueue(x);
        for (int i = 0; i < q.Count - 1; i++)
        {
            q.Enqueue(q.Dequeue());
        }
    }

    public int Pop()
    {
        return q.Dequeue();
    }

    public int Top()
    {
        return q.Peek();
    }

    public bool Empty()
    {
        return q.Count == 0;
    }
}
#endregion

#region 4-masala
public class MyLinkedList
{
    List<int> myList;

    public MyLinkedList()
    {
        myList = new();
    }

    public int Get(int index)
    {
        if (index < 0 || index >= myList.Count)
            return -1;

        return myList[index];
    }

    public void AddAtHead(int val)
    {
        myList.Insert(0, val);
    }

    public void AddAtTail(int val)
    {
        myList.Add(val);
    }

    public void AddAtIndex(int index, int val)
    {
        if (index < 0 || index > myList.Count)
            return;

        myList.Insert(index, val);
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= myList.Count)
            return;

        myList.RemoveAt(index);
    }
}


#endregion
