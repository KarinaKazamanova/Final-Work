System.Console.WriteLine("Введите массив");
string? coordinates = Console.ReadLine();
string  coordinates1 = Replace (coordinates, ',' ,' ');
string  coordinates2 = Delete (coordinates1, ')');
string  coordinates3 = Delete (coordinates2, '(');  
string[] figure = coordinates3.Split(" ");
string [] b = NoMoreThanThree ( a);
Print (b);
string [] NoMoreThanThree (string [] a)
{
    string [] b = new string [0];
    for (int i = 0; i <a.Length; i ++)
    {
        if (a[i].Length <4)
        {
            b = b.Append (a[i]).ToArray();
        }
    }
    return b;
}
void Print (string [] a)
{
    for (int i = 0; i <a.Length; i ++)
    {
        System.Console.Write($"'{a[i]}', ");
    }
}
