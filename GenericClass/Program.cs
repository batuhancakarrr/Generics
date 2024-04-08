using System;
using System.ComponentModel;
public class Program
{
    private static void Main(string[] args)
    {
        List<string> sehirler = new List<string>();
        sehirler.Add("Ankara");
        sehirler.Add("Konya");
        Console.WriteLine(sehirler.Count);

        MyList<string> sehirler2 = new MyList<string>();
        sehirler2.Add("İzmir");
        sehirler2.Add("Muğla");
        sehirler2.Add("Antalya");
        Console.WriteLine(sehirler2.Count);
        sehirler2.Write();
    }
}

public class MyList<T>
{
    T[] _array;
    T[] _tempArray;

    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];

        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
            _array[_array.Length - 1] = item;
    }

    public int Count { get { return _array.Length; } }

    public void Write()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            T item = _array[i];
            Console.WriteLine(item);
        }
    }

}