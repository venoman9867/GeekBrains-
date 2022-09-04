Console.WriteLine("Введите значения через пробел");
string[] s=Console.ReadLine().Split(" ");
foreach(string value in s){
    if(value.Length<=3){
        Console.WriteLine(value);
    }
}
