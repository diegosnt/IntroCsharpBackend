// 11 - Generics
using System.Diagnostics;
using System.Xml.Linq;

var number = new MyList<int>(5);
var name = new MyList<string>(5);
var beer = new MyList<Beer>(3);

number.Add(1);
number.Add(2);
number.Add(3);
number.Add(4);
number.Add(5);
number.Add(6);
number.Add(7);
number.Add(8);

name.Add("a");
name.Add("b");
name.Add("c");
name.Add("d");
name.Add("e");
name.Add("f");
name.Add("g");

beer.Add(new Beer()
{
    Name = "X1",
    Price = 10
});

beer.Add(new Beer()
{
    Name = "Z2",
    Price = 30
});

beer.Add(new Beer()
{
    Name = "R1",
    Price = 40
});

beer.Add(new Beer()
{
    Name = "F2",
    Price = 60
});

//Console.WriteLine(number.GetContent());
//Console.WriteLine(name.GetContent());
Console.WriteLine(beer.GetContent());

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

public class Beer
{
    public string Name {  get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return "Nombre: " + Name + " | Price: " + Price;
    }
}



