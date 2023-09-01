using System.Reflection;


var type = Assembly.GetExecutingAssembly().GetTypes();



// public class Creator<T>
// {
//     public T Create(params object[] arr)
//     {
//         var type = typeof(T);

//         Console.WriteLine(type);
//     }
// }






object obj = 5;

var result = obj switch
{
    int i and < 10 => "kkk",
    Pessoa P and { Nome: "eduardo" } => "oi",
    Pessoa P and { Idade: > 10 } => "hi",
    string s => "oi",
    _ => "Olá"
};
Console.WriteLine(result);

public class Pessoa
{
    public string ?Nome {get; set;}
    public int Idade {get; set;}
}






// string[] arr = new string[]
// {
//     "a", "b", "c", "d"
// };

// if(arr is [_,..,"d"])
// {
//     Console.WriteLine("hehe");
// }





// public class MyAttribute : Attribute
// {

//     public MyAttribute(int data)
//         => this.Data = data;
// }

// [MyAttribute(10)]

