// 11 - Generics
var number = new MyList<int>(5);
var name = new MyList<string>(5);

number.Add(1);
number.Add(2);
number.Add(3);
number.Add(4);
number.Add(5);
number.Add(6);

Console.WriteLine(number.GetContent());

public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit) {
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
    }

    public string GetContent() 
    {
        string content = "";
        foreach (var element in _list)
        {
            content += element + ",";
            
        }
        return content;
    }

}



